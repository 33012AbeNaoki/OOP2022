
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
            this.btWeatherGET = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNitiji = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGaikyou = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMintmp0 = new System.Windows.Forms.TextBox();
            this.tbMintmp2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMaxtmp0 = new System.Windows.Forms.TextBox();
            this.tbMaxtmp2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb0 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pb0 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            this.SuspendLayout();
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
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "宗谷地方",
            "上川・留萌地方",
            "網走・北見・紋別地方",
            "釧路・根室地方",
            "胆振・日高地方",
            "石狩・空知・後志地方",
            "渡島・檜山地方",
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県",
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県",
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "三重県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県",
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県",
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "山口県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "奄美地方",
            "鹿児島県（奄美地方除く）",
            "沖縄本島地方",
            "大東島地方",
            "宮古島地方",
            "八重山地方"});
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
            this.tbNitiji.Location = new System.Drawing.Point(137, 95);
            this.tbNitiji.Multiline = true;
            this.tbNitiji.Name = "tbNitiji";
            this.tbNitiji.Size = new System.Drawing.Size(167, 28);
            this.tbNitiji.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "観測日時";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(-1, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "明後日の天気";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb1.Location = new System.Drawing.Point(138, 197);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(129, 63);
            this.tb1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(11, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "詳細";
            // 
            // tbGaikyou
            // 
            this.tbGaikyou.Location = new System.Drawing.Point(118, 344);
            this.tbGaikyou.Multiline = true;
            this.tbGaikyou.Name = "tbGaikyou";
            this.tbGaikyou.Size = new System.Drawing.Size(425, 154);
            this.tbGaikyou.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(5, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "明日の天気";
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb2.Location = new System.Drawing.Point(137, 266);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(130, 58);
            this.tb2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(273, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "最低気温";
            // 
            // tbMintmp0
            // 
            this.tbMintmp0.Location = new System.Drawing.Point(377, 141);
            this.tbMintmp0.Multiline = true;
            this.tbMintmp0.Name = "tbMintmp0";
            this.tbMintmp0.Size = new System.Drawing.Size(53, 48);
            this.tbMintmp0.TabIndex = 0;
            // 
            // tbMintmp2
            // 
            this.tbMintmp2.Location = new System.Drawing.Point(377, 197);
            this.tbMintmp2.Multiline = true;
            this.tbMintmp2.Name = "tbMintmp2";
            this.tbMintmp2.Size = new System.Drawing.Size(53, 48);
            this.tbMintmp2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(449, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "最高気温";
            // 
            // tbMaxtmp0
            // 
            this.tbMaxtmp0.Location = new System.Drawing.Point(559, 141);
            this.tbMaxtmp0.Multiline = true;
            this.tbMaxtmp0.Name = "tbMaxtmp0";
            this.tbMaxtmp0.Size = new System.Drawing.Size(53, 48);
            this.tbMaxtmp0.TabIndex = 0;
            // 
            // tbMaxtmp2
            // 
            this.tbMaxtmp2.Location = new System.Drawing.Point(559, 197);
            this.tbMaxtmp2.Multiline = true;
            this.tbMaxtmp2.Name = "tbMaxtmp2";
            this.tbMaxtmp2.Size = new System.Drawing.Size(53, 48);
            this.tbMaxtmp2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(273, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "最低気温";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(449, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "最高気温";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(5, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "今日の天気";
            // 
            // tb0
            // 
            this.tb0.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb0.Location = new System.Drawing.Point(137, 129);
            this.tb0.Multiline = true;
            this.tb0.Name = "tb0";
            this.tb0.Size = new System.Drawing.Size(130, 64);
            this.tb0.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(277, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "最低気温";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 251);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 48);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(559, 251);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 48);
            this.textBox3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(449, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "最高気温";
            // 
            // pb0
            // 
            this.pb0.Location = new System.Drawing.Point(669, 95);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(76, 53);
            this.pb0.TabIndex = 4;
            this.pb0.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 681);
            this.Controls.Add(this.pb0);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherGET);
            this.Controls.Add(this.tbGaikyou);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbMaxtmp2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbMintmp2);
            this.Controls.Add(this.tbMaxtmp0);
            this.Controls.Add(this.tbMintmp0);
            this.Controls.Add(this.tb0);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tbNitiji);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btWeatherGET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNitiji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGaikyou;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMintmp0;
        private System.Windows.Forms.TextBox tbMintmp2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMaxtmp0;
        private System.Windows.Forms.TextBox tbMaxtmp2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pb0;
    }
}

