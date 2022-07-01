
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.cbRssurl = new System.Windows.Forms.ComboBox();
            this.btRssget = new System.Windows.Forms.Button();
            this.lbRsstitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cbRssurl
            // 
            this.cbRssurl.FormattingEnabled = true;
            this.cbRssurl.Location = new System.Drawing.Point(30, 21);
            this.cbRssurl.Name = "cbRssurl";
            this.cbRssurl.Size = new System.Drawing.Size(520, 20);
            this.cbRssurl.TabIndex = 0;
            // 
            // btRssget
            // 
            this.btRssget.Location = new System.Drawing.Point(572, 21);
            this.btRssget.Name = "btRssget";
            this.btRssget.Size = new System.Drawing.Size(83, 23);
            this.btRssget.TabIndex = 1;
            this.btRssget.Text = "取得";
            this.btRssget.UseVisualStyleBackColor = true;
            this.btRssget.Click += new System.EventHandler(this.btRssget_Click);
            // 
            // lbRsstitle
            // 
            this.lbRsstitle.FormattingEnabled = true;
            this.lbRsstitle.ItemHeight = 12;
            this.lbRsstitle.Location = new System.Drawing.Point(33, 61);
            this.lbRsstitle.Name = "lbRsstitle";
            this.lbRsstitle.Size = new System.Drawing.Size(238, 616);
            this.lbRsstitle.TabIndex = 2;
            this.lbRsstitle.SelectedIndexChanged += new System.EventHandler(this.lbRsstitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(277, 61);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(641, 616);
            this.wbBrowser.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 719);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRsstitle);
            this.Controls.Add(this.btRssget);
            this.Controls.Add(this.cbRssurl);
            this.Name = "Form1";
            this.Text = "RSS Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRssurl;
        private System.Windows.Forms.Button btRssget;
        private System.Windows.Forms.ListBox lbRsstitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
    }
}

