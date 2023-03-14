namespace RPSGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.myhand_label = new System.Windows.Forms.Label();
            this.pc_label = new System.Windows.Forms.Label();
            this.judge = new System.Windows.Forms.TextBox();
            this.MyHand = new System.Windows.Forms.PictureBox();
            this.PcHand = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcHand)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(566, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "じゃん！けん！　ぽん！！！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myhand_label
            // 
            this.myhand_label.AutoSize = true;
            this.myhand_label.Location = new System.Drawing.Point(162, 32);
            this.myhand_label.Name = "myhand_label";
            this.myhand_label.Size = new System.Drawing.Size(29, 12);
            this.myhand_label.TabIndex = 3;
            this.myhand_label.Text = "自分";
            this.myhand_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pc_label
            // 
            this.pc_label.AutoSize = true;
            this.pc_label.Location = new System.Drawing.Point(626, 32);
            this.pc_label.Name = "pc_label";
            this.pc_label.Size = new System.Drawing.Size(20, 12);
            this.pc_label.TabIndex = 4;
            this.pc_label.Text = "PC";
            this.pc_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // judge
            // 
            this.judge.Location = new System.Drawing.Point(375, 277);
            this.judge.Name = "judge";
            this.judge.Size = new System.Drawing.Size(100, 19);
            this.judge.TabIndex = 5;
            // 
            // MyHand
            // 
            this.MyHand.Location = new System.Drawing.Point(42, 72);
            this.MyHand.Name = "MyHand";
            this.MyHand.Size = new System.Drawing.Size(278, 254);
            this.MyHand.TabIndex = 8;
            this.MyHand.TabStop = false;
            this.MyHand.Click += new System.EventHandler(this.MyHund_Click);
            // 
            // PcHand
            // 
            this.PcHand.Location = new System.Drawing.Point(505, 72);
            this.PcHand.Name = "PcHand";
            this.PcHand.Size = new System.Drawing.Size(278, 254);
            this.PcHand.TabIndex = 9;
            this.PcHand.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.PcHand);
            this.Controls.Add(this.MyHand);
            this.Controls.Add(this.judge);
            this.Controls.Add(this.pc_label);
            this.Controls.Add(this.myhand_label);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label myhand_label;
        private System.Windows.Forms.Label pc_label;
        private System.Windows.Forms.TextBox judge;
        private System.Windows.Forms.PictureBox MyHand;
        private System.Windows.Forms.PictureBox PcHand;
    }
}

