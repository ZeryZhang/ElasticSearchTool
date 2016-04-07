using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Newtonsoft.Json;
using Elasticsearch.Net;
using RestSharp;
using SearchTool.Entity;

namespace SearchTool
{
    public class ElasticSearchService
    {
        
        private IElasticClient EsClient;
      
        public ElasticSearchService(bool isProduct)
        {
           EsClient = (isProduct == true ? ElasticSearchConfig.GetProductEsClient() : ElasticSearchConfig.GetTestEsClient());
        }

        /// <summary>
        /// 获取所有索引名
        /// </summary>
        /// <returns></returns>
        public List<string> GetIndexs()
        {
            var indexs = new List<string>();
            var aliases = EsClient.CatAliases();
            if (aliases.Records!=null&&aliases.Records.Any())
            {//有别名优先用别名
                indexs.AddRange(aliases.Records.ToList().Select(s => s.Alias));
            }
            else
            {
                var indices = EsClient.CatIndices();
                if (indices.Records != null&&indices.Records.Any())
                {
                    indexs.AddRange(indices.Records.ToList().Select(o => o.Index));
                }
            }

            return indexs;
        }

        /// <summary>
        /// 获取指定索引下的Docment属性
        /// </summary>
        /// <param name="indexName"></param>
        /// <returns></returns>
        public List<string> GetDocumentAttribute(string indexName)
        {

            List<string> docPropert = new List<string>();
            if (!string.IsNullOrEmpty(indexName))
            {
                var type = EsClient.GetMapping<string>(m => m.Index(indexName).AllTypes());

                if (type.Mapping != null && type.Mapping.Properties != null)
                {
                    foreach (var propert in type.Mapping.Properties)
                    {
                        if (propert.Key.Name.Equals("schedulings"))
                            continue;
                        docPropert.Add(propert.Key.Name);
                    }
                    docPropert.AddRange(new string[] {"schedulings.date", "schedulings.surplusNumber"});
                }
            }
            return docPropert;
        }

        /// <summary>
        ///从ES查询
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="propertyName"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public string Search(string indexName, string propertyName, string searchValue,int from )
        {
            SearchDescriptor<object> searchDescriptor = new SearchDescriptor<object>();
            
            if (propertyName.Equals("schedulings.date") || propertyName.Equals("schedulings.surplusNumber"))
            {//Nested对象
                searchDescriptor.Query(
                    query =>
                        query.Nested(
                            nested =>
                                nested.Path("schedulings")
                                    .Query(nquery => nquery.Term(term => term.Field(propertyName).Value(searchValue)))));
            }
            else if (propertyName.Equals("doctorName") || propertyName.Equals("hospitalDepartmentName") ||
                propertyName.Equals("professionalDepartmentName"))
            {//需分词查询
                searchDescriptor.Query(
                    query =>
                        query.Match(match=>match.Field(propertyName).Query(searchValue)));
            }
            else
            {
                if (string.IsNullOrWhiteSpace(searchValue))
                {
                    searchDescriptor.Index(indexName).Type("appointmentdoctor").Query(q => q.MatchAll());
                }
                else
                {
                    searchDescriptor.Query(q => q.Term(t => t.Field(propertyName).Value(searchValue)));
                }
            }
            
            var searchResponse = EsClient.Search<object>(searchDescriptor.From(from).Size(10));
            
            var list = searchResponse.Documents.ToList();

            return JsonConvert.SerializeObject(list);
        }

    }


   
}
