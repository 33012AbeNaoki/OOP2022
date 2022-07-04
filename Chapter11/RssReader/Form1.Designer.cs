
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
            this.btForward = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.wvBrowser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
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
            this.lbRsstitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRsstitle.FormattingEnabled = true;
            this.lbRsstitle.ItemHeight = 12;
            this.lbRsstitle.Location = new System.Drawing.Point(33, 61);
            this.lbRsstitle.Name = "lbRsstitle";
            this.lbRsstitle.Size = new System.Drawing.Size(238, 616);
            this.lbRsstitle.TabIndex = 2;
            this.lbRsstitle.SelectedIndexChanged += new System.EventHandler(this.lbRsstitle_SelectedIndexChanged);
            // 
            // btForward
            // 
            this.btForward.Enabled = false;
            this.btForward.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btForward.Location = new System.Drawing.Point(853, 21);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(65, 36);
            this.btForward.TabIndex = 4;
            this.btForward.Text = "🔜";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btBack
            // 
            this.btBack.Enabled = false;
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(782, 21);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(65, 36);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "🔙";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // wvBrowser
            // 
            this.wvBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wvBrowser.Location = new System.Drawing.Point(277, 61);
            this.wvBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrowser.Name = "wvBrowser";
            this.wvBrowser.Size = new System.Drawing.Size(651, 612);
            this.wvBrowser.TabIndex = 5;
            this.wvBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.wvBrowser_NavigationCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 685);
            this.Controls.Add(this.wvBrowser);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.lbRsstitle);
            this.Controls.Add(this.btRssget);
            this.Controls.Add(this.cbRssurl);
            this.Name = "Form1";
            this.Text = "RSS Reader";
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRssurl;
        private System.Windows.Forms.Button btRssget;
        private System.Windows.Forms.ListBox lbRsstitle;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btBack;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrowser;
    }
}

