using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Newtonsoft.Json;
using RestSharp;
using SearchTool.Entity;

namespace SearchTool
{
    public static class ElasticSearchConfig
    {
        private static readonly string ServerconfigUrl = "http://192.168.0.21:9500/Esconfig.json";

        public  static readonly string EsProductConfig;
        public static readonly string EsTestConfig;

        static ElasticSearchConfig()
        {
            var esConfig = getEsConfig();
            EsProductConfig = esConfig.Product;
            EsTestConfig = esConfig.Test;
        }

        /// <summary>
        /// 正式环境客户端
        /// </summary>
        /// <returns></returns>
        public static IElasticClient GetProductEsClient()
        {
            IElasticClient EsClient = new ElasticClient(new ConnectionSettings(new Uri(EsProductConfig)));

            return EsClient;
        }
        /// <summary>
        /// 测试环境客户端
        /// </summary>
        /// <returns></returns>
        public static IElasticClient GetTestEsClient()
        {
            IElasticClient EsClient = new ElasticClient(new ConnectionSettings(new Uri(EsTestConfig)));

            return EsClient;
        }

        /// <summary>
        /// 获取ES地址配置
        /// </summary>
        /// <returns></returns>
        private static EsConfig getEsConfig()
        {
            var esConfig = new EsConfig();

            RestClient client = new RestClient(ServerconfigUrl);
            RestRequest reqeust = new RestRequest(Method.GET);
            var response = client.Execute(reqeust);

            //特殊字符，在FireBug  console中可以看到
            string s1 = "﻿{\"Product\":\"http://192.168.0.234:9200\",\"Test\":\"http://192.168.0.63:9200\"}";
            
            if (!string.IsNullOrEmpty(response.Content))
            {
                //不截断会出现特殊字符
                esConfig = JsonConvert.DeserializeObject<EsConfig>(response.Content.Replace("\r\n","").Substring(1,response.Content.Length-1));
            }
            
            return esConfig;
        }

    }
}
