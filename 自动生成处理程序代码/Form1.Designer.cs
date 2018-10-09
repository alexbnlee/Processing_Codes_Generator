namespace 自动生成处理程序代码
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.nud_month = new System.Windows.Forms.NumericUpDown();
            this.nud_year = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "年份：";
            // 
            // cb_year
            // 
            this.cb_year.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cb_year.Location = new System.Drawing.Point(64, 15);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(70, 28);
            this.cb_year.TabIndex = 10;
            this.cb_year.SelectedIndexChanged += new System.EventHandler(this.cb_year_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(170, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "月份：";
            // 
            // cb_month
            // 
            this.cb_month.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_month.Location = new System.Drawing.Point(221, 15);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(52, 28);
            this.cb_month.TabIndex = 11;
            this.cb_month.SelectedIndexChanged += new System.EventHandler(this.cb_month_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(313, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "海域：";
            // 
            // cb_area
            // 
            this.cb_area.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Items.AddRange(new object[] {
            "全部海域",
            "浙江海域",
            "北戴河海域",
            "江苏海域",
            "东海海域",
            "福建海域",
            "曹妃甸",
            "辽东湾海域"});
            this.cb_area.Location = new System.Drawing.Point(364, 15);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(111, 28);
            this.cb_area.TabIndex = 12;
            this.cb_area.SelectedIndexChanged += new System.EventHandler(this.cb_area_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(364, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成 + 复制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_result
            // 
            this.tb_result.BackColor = System.Drawing.Color.Black;
            this.tb_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_result.Font = new System.Drawing.Font("Consolas", 18F);
            this.tb_result.ForeColor = System.Drawing.Color.Lime;
            this.tb_result.Location = new System.Drawing.Point(5, 13);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(454, 29);
            this.tb_result.TabIndex = 13;
            // 
            // nud_month
            // 
            this.nud_month.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_month.Location = new System.Drawing.Point(221, 49);
            this.nud_month.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nud_month.Name = "nud_month";
            this.nud_month.Size = new System.Drawing.Size(52, 26);
            this.nud_month.TabIndex = 14;
            this.nud_month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_month.ValueChanged += new System.EventHandler(this.nud_month_ValueChanged);
            // 
            // nud_year
            // 
            this.nud_year.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_year.Location = new System.Drawing.Point(64, 49);
            this.nud_year.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nud_year.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.nud_year.Name = "nud_year";
            this.nud_year.Size = new System.Drawing.Size(70, 26);
            this.nud_year.TabIndex = 14;
            this.nud_year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_year.ValueChanged += new System.EventHandler(this.nud_year_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tb_result);
            this.panel1.Location = new System.Drawing.Point(12, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 54);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 197);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nud_year);
            this.Controls.Add(this.nud_month);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "自动生成处理程序代码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.NumericUpDown nud_month;
        private System.Windows.Forms.NumericUpDown nud_year;
        private System.Windows.Forms.Panel panel1;
    }
}

