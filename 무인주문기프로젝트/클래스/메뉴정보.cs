using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace 무인주문기프로젝트
{
    class 메뉴정보 :메뉴정보얻기
    {
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=menu.mdb;Persist Security Info=False";
        public List<ListViewItem> 리스트뷰 = new List<ListViewItem>(); //리스트뷰 아이템들을 받기위해 생성
        public 메뉴정보() { }

        public override List<ListViewItem> 메뉴보기()
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("Select * From menu", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read()) { //menu.mdb로부터 데이터를 읽어온다
                ListViewItem menu = new ListViewItem(); //아이템
                ListViewItem.ListViewSubItem price = new ListViewItem.ListViewSubItem(); //서브아이템
                ListViewItem.ListViewSubItem count = new ListViewItem.ListViewSubItem(); //서브아이템
                메뉴 = myRead["db_menu"].ToString();  //프로퍼티 메뉴{get;}을 통해 메뉴정보를 받는다
                가격 = myRead["db_price"].ToString();
                수량 = myRead["db_count"].ToString();
                menu.Text = 메뉴;
                price.Text = 가격;
                count.Text = 수량;
                menu.SubItems.Add(price);
                menu.SubItems.Add(count);
                리스트뷰.Add(menu); //아이템들을 추가한다

            }
            Conn.Close();
            return 리스트뷰;
        }
    }
}
