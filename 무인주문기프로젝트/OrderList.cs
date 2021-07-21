using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace 무인주문기프로젝트
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pay.mdb;Persist Security Info=False";
        private string StrSQL2 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=menu.mdb;Persist Security Info=False";
        private void ShowMenu() //현재 메뉴 리스트들을 보여준다, 상품번호를 저장한다
        {
            주문정보 Orderinfo2 = new 주문정보(); //주문정보 클래스의 객체 생성
            int i = 0;
            this.listView1.Items.Clear(); //리스트뷰 아이템 전체 삭제
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("Select * From Pay", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                this.listView1.Items.Add(Orderinfo2.주문목록()[i]); //주문정보클래스에서 받아온 아이템들을 myRead.Read()로 다 읽을때까지 추가한다
                i += 1;

            }
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            ShowMenu(); //주문목록 창이 로드될때 리스트뷰를 업데이트한다.
        }

        private void 전체삭제_Click(object sender, EventArgs e) //전체삭제 버튼
        {
            DialogResult result = MessageBox.Show("삭제하시겠습니까?", "Pay", MessageBoxButtons.YesNo,
MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                listView1.Items.Clear(); //리스트뷰의 아이템들 삭제
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                string Sql = "Delete from Pay"; //pay.mdb 내용들도 다 삭제
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();
            }
        }

        public string StrMenu;
        public string StrCount;
        private void 제작완료_Click(object sender, EventArgs e) //제작완료 버튼
        {
            var Conn = new OleDbConnection(StrSQL); //pay데이터베이스에서 선택된 메뉴 삭제
            Conn.Open();
            foreach (ListViewItem item in listView1.SelectedItems)
            {

                    string Sql = "Delete from Pay where waitingNum='" + this.listView1.SelectedItems[0].SubItems[0].Text + "' and db_menu='" + this.listView1.SelectedItems[0].SubItems[1].Text + "' and db_count='" + this.listView1.SelectedItems[0].SubItems[2].Text + "' and db_sidemenu='" + this.listView1.SelectedItems[0].SubItems[3].Text + "' and 포장or매장='" + this.listView1.SelectedItems[0].SubItems[4].Text + "'";
                    var Comm = new OleDbCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();
            }
            Conn.Close();

            var Conn2 = new OleDbConnection(StrSQL2); //menu DB에서 선택한 메뉴의 이름과 재고량 불러와서 StrMenu, StrCount에 저장
            Conn2.Open();
            var Comm2 = new OleDbCommand("Select * From Menu", Conn2);
            var myRead = Comm2.ExecuteReader();
            while (myRead.Read())
            {
                var strM = myRead["db_menu"].ToString();
                var strC = myRead["db_count"].ToString();
                if (this.listView1.SelectedItems[0].SubItems[1].Text == strM)
                {
                    StrMenu = strM;
                    StrCount = strC;
                }
            }
            Conn2.Close();

            String MinusCount = (int.Parse(StrCount) - int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text)).ToString();

            var Conn3 = new OleDbConnection(StrSQL2); //판매된 수량(StrCount)만큼 재고량 수정
            Conn3.Open();
            string Sql2 = "update menu set db_menu='" + StrMenu + "', db_count='" + MinusCount + "'"; //재고량에서 판매된 수량을 빼고 저장한다
            Sql2 += "where db_menu='" + StrMenu + "' and db_count='" + StrCount + "'";
            var Comm3 = new OleDbCommand(Sql2, Conn3);
            int j = Comm3.ExecuteNonQuery();
            Conn3.Close();

            ShowMenu(); //리스트뷰 업데이트
        }
    }
}
