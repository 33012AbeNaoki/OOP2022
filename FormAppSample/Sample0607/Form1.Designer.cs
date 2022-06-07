
namespace Sample0607 {
    partial class 計算アプリ {
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
            this.button1 = new System.Windows.Forms.Button();
            this.udNum1 = new System.Windows.Forms.NumericUpDown();
            this.udNum2 = new System.Windows.Forms.NumericUpDown();
            this.udAns = new System.Windows.Forms.NumericUpDown();
            this.udMod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.udNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(183, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "÷";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(384, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "＝\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(565, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "あまり";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(317, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // udNum1
            // 
            this.udNum1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.udNum1.Location = new System.Drawing.Point(50, 34);
            this.udNum1.Name = "udNum1";
            this.udNum1.Size = new System.Drawing.Size(100, 44);
            this.udNum1.TabIndex = 3;
            // 
            // udNum2
            // 
            this.udNum2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.udNum2.Location = new System.Drawing.Point(260, 34);
            this.udNum2.Name = "udNum2";
            this.udNum2.Size = new System.Drawing.Size(100, 44);
            this.udNum2.TabIndex = 3;
            // 
            // udAns
            // 
            this.udAns.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.udAns.Location = new System.Drawing.Point(459, 36);
            this.udAns.Name = "udAns";
            this.udAns.Size = new System.Drawing.Size(100, 44);
            this.udAns.TabIndex = 3;
            // 
            // udMod
            // 
            this.udMod.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.udMod.Location = new System.Drawing.Point(669, 38);
            this.udMod.Name = "udMod";
            this.udMod.Size = new System.Drawing.Size(100, 44);
            this.udMod.TabIndex = 3;
            // 
            // 計算アプリ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 217);
            this.Controls.Add(this.udMod);
            this.Controls.Add(this.udAns);
            this.Controls.Add(this.udNum2);
            this.Controls.Add(this.udNum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "計算アプリ";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.計算アプリ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown udNum1;
        private System.Windows.Forms.NumericUpDown udNum2;
        private System.Windows.Forms.NumericUpDown udAns;
        private System.Windows.Forms.NumericUpDown udMod;
    }
}

