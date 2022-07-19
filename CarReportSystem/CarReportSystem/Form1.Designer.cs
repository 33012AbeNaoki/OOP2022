
namespace CarReportSystem {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.cbReporterName = new System.Windows.Forms.ComboBox();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbOutsidecar = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.cbCarname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.btEnd = new System.Windows.Forms.Button();
            this.btReportinput = new System.Windows.Forms.Button();
            this.btReportcorrect = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btPicturedel = new System.Windows.Forms.Button();
            this.btPictureopen = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbColorSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColorSelect = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(26, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(80, 22);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(205, 19);
            this.dtDate.TabIndex = 1;
            // 
            // cbReporterName
            // 
            this.cbReporterName.FormattingEnabled = true;
            this.cbReporterName.Location = new System.Drawing.Point(80, 58);
            this.cbReporterName.Name = "cbReporterName";
            this.cbReporterName.Size = new System.Drawing.Size(248, 20);
            this.cbReporterName.TabIndex = 2;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(80, 97);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 3;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(133, 97);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 3;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(186, 97);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 3;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(243, 97);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 3;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbOutsidecar
            // 
            this.rbOutsidecar.AutoSize = true;
            this.rbOutsidecar.Location = new System.Drawing.Point(301, 97);
            this.rbOutsidecar.Name = "rbOutsidecar";
            this.rbOutsidecar.Size = new System.Drawing.Size(59, 16);
            this.rbOutsidecar.TabIndex = 3;
            this.rbOutsidecar.TabStop = true;
            this.rbOutsidecar.Text = "外国車";
            this.rbOutsidecar.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(366, 97);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 3;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // cbCarname
            // 
            this.cbCarname.FormattingEnabled = true;
            this.cbCarname.Location = new System.Drawing.Point(80, 128);
            this.cbCarname.Name = "cbCarname";
            this.cbCarname.Size = new System.Drawing.Size(248, 20);
            this.cbCarname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(8, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox.Location = new System.Drawing.Point(455, 42);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(252, 238);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(432, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // dgvArticle
            // 
            this.dgvArticle.AllowUserToAddRows = false;
            this.dgvArticle.AllowUserToDeleteRows = false;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Location = new System.Drawing.Point(80, 310);
            this.dgvArticle.MultiSelect = false;
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.ReadOnly = true;
            this.dgvArticle.RowTemplate.Height = 21;
            this.dgvArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticle.Size = new System.Drawing.Size(627, 177);
            this.dgvArticle.TabIndex = 5;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(80, 169);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(354, 135);
            this.tbReport.TabIndex = 6;
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(627, 493);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(80, 18);
            this.btEnd.TabIndex = 7;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btReportinput
            // 
            this.btReportinput.Location = new System.Drawing.Point(455, 286);
            this.btReportinput.Name = "btReportinput";
            this.btReportinput.Size = new System.Drawing.Size(80, 18);
            this.btReportinput.TabIndex = 7;
            this.btReportinput.Text = "追加";
            this.btReportinput.UseVisualStyleBackColor = true;
            this.btReportinput.Click += new System.EventHandler(this.btReportinput_Click);
            // 
            // btReportcorrect
            // 
            this.btReportcorrect.Location = new System.Drawing.Point(541, 286);
            this.btReportcorrect.Name = "btReportcorrect";
            this.btReportcorrect.Size = new System.Drawing.Size(80, 18);
            this.btReportcorrect.TabIndex = 7;
            this.btReportcorrect.Text = "修正";
            this.btReportcorrect.UseVisualStyleBackColor = true;
            this.btReportcorrect.Click += new System.EventHandler(this.btReportcorrect_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(627, 286);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(80, 18);
            this.btDel.TabIndex = 7;
            this.btDel.Text = "削除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btPicturedel
            // 
            this.btPicturedel.Location = new System.Drawing.Point(627, 17);
            this.btPicturedel.Name = "btPicturedel";
            this.btPicturedel.Size = new System.Drawing.Size(80, 18);
            this.btPicturedel.TabIndex = 7;
            this.btPicturedel.Text = "削除";
            this.btPicturedel.UseVisualStyleBackColor = true;
            this.btPicturedel.Click += new System.EventHandler(this.btPicturedel_Click);
            // 
            // btPictureopen
            // 
            this.btPictureopen.Location = new System.Drawing.Point(541, 17);
            this.btPictureopen.Name = "btPictureopen";
            this.btPictureopen.Size = new System.Drawing.Size(80, 18);
            this.btPictureopen.TabIndex = 7;
            this.btPictureopen.Text = "開く";
            this.btPictureopen.UseVisualStyleBackColor = true;
            this.btPictureopen.Click += new System.EventHandler(this.btPictureopen_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(6, 346);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(68, 18);
            this.btOpen.TabIndex = 7;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click_1);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(6, 370);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(68, 18);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.閉じるToolStripMenuItem,
            this.cbColorSelect});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ToolStripMenuItem.Text = "ファイル（F）";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.開くToolStripMenuItem.Text = "開く";
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.閉じるToolStripMenuItem.Text = "閉じる";
            // 
            // cbColorSelect
            // 
            this.cbColorSelect.Name = "cbColorSelect";
            this.cbColorSelect.Size = new System.Drawing.Size(110, 22);
            this.cbColorSelect.Text = "色設定";
            this.cbColorSelect.Click += new System.EventHandler(this.cbColorSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 523);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btPictureopen);
            this.Controls.Add(this.btPicturedel);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btReportcorrect);
            this.Controls.Add(this.btReportinput);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.dgvArticle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbOutsidecar);
            this.Controls.Add(this.rbSubaru);
            this.Controls.Add(this.rbHonda);
            this.Controls.Add(this.rbNissan);
            this.Controls.Add(this.rbToyota);
            this.Controls.Add(this.cbCarname);
            this.Controls.Add(this.cbReporterName);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CarReportSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.ComboBox cbReporterName;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbOutsidecar;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.ComboBox cbCarname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvArticle;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btReportinput;
        private System.Windows.Forms.Button btReportcorrect;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btPicturedel;
        private System.Windows.Forms.Button btPictureopen;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cbColorSelect;
        private System.Windows.Forms.ColorDialog cdColorSelect;
    }
}

