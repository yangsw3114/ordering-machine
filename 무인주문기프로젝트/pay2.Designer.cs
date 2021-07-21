namespace 무인주문기프로젝트
{
    partial class pay2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ordernum = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordernum
            // 
            this.ordernum.AutoSize = true;
            this.ordernum.Font = new System.Drawing.Font("한컴 윤체 L", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordernum.ForeColor = System.Drawing.Color.Red;
            this.ordernum.Location = new System.Drawing.Point(8, 9);
            this.ordernum.Name = "ordernum";
            this.ordernum.Size = new System.Drawing.Size(341, 45);
            this.ordernum.TabIndex = 0;
            this.ordernum.Text = "주문번호 / ORDER NO.";
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Font = new System.Drawing.Font("한컴 윤체 M", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num.Location = new System.Drawing.Point(142, 107);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(62, 82);
            this.Num.TabIndex = 1;
            this.Num.Text = "1";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OK.Font = new System.Drawing.Font("한컴 윤체 L", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(115, 264);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(128, 43);
            this.OK.TabIndex = 2;
            this.OK.Text = "확인";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // pay2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 319);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.ordernum);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "pay2";
            this.Text = "pay2";
            this.Load += new System.EventHandler(this.pay2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ordernum;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Button OK;
    }
}