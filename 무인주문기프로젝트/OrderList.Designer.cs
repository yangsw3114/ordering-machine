namespace 무인주문기프로젝트
{
    partial class OrderList
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
            this.주문번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.메뉴 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.수량 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.세트메뉴구성품 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.포장or매장식사 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.제작완료 = new System.Windows.Forms.Button();
            this.전체삭제 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.주문번호,
            this.메뉴,
            this.수량,
            this.세트메뉴구성품,
            this.포장or매장식사});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(801, 345);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 주문번호
            // 
            this.주문번호.Text = "주문번호";
            this.주문번호.Width = 75;
            // 
            // 메뉴
            // 
            this.메뉴.Text = "메뉴";
            this.메뉴.Width = 150;
            // 
            // 수량
            // 
            this.수량.Text = "수량";
            this.수량.Width = 75;
            // 
            // 세트메뉴구성품
            // 
            this.세트메뉴구성품.Text = "세트메뉴구성품";
            this.세트메뉴구성품.Width = 280;
            // 
            // 포장or매장식사
            // 
            this.포장or매장식사.Text = "포장or매장식사";
            this.포장or매장식사.Width = 115;
            // 
            // 제작완료
            // 
            this.제작완료.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.제작완료.Font = new System.Drawing.Font("한컴 소망 B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.제작완료.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.제작완료.Location = new System.Drawing.Point(177, 406);
            this.제작완료.Name = "제작완료";
            this.제작완료.Size = new System.Drawing.Size(212, 43);
            this.제작완료.TabIndex = 1;
            this.제작완료.Text = "제작완료";
            this.제작완료.UseVisualStyleBackColor = false;
            this.제작완료.Click += new System.EventHandler(this.제작완료_Click);
            // 
            // 전체삭제
            // 
            this.전체삭제.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.전체삭제.Font = new System.Drawing.Font("한컴 소망 B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.전체삭제.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.전체삭제.Location = new System.Drawing.Point(410, 406);
            this.전체삭제.Name = "전체삭제";
            this.전체삭제.Size = new System.Drawing.Size(212, 43);
            this.전체삭제.TabIndex = 2;
            this.전체삭제.Text = "전체삭제";
            this.전체삭제.UseVisualStyleBackColor = false;
            this.전체삭제.Click += new System.EventHandler(this.전체삭제_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 461);
            this.Controls.Add(this.전체삭제);
            this.Controls.Add(this.제작완료);
            this.Controls.Add(this.listView1);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 주문번호;
        private System.Windows.Forms.ColumnHeader 메뉴;
        private System.Windows.Forms.ColumnHeader 수량;
        private System.Windows.Forms.ColumnHeader 세트메뉴구성품;
        private System.Windows.Forms.Button 제작완료;
        private System.Windows.Forms.Button 전체삭제;
        private System.Windows.Forms.ColumnHeader 포장or매장식사;
    }
}