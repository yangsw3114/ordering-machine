using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace 무인주문기프로젝트
{
    interface Order //인터페이스
    {
        List<ListViewItem> 주문목록();
    }

    class 주문정보 : Order //인터페이스 상속
    {
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pay.mdb;Persist Security Info=False";
        public List<ListViewItem> 주문뷰 = new List<ListViewItem>(); //리스트뷰 아이템들을 받기위해 생성
        public 주문정보() { }

        
        public List<ListViewItem> 주문목록()
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("Select * From pay", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read()) //pay.mdb에서 데이터를 읽어온다
            {
                ListViewItem waitingNum = new ListViewItem();
                ListViewItem.ListViewSubItem menu = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem count = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem sidemenu = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem select_eat = new ListViewItem.ListViewSubItem();

                waitingNum.Text = myRead["waitingNum"].ToString();
                menu.Text = myRead["db_menu"].ToString();
                count.Text = myRead["db_count"].ToString();
                sidemenu.Text = myRead["db_sidemenu"].ToString();
                select_eat.Text = myRead["포장or매장"].ToString();

                waitingNum.SubItems.Add(menu);
                waitingNum.SubItems.Add(count);
                waitingNum.SubItems.Add(sidemenu);
                waitingNum.SubItems.Add(select_eat);
                주문뷰.Add(waitingNum);  //아이템들을 추가한다

            }
            Conn.Close();
            return 주문뷰;
        }
    }
}
