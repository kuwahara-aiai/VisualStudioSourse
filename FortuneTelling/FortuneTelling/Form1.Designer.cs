namespace FortuneTelling
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.kuji = new System.Windows.Forms.TextBox();
            this.telling = new System.Windows.Forms.Label();
            this.fortune = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kuji
            // 
            this.kuji.Location = new System.Drawing.Point(41, 40);
            this.kuji.Name = "kuji";
            this.kuji.ReadOnly = true;
            this.kuji.Size = new System.Drawing.Size(142, 19);
            this.kuji.TabIndex = 0;
            this.kuji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telling
            // 
            this.telling.AutoSize = true;
            this.telling.Location = new System.Drawing.Point(39, 75);
            this.telling.Name = "telling";
            this.telling.Size = new System.Drawing.Size(0, 12);
            this.telling.TabIndex = 1;
            // 
            // fortune
            // 
            this.fortune.Location = new System.Drawing.Point(44, 131);
            this.fortune.Name = "fortune";
            this.fortune.Size = new System.Drawing.Size(142, 23);
            this.fortune.TabIndex = 2;
            this.fortune.Text = "おみくじを引く";
            this.fortune.UseVisualStyleBackColor = true;
            this.fortune.Click += new System.EventHandler(this.fortune_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(42, 75);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 12);
            this.label.TabIndex = 3;
            this.label.Text = "なにが出るかな？";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.label);
            this.Controls.Add(this.fortune);
            this.Controls.Add(this.telling);
            this.Controls.Add(this.kuji);
            this.Name = "Form1";
            this.Text = "おみくじ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kuji;
        private System.Windows.Forms.Label telling;
        private System.Windows.Forms.Button fortune;
        private System.Windows.Forms.Label label;
    }
}

