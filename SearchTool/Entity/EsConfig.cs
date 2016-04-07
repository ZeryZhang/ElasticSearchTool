using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTool.Entity
{
    /// <summary>
    /// ES环境设置
    /// </summary>
    public class EsConfig
    {
        /// <summary>
        /// 正式环境
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// 测试环境
        /// </summary>
        public string Test { get; set; }
    }
}
