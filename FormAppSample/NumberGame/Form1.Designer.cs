
namespace NumberGame {
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
            this.inNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // inNum
            // 
            this.inNum.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inNum.Location = new System.Drawing.Point(250, 98);
            this.inNum.Name = "inNum";
            this.inNum.Size = new System.Drawing.Size(98, 44);
            this.inNum.TabIndex = 0;
            this.inNum.Text = "判定";
            this.inNum.UseVisualStyleBackColor = true;
            this.inNum.Click += new System.EventHandler(this.inNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "1～             の中から好きな数字を入力";
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number.Location = new System.Drawing.Point(79, 104);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 34);
            this.number.TabIndex = 2;
            // 
            // tbRes
            // 
            this.tbRes.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRes.Location = new System.Drawing.Point(60, 171);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(301, 23);
            this.tbRes.TabIndex = 3;
            // 
            // maxNum
            // 
            this.maxNum.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxNum.Location = new System.Drawing.Point(49, 19);
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(120, 34);
            this.maxNum.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 206);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inNum);
            this.Name = "Form1";
            this.Text = "数当てゲーム";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.NumericUpDown maxNum;
    }
}

