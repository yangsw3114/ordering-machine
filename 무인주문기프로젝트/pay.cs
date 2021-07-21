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
    public partial class pay : Form
    {
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pay.mdb;Persist Security Info=False";
        private int Allcount = 0; //총수량 값 저장
        private int Allprice = 0; // 총 가격 값 저장
        버거킹 Buger;
        public pay(버거킹 buger)
        {
            InitializeComponent();
            Buger = buger; //주문완료했을때 버거킹의 메인창의 리스트뷰를 clear하기 위해 버거킹의 객체를 가져온다.
        }
        private void Showfood() //주문목록을 보여준다.
        {
            this.listView1.Items.Clear();
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("Select * From Pay", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strC = myRead["db_count"];
                var strP = myRead["db_price"];
                var strNum = myRead["waitingNum"].ToString();
                
                if (strNum == 버거킹.대기번호) { //일치하는 대기번호의 주문목록들을 리스트뷰에서 보여준다.
                    Allcount += int.Parse(strC.ToString()); //주문 수량 저장
                    Allprice += int.Parse(strC.ToString()) * int.Parse(strP.ToString()); //주문 가격 저장
                    var strArray = new String[] { myRead["db_menu"].ToString(), myRead["db_count"].ToString(), myRead["db_price"].ToString() };
                    var LV = new ListViewItem(strArray);
                    this.listView1.Items.Add(LV);
                }

            }
        }
        private void pay_Load(object sender, EventArgs e)
        {
            Showfood(); //주문목록을 보여준다
            totalnum.Text = "총수량 : " + Allcount; //총수량의 레이블을 수정한다.
            totalsum.Text = "총 결제금액 : " + Allprice; //총가격의 레이블을 수정한다.

        }

        private void 매장식사_Click(object sender, EventArgs e) //매장식사 버튼
        {
                DialogResult result = MessageBox.Show("결제하시겠습니까?", "Pay", MessageBoxButtons.YesNo,
    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                string Sql = "update pay set 포장or매장='" + "매장식사" + "'"; //pay.mdb에 매장식사를 저장한다.
                Sql += "where 포장or매장='" + "선택중.." + "'"; 
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();

                Hide();
                pay2 pay22 = new pay2(Buger); //대기번호 창으로 이동
                pay22.ShowDialog();
                Close();
                
            }
        }

        private void 포장_Click(object sender, EventArgs e) //포장 버튼
        {
            DialogResult result = MessageBox.Show("결제하시겠습니까?", "Pay", MessageBoxButtons.YesNo,
MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                string Sql = "update pay set 포장or매장='" + "포장" + "'"; //pay.mdb에 포장을 저장한다.
                Sql += "where 포장or매장='" + "선택중.." + "'";
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();

                Hide();
                pay2 pay22 = new pay2(Buger); //대기번호로 이동
                pay22.ShowDialog();
                Close();

            }
        }
    }
}
