
namespace WeatherApp {
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
            this.tbKansoku = new System.Windows.Forms.TextBox();
            this.btWeatherGET = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNitiji = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHedline = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSyousai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbKansoku
            // 
            this.tbKansoku.Location = new System.Drawing.Point(137, 111);
            this.tbKansoku.Multiline = true;
            this.tbKansoku.Name = "tbKansoku";
            this.tbKansoku.Size = new System.Drawing.Size(207, 28);
            this.tbKansoku.TabIndex = 0;
            // 
            // btWeatherGET
            // 
            this.btWeatherGET.Location = new System.Drawing.Point(358, 55);
            this.btWeatherGET.Name = "btWeatherGET";
            this.btWeatherGET.Size = new System.Drawing.Size(72, 33);
            this.btWeatherGET.TabIndex = 1;
            this.btWeatherGET.Text = "取得";
            this.btWeatherGET.UseVisualStyleBackColor = true;
            this.btWeatherGET.Click += new System.EventHandler(this.btWeatherGET_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "地域";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "観測地点";
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "宗谷地方,011000",
            "上川・留萌地方,012000",
            "網走・北見・紋別地方,013000",
            "十勝地方,014030",
            "釧路・根室地方,014100",
            "胆振・日高地方,015000",
            "石狩・空知・後志地方,016000",
            "渡島・檜山地方,017000",
            "青森県,020000",
            "岩手県,030000",
            "宮城県,040000",
            "秋田県,050000",
            "山形県,060000",
            "福島県,070000",
            "茨城県,080000",
            "栃木県,090000",
            "群馬県,100000",
            "埼玉県,110000",
            "千葉県,120000",
            "東京都,130000",
            "神奈川県,140000",
            "山梨県,190000",
            "長野県,200000",
            "岐阜県,210000",
            "静岡県,220000",
            "愛知県,230000",
            "三重県,240000",
            "新潟県,150000",
            "富山県,160000",
            "石川県,170000",
            "福井県,180000",
            "滋賀県,250000",
            "京都府,260000",
            "大阪府,270000",
            "兵庫県,280000",
            "奈良県,290000",
            "和歌山県,300000",
            "鳥取県,310000",
            "島根県,320000",
            "岡山県,330000",
            "広島県,340000",
            "徳島県,360000",
            "香川県,370000",
            "愛媛県,380000",
            "高知県,390000",
            "山口県,350000",
            "福岡県,400000",
            "佐賀県,410000",
            "長崎県,420000",
            "熊本県,430000",
            "大分県,440000",
            "宮崎県,450000",
            "奄美地方,460040",
            "鹿児島県（奄美地方除く）,460100",
            "沖縄本島地方,471000",
            "大東島地方,472000",
            "宮古島地方,473000",
            "八重山地方,474000"});
            this.cbSelect.Location = new System.Drawing.Point(137, 59);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(167, 20);
            this.cbSelect.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 2;
            // 
            // tbNitiji
            // 
            this.tbNitiji.Location = new System.Drawing.Point(138, 161);
            this.tbNitiji.Multiline = true;
            this.tbNitiji.Name = "tbNitiji";
            this.tbNitiji.Size = new System.Drawing.Size(207, 28);
            this.tbNitiji.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "観測日時";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(3, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "ヘッドライン";
            // 
            // tbHedline
            // 
            this.tbHedline.Location = new System.Drawing.Point(137, 206);
            this.tbHedline.Multiline = true;
            this.tbHedline.Name = "tbHedline";
            this.tbHedline.Size = new System.Drawing.Size(312, 63);
            this.tbHedline.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(54, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "詳細";
            // 
            // tbSyousai
            // 
            this.tbSyousai.Location = new System.Drawing.Point(137, 291);
            this.tbSyousai.Multiline = true;
            this.tbSyousai.Name = "tbSyousai";
            this.tbSyousai.Size = new System.Drawing.Size(312, 147);
            this.tbSyousai.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 501);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherGET);
            this.Controls.Add(this.tbSyousai);
            this.Controls.Add(this.tbHedline);
            this.Controls.Add(this.tbNitiji);
            this.Controls.Add(this.tbKansoku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKansoku;
        private System.Windows.Forms.Button btWeatherGET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNitiji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHedline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSyousai;
    }
}

