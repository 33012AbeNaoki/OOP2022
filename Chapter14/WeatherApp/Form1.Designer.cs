
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toMax = new System.Windows.Forms.Label();
            this.tomoMin = new System.Windows.Forms.Label();
            this.tomoMax = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tomo2Min = new System.Windows.Forms.Label();
            this.tomo2Max = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.tmDOmax = new System.Windows.Forms.Label();
            this.tm2DOmax = new System.Windows.Forms.Label();
            this.tm2DOmin = new System.Windows.Forms.Label();
            this.tmDOmin = new System.Windows.Forms.Label();
            this.tDOmax = new System.Windows.Forms.Label();
            this.toMin = new System.Windows.Forms.Label();
            this.toDOmin = new System.Windows.Forms.Label();
            this.lb0 = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbtoday = new System.Windows.Forms.Label();
            this.lbtomo = new System.Windows.Forms.Label();
            this.lbtomo2 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btWeatherGET
            // 
            this.btWeatherGET.BackColor = System.Drawing.Color.Transparent;
            this.btWeatherGET.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherGET.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btWeatherGET.Location = new System.Drawing.Point(296, 16);
            this.btWeatherGET.Name = "btWeatherGET";
            this.btWeatherGET.Size = new System.Drawing.Size(85, 54);
            this.btWeatherGET.TabIndex = 1;
            this.btWeatherGET.Text = "取得";
            this.btWeatherGET.UseVisualStyleBackColor = false;
            this.btWeatherGET.Click += new System.EventHandler(this.btWeatherGET_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "地域";
            // 
            // cbSelect
            // 
            this.cbSelect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbSelect.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbSelect.ForeColor = System.Drawing.Color.Black;
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
            this.cbSelect.Location = new System.Drawing.Point(84, 29);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(167, 32);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "観測日時";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(569, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "明後日の天気";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(772, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "詳細";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(293, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "明日の天気";
            // 
            // toMax
            // 
            this.toMax.AutoSize = true;
            this.toMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toMax.ForeColor = System.Drawing.Color.Red;
            this.toMax.Location = new System.Drawing.Point(25, 380);
            this.toMax.Name = "toMax";
            this.toMax.Size = new System.Drawing.Size(106, 24);
            this.toMax.TabIndex = 2;
            this.toMax.Text = "最高気温";
            // 
            // tomoMin
            // 
            this.tomoMin.AutoSize = true;
            this.tomoMin.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tomoMin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tomoMin.Location = new System.Drawing.Point(304, 285);
            this.tomoMin.Name = "tomoMin";
            this.tomoMin.Size = new System.Drawing.Size(106, 24);
            this.tomoMin.TabIndex = 2;
            this.tomoMin.Text = "最低気温";
            // 
            // tomoMax
            // 
            this.tomoMax.AutoSize = true;
            this.tomoMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tomoMax.ForeColor = System.Drawing.Color.Red;
            this.tomoMax.Location = new System.Drawing.Point(304, 380);
            this.tomoMax.Name = "tomoMax";
            this.tomoMax.Size = new System.Drawing.Size(106, 24);
            this.tomoMax.TabIndex = 2;
            this.tomoMax.Text = "最高気温";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(25, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "今日の天気";
            // 
            // tomo2Min
            // 
            this.tomo2Min.AutoSize = true;
            this.tomo2Min.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tomo2Min.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tomo2Min.Location = new System.Drawing.Point(589, 285);
            this.tomo2Min.Name = "tomo2Min";
            this.tomo2Min.Size = new System.Drawing.Size(106, 24);
            this.tomo2Min.TabIndex = 2;
            this.tomo2Min.Text = "最低気温";
            // 
            // tomo2Max
            // 
            this.tomo2Max.AutoSize = true;
            this.tomo2Max.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tomo2Max.ForeColor = System.Drawing.Color.Red;
            this.tomo2Max.Location = new System.Drawing.Point(589, 380);
            this.tomo2Max.Name = "tomo2Max";
            this.tomo2Max.Size = new System.Drawing.Size(106, 24);
            this.tomo2Max.TabIndex = 2;
            this.tomo2Max.Text = "最高気温";
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(302, 188);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(117, 56);
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(593, 184);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(116, 56);
            this.pb3.TabIndex = 4;
            this.pb3.TabStop = false;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb1.Location = new System.Drawing.Point(29, 432);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(64, 33);
            this.lb1.TabIndex = 5;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb2.Location = new System.Drawing.Point(302, 336);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(66, 33);
            this.lb2.TabIndex = 6;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb3.Location = new System.Drawing.Point(302, 432);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(66, 33);
            this.lb3.TabIndex = 7;
            this.lb3.Text = "\r\n";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb4
            // 
            this.lb4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb4.Location = new System.Drawing.Point(593, 336);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(61, 33);
            this.lb4.TabIndex = 8;
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb5
            // 
            this.lb5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb5.Location = new System.Drawing.Point(593, 432);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(61, 33);
            this.lb5.TabIndex = 9;
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmDOmax
            // 
            this.tmDOmax.AutoSize = true;
            this.tmDOmax.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tmDOmax.ForeColor = System.Drawing.Color.Red;
            this.tmDOmax.Location = new System.Drawing.Point(366, 404);
            this.tmDOmax.Name = "tmDOmax";
            this.tmDOmax.Size = new System.Drawing.Size(44, 71);
            this.tmDOmax.TabIndex = 7;
            this.tmDOmax.Text = "\r\n℃";
            this.tmDOmax.UseCompatibleTextRendering = true;
            // 
            // tm2DOmax
            // 
            this.tm2DOmax.AutoSize = true;
            this.tm2DOmax.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tm2DOmax.ForeColor = System.Drawing.Color.Red;
            this.tm2DOmax.Location = new System.Drawing.Point(651, 404);
            this.tm2DOmax.Name = "tm2DOmax";
            this.tm2DOmax.Size = new System.Drawing.Size(44, 71);
            this.tm2DOmax.TabIndex = 7;
            this.tm2DOmax.Text = "\r\n℃";
            this.tm2DOmax.UseCompatibleTextRendering = true;
            // 
            // tm2DOmin
            // 
            this.tm2DOmin.AutoSize = true;
            this.tm2DOmin.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tm2DOmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tm2DOmin.Location = new System.Drawing.Point(651, 309);
            this.tm2DOmin.Name = "tm2DOmin";
            this.tm2DOmin.Size = new System.Drawing.Size(44, 71);
            this.tm2DOmin.TabIndex = 7;
            this.tm2DOmin.Text = "\r\n℃";
            this.tm2DOmin.UseCompatibleTextRendering = true;
            // 
            // tmDOmin
            // 
            this.tmDOmin.AutoSize = true;
            this.tmDOmin.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tmDOmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tmDOmin.Location = new System.Drawing.Point(366, 309);
            this.tmDOmin.Name = "tmDOmin";
            this.tmDOmin.Size = new System.Drawing.Size(44, 71);
            this.tmDOmin.TabIndex = 7;
            this.tmDOmin.Text = "\r\n℃";
            this.tmDOmin.UseCompatibleTextRendering = true;
            // 
            // tDOmax
            // 
            this.tDOmax.AutoSize = true;
            this.tDOmax.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tDOmax.ForeColor = System.Drawing.Color.Red;
            this.tDOmax.Location = new System.Drawing.Point(88, 404);
            this.tDOmax.Name = "tDOmax";
            this.tDOmax.Size = new System.Drawing.Size(44, 71);
            this.tDOmax.TabIndex = 7;
            this.tDOmax.Text = "\r\n℃";
            this.tDOmax.UseCompatibleTextRendering = true;
            // 
            // toMin
            // 
            this.toMin.AutoSize = true;
            this.toMin.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toMin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toMin.Location = new System.Drawing.Point(26, 285);
            this.toMin.Name = "toMin";
            this.toMin.Size = new System.Drawing.Size(106, 24);
            this.toMin.TabIndex = 2;
            this.toMin.Text = "最低気温";
            // 
            // toDOmin
            // 
            this.toDOmin.AutoSize = true;
            this.toDOmin.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toDOmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toDOmin.Location = new System.Drawing.Point(88, 309);
            this.toDOmin.Name = "toDOmin";
            this.toDOmin.Size = new System.Drawing.Size(44, 71);
            this.toDOmin.TabIndex = 7;
            this.toDOmin.Text = "\r\n℃";
            this.toDOmin.UseCompatibleTextRendering = true;
            // 
            // lb0
            // 
            this.lb0.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb0.Location = new System.Drawing.Point(32, 336);
            this.lb0.Name = "lb0";
            this.lb0.Size = new System.Drawing.Size(61, 33);
            this.lb0.TabIndex = 7;
            this.lb0.Text = "\r\n";
            this.lb0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbdate.Location = new System.Drawing.Point(138, 86);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(90, 24);
            this.lbdate.TabIndex = 10;
            this.lbdate.Text = "     --   ";
            // 
            // lbtoday
            // 
            this.lbtoday.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbtoday.Location = new System.Drawing.Point(2, 247);
            this.lbtoday.Name = "lbtoday";
            this.lbtoday.Size = new System.Drawing.Size(169, 31);
            this.lbtoday.TabIndex = 10;
            this.lbtoday.Text = "     --   ";
            this.lbtoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtomo
            // 
            this.lbtomo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbtomo.Location = new System.Drawing.Point(271, 247);
            this.lbtomo.Name = "lbtomo";
            this.lbtomo.Size = new System.Drawing.Size(178, 31);
            this.lbtomo.TabIndex = 10;
            this.lbtomo.Text = "     --   ";
            this.lbtomo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtomo2
            // 
            this.lbtomo2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbtomo2.Location = new System.Drawing.Point(571, 247);
            this.lbtomo2.Name = "lbtomo2";
            this.lbtomo2.Size = new System.Drawing.Size(168, 31);
            this.lbtomo2.TabIndex = 10;
            this.lbtomo2.Text = "     --   ";
            this.lbtomo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(29, 188);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(117, 56);
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(774, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 486);
            this.label2.TabIndex = 11;
            this.label2.Text = "--";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(387, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 22);
            this.label8.TabIndex = 12;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 551);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtomo2);
            this.Controls.Add(this.lbtomo);
            this.Controls.Add(this.lbtoday);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.toDOmin);
            this.Controls.Add(this.tmDOmin);
            this.Controls.Add(this.tm2DOmin);
            this.Controls.Add(this.tm2DOmax);
            this.Controls.Add(this.tDOmax);
            this.Controls.Add(this.tmDOmax);
            this.Controls.Add(this.lb0);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tomo2Max);
            this.Controls.Add(this.tomoMax);
            this.Controls.Add(this.toMax);
            this.Controls.Add(this.tomo2Min);
            this.Controls.Add(this.toMin);
            this.Controls.Add(this.tomoMin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherGET);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "天気アプリ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.btWeatherGET_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btWeatherGET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label toMax;
        private System.Windows.Forms.Label tomoMin;
        private System.Windows.Forms.Label tomoMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tomo2Min;
        private System.Windows.Forms.Label tomo2Max;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label tmDOmax;
        private System.Windows.Forms.Label tm2DOmax;
        private System.Windows.Forms.Label tm2DOmin;
        private System.Windows.Forms.Label tmDOmin;
        private System.Windows.Forms.Label tDOmax;
        private System.Windows.Forms.Label toMin;
        private System.Windows.Forms.Label toDOmin;
        private System.Windows.Forms.Label lb0;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbtoday;
        private System.Windows.Forms.Label lbtomo;
        private System.Windows.Forms.Label lbtomo2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}

