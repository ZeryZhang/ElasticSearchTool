namespace SearchTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cbIndexNames = new System.Windows.Forms.ComboBox();
            this.cbProperty = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.CheckBox();
            this.cbTest = new System.Windows.Forms.CheckBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ES服务地址：";
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtServerUrl.Location = new System.Drawing.Point(83, 16);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(541, 26);
            this.txtServerUrl.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(630, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 27);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查 询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cbIndexNames
            // 
            this.cbIndexNames.DropDownHeight = 120;
            this.cbIndexNames.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIndexNames.FormattingEnabled = true;
            this.cbIndexNames.IntegralHeight = false;
            this.cbIndexNames.ItemHeight = 20;
            this.cbIndexNames.Location = new System.Drawing.Point(83, 79);
            this.cbIndexNames.Name = "cbIndexNames";
            this.cbIndexNames.Size = new System.Drawing.Size(258, 28);
            this.cbIndexNames.TabIndex = 3;
            this.cbIndexNames.SelectedIndexChanged += new System.EventHandler(this.combobox_Changed);
            // 
            // cbProperty
            // 
            this.cbProperty.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbProperty.FormattingEnabled = true;
            this.cbProperty.IntegralHeight = false;
            this.cbProperty.Location = new System.Drawing.Point(394, 78);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.Size = new System.Drawing.Size(311, 28);
            this.cbProperty.TabIndex = 4;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchValue.Location = new System.Drawing.Point(83, 115);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(258, 26);
            this.txtSearchValue.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "索引名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "属性名：";
            // 
            // txtSearResult
            // 
            this.txtSearResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearResult.Location = new System.Drawing.Point(26, 151);
            this.txtSearResult.Multiline = true;
            this.txtSearResult.Name = "txtSearResult";
            this.txtSearResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearResult.Size = new System.Drawing.Size(679, 471);
            this.txtSearResult.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "关键字：";
            // 
            // cbProduct
            // 
            this.cbProduct.AutoSize = true;
            this.cbProduct.Location = new System.Drawing.Point(83, 51);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(51, 21);
            this.cbProduct.TabIndex = 10;
            this.cbProduct.Text = "生产";
            this.cbProduct.UseVisualStyleBackColor = true;
            this.cbProduct.CheckedChanged += new System.EventHandler(this.cbProduct_Changed);
            // 
            // cbTest
            // 
            this.cbTest.AutoSize = true;
            this.cbTest.Location = new System.Drawing.Point(140, 51);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(51, 21);
            this.cbTest.TabIndex = 11;
            this.cbTest.Text = "测试";
            this.cbTest.UseVisualStyleBackColor = true;
            this.cbTest.CheckedChanged += new System.EventHandler(this.cbTest_Changed);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(246, 629);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 12;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(351, 629);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentPage.Location = new System.Drawing.Point(329, 630);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(17, 20);
            this.lblCurrentPage.TabIndex = 14;
            this.lblCurrentPage.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 635);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Author：Zery";
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.ForeColor = System.Drawing.Color.Red;
            this.lblTips.Location = new System.Drawing.Point(221, 51);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(12, 17);
            this.lblTips.TabIndex = 16;
            this.lblTips.Text = " ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(732, 658);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.cbTest);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.txtSearResult);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.cbProperty);
            this.Controls.Add(this.cbIndexNames);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtServerUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrentPage);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ElasticSearch Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cbIndexNames;
        private System.Windows.Forms.ComboBox cbProperty;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbProduct;
        private System.Windows.Forms.CheckBox cbTest;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTips;
    }
}

