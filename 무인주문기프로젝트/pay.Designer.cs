namespace 무인주문기프로젝트
{
    partial class pay
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.메뉴 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.수량 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.매장식사 = new System.Windows.Forms.Button();
            this.포장 = new System.Windows.Forms.Button();
            this.totalnum = new System.Windows.Forms.Label();
            this.totalsum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.메뉴,
            this.수량,
            this.가격});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 98);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 305);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 메뉴
            // 
            this.메뉴.Text = "메뉴";
            this.메뉴.Width = 250;
            // 
            // 수량
            // 
            this.수량.Text = "수량";
            this.수량.Width = 133;
            // 
            // 가격
            // 
            this.가격.Text = "가격";
            this.가격.Width = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(85, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문목록 확인후, 매장식사 또는 포장을 선택해주세요";
            // 
            // 매장식사
            // 
            this.매장식사.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.매장식사.Font = new System.Drawing.Font("양재블럭체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매장식사.Location = new System.Drawing.Point(138, 459);
            this.매장식사.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.매장식사.Name = "매장식사";
            this.매장식사.Size = new System.Drawing.Size(143, 56);
            this.매장식사.TabIndex = 2;
            this.매장식사.Text = "매장식사";
            this.매장식사.UseVisualStyleBackColor = false;
            this.매장식사.Click += new System.EventHandler(this.매장식사_Click);
            // 
            // 포장
            // 
            this.포장.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.포장.Font = new System.Drawing.Font("양재블럭체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.포장.Location = new System.Drawing.Point(287, 459);
            this.포장.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.포장.Name = "포장";
            this.포장.Size = new System.Drawing.Size(151, 56);
            this.포장.TabIndex = 3;
            this.포장.Text = "포장";
            this.포장.UseVisualStyleBackColor = false;
            this.포장.Click += new System.EventHandler(this.포장_Click);
            // 
            // totalnum
            // 
            this.totalnum.AutoSize = true;
            this.totalnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalnum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalnum.Location = new System.Drawing.Point(11, 416);
            this.totalnum.Name = "totalnum";
            this.totalnum.Size = new System.Drawing.Size(48, 17);
            this.totalnum.TabIndex = 4;
            this.totalnum.Text = "총 수량";
            // 
            // totalsum
            // 
            this.totalsum.AutoSize = true;
            this.totalsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalsum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalsum.Location = new System.Drawing.Point(277, 415);
            this.totalsum.Name = "totalsum";
            this.totalsum.Size = new System.Drawing.Size(72, 17);
            this.totalsum.TabIndex = 5;
            this.totalsum.Text = "총 결제금액";
            // 
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(571, 526);
            this.Controls.Add(this.totalsum);
            this.Controls.Add(this.totalnum);
            this.Controls.Add(this.포장);
            this.Controls.Add(this.매장식사);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pay";
            this.Text = "pay";
            this.Load += new System.EventHandler(this.pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader 메뉴;
        private System.Windows.Forms.ColumnHeader 수량;
        private System.Windows.Forms.ColumnHeader 가격;
        private System.Windows.Forms.Button 매장식사;
        private System.Windows.Forms.Button 포장;
        private System.Windows.Forms.Label totalnum;
        private System.Windows.Forms.Label totalsum;
    }
}