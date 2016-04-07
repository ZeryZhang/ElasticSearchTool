using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SearchTool
{
    public partial class Form1 : Form
    {
        private ElasticSearchService elasticSearchService;
        
        private int currentPage = 1;
        private int from = 0;

        public Form1()
        {
            InitializeComponent();
            elasticSearchService = new ElasticSearchService(false);

            var indexs = elasticSearchService.GetIndexs();
            var propertys = elasticSearchService.GetDocumentAttribute(indexs.FirstOrDefault());
            BindIndexName(indexs);
            BindProperty(propertys);
            cbTest.Checked = true;
        }

        /// <summary>
        /// 查询按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            recover();
            Search();
        }

        /// <summary>
        /// 恢复初始值
        /// </summary>
        private void recover()
        {
            from = 0;
            currentPage = 1;
            lblCurrentPage.Text = currentPage.ToString();
        }

        /// <summary>
        /// 查询事件
        /// </summary>
        public void Search()
        {
            if (cbIndexNames.SelectedItem != null && cbProperty.SelectedItem != null)
            {
                string selectedIndexName =
                    ((System.Collections.Generic.KeyValuePair<string, string>) (cbIndexNames.SelectedItem)).Key;
                string selectedPropertyName =
                    ((System.Collections.Generic.KeyValuePair<string, string>) (cbProperty.SelectedItem)).Key;
                string searchValue = txtSearchValue.Text;

                var jsonData = elasticSearchService.Search(selectedIndexName, selectedPropertyName, searchValue, from);

                string formatJson = FormatJsonString(jsonData);

                txtSearResult.Text = formatJson;
            }
        }

        /// <summary>
        /// 绑定索引名
        /// </summary>
        /// <param name="indexNames"></param>
        public void BindIndexName(List<string> indexNames)
        {
            if (indexNames.Any())
            {
                Dictionary<string, string> indexDictionary = new Dictionary<string, string>();
                indexNames.ForEach(o =>
                {
                    indexDictionary.Add(o, o);
                });
                BindingSource bd = new BindingSource();
                bd.DataSource = indexDictionary;
                cbIndexNames.DataSource = bd;
                cbIndexNames.ValueMember = "Key";
                cbIndexNames.DisplayMember = "Value";
            }
        }

        /// <summary>
        /// 绑定document属性名
        /// </summary>
        /// <param name="propertyList"></param>
        public void BindProperty(List<string> propertyList)
        {
            if (propertyList.Any())
            {
                Dictionary<string, string> propeDictionary = new Dictionary<string, string>();
                propertyList.ForEach(o =>
                {
                    propeDictionary.Add(o, o);
                });
                BindingSource bd = new BindingSource();
                bd.DataSource = propeDictionary;
                cbProperty.DataSource = bd;
                cbProperty.ValueMember = "Key";
                cbProperty.DisplayMember = "Value";
            }
        }

        /// <summary>
        /// 格式化JSON
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string FormatJsonString(string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }

        #region 控件事件
        /// <summary>
        ///生产环境checkbox 事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cbProduct_Changed(object sender, EventArgs e)
        {
            if (cbProduct.Checked)
            {
                cbTest.Checked = false;
                elasticSearchService = new ElasticSearchService(true);
                txtServerUrl.Text = ElasticSearchConfig.EsProductConfig;
                lblTips.Text = "Tips:正式环境需要登录VPN";
            }
        }

        /// <summary>
        /// 测试环境checkbox 事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cbTest_Changed(object sender, EventArgs e)
        {
            if (cbTest.Checked)
            {
                cbProduct.Checked = false;
                elasticSearchService = new ElasticSearchService(false);
                txtServerUrl.Text = ElasticSearchConfig.EsTestConfig;
                lblTips.Text = string.Empty;
            }
        }

        /// <summary>
        /// combobox 切换索引选项事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void combobox_Changed(object sender, EventArgs e)
        {
            string selectedIndexName = ((System.Collections.Generic.KeyValuePair<string, string>)(cbIndexNames.SelectedItem)).Key;
            List<string> propertyList = elasticSearchService.GetDocumentAttribute(selectedIndexName);
            BindProperty(propertyList);
        }


        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                currentPage--;
                if (currentPage == 1)
                {
                    from = 0;
                }
                else
                {
                    from = from - 10;
                }

                Search();
                lblCurrentPage.Text = currentPage.ToString();
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage != 0)
            {
                if (!string.IsNullOrEmpty(txtSearResult.Text))
                {
                    from = currentPage * 10 + 1;
                    currentPage++;
                    Search();
                }
            }
            lblCurrentPage.Text = currentPage.ToString();
        }


        #endregion


  

    }
}
