namespace 무인주문기프로젝트
{
    partial class PWchange
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
            this.currentPW = new System.Windows.Forms.Label();
            this.changePW = new System.Windows.Forms.Label();
            this.showID = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.changebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentPW
            // 
            this.currentPW.AutoSize = true;
            this.currentPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentPW.Location = new System.Drawing.Point(13, 70);
            this.currentPW.Name = "currentPW";
            this.currentPW.Size = new System.Drawing.Size(82, 15);
            this.currentPW.TabIndex = 1;
            this.currentPW.Text = "현재 비밀번호";
            // 
            // changePW
            // 
            this.changePW.AutoSize = true;
            this.changePW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changePW.Location = new System.Drawing.Point(14, 119);
            this.changePW.Name = "changePW";
            this.changePW.Size = new System.Drawing.Size(82, 15);
            this.changePW.TabIndex = 2;
            this.changePW.Text = "변경 비밀번호";
            // 
            // showID
            // 
            this.showID.AutoSize = true;
            this.showID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showID.Location = new System.Drawing.Point(10, 18);
            this.showID.Name = "showID";
            this.showID.Size = new System.Drawing.Size(47, 24);
            this.showID.TabIndex = 0;
            this.showID.Text = "\" \"님";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(16, 86);
            this.txtCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.PasswordChar = '*';
            this.txtCurrent.Size = new System.Drawing.Size(223, 21);
            this.txtCurrent.TabIndex = 3;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(17, 136);
            this.txtChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '*';
            this.txtChange.Size = new System.Drawing.Size(222, 21);
            this.txtChange.TabIndex = 4;
            // 
            // changebutton
            // 
            this.changebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changebutton.Font = new System.Drawing.Font("함초롬돋움", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changebutton.Location = new System.Drawing.Point(16, 180);
            this.changebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(222, 26);
            this.changebutton.TabIndex = 5;
            this.changebutton.Text = "변경하기";
            this.changebutton.UseVisualStyleBackColor = false;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // PWchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 215);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.changePW);
            this.Controls.Add(this.currentPW);
            this.Controls.Add(this.showID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PWchange";
            this.Text = "PWchange";
            this.Load += new System.EventHandler(this.PWchange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentPW;
        private System.Windows.Forms.Label changePW;
        private System.Windows.Forms.Label showID;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button changebutton;
    }
}