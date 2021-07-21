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
    public partial class product_control : Form 
    {
        public product_control()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=menu.mdb;Persist Security Info=False";
        private string selectMenu, selectPrice, selectCount; //리스트뷰의 아이템 선택시 값들을 저장하기 위해 선언
        private int db_ID = 0; 
        public static int counnt;
        private void ShowMenu() //현재 메뉴 리스트들을 보여준다, 상품번호를 저장한다
        {
            counnt = 0; // 메뉴정보 클래스에서의 List<listviewItem>의 인덱스를 0으로 초기화하기 위함이다.
            메뉴정보 menuinfo = new 메뉴정보(); //메뉴정보 클래스 객체 생성
            
            this.listView1.Items.Clear();
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("Select * From menu", Conn); 
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strId = myRead["ID"].ToString(); // ID의 번호를 저장한다 (상품번호저장)
                db_ID = int.Parse(strId); // ID의 번호를 저장한다 (상품번호저장)

                this.listView1.Items.Add(menuinfo.메뉴보기()[counnt]); //메뉴의 아이템들을 메뉴정보클래스에서 가져와서 추가한다.
                counnt += 1;
            }
            Conn.Close();
        }

        private bool add_checktxt() //메뉴추가시 입력이 되었는지 확인
        {
            if (this.txtMname.Text == "") //메뉴 이름이 공백일 때
            {
                MessageBox.Show("메뉴이름을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMname.Focus();
                return false;
            }
            else if (this.txtMprice.Text == "") // 가격이 공백일 때
            {
                MessageBox.Show("메뉴가격을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMprice.Focus();
                return false;
            }
            else if (this.txtMcount.Text == "") // 가격이 공백일 때
            {
                MessageBox.Show("재고량을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMcount.Focus();
                return false;
            }
            else //어느 텍스트상자도 공백이 아닐 때
            {
                return true; 
            }
        }
        private bool Overlap() //메뉴이름 중복확인 함수
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("Select * From Menu", Conn);
            var myRead = Comm.ExecuteReader();
            int namecheck = 0; //namecheck가 0이면 사용 가능한 메뉴이름이고 1이면 이미 존재하는 메뉴이름이다.
            while (myRead.Read())
            {
                var strMname = myRead["db_menu"].ToString();
                if (txtMname.Text == strMname) //입력한 메뉴이름과 DB에 존재하는 메뉴이름가 같으면
                {
                    namecheck = 1; //namecheck에 1을 대입함으로써 사용중인 메뉴이름임을 뜻한다.
                }

            }
            myRead.Close();
            Conn.Close();

            if (namecheck == 1) //사용중인 메뉴이름이면
            {
                MessageBox.Show("메뉴이름이 중복됩니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMname.Focus();
                return false;
            }
            else
            {
                return true; 
            }
        }

        private void product_control_Load(object sender, EventArgs e)
        {
            counnt =0;
            ShowMenu();
        }

        private void listView1_Click(object sender, EventArgs e) //리스트뷰의 아이템들을 선택시
        {
            selectMenu = this.listView1.SelectedItems[0].SubItems[0].Text; //각각 변수에 저장된다.
            selectPrice = this.listView1.SelectedItems[0].SubItems[1].Text;
            selectCount = this.listView1.SelectedItems[0].SubItems[2].Text;

            txtMname.Text = selectMenu;  //메뉴수정할경우 리스트뷰의 아이템 선택시 텍스트들이 표시되어 수정하기 편하게 하기위함이다
            txtMprice.Text = selectPrice;
            txtMcount.Text = selectCount;
        }

        private void delete_Click(object sender, EventArgs e) //삭제 버튼
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            foreach (ListViewItem item in listView1.SelectedItems) //선택된 아이템을 찾는다
            {
                DialogResult result = MessageBox.Show(selectMenu + "을 메뉴에서 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    string Sql = "Delete from menu where db_menu='" + selectMenu + "' and db_price='" + selectPrice + "' and db_count='" + selectCount + "'"; // 선택된 메뉴 삭제
                    var Comm = new OleDbCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("정상적으로 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowMenu();
                        txtMname.Text = ""; //삭제완료시 텍스트를 빈칸으로 만들어준다
                        txtMprice.Text = "";
                        txtMcount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("삭제되지 않았습니다.다시 시도해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e) //뒤로 가기 버튼
        {
            Hide();
            admin Admin = new admin(); //관리자 창으로 간다.
            Admin.ShowDialog();
            Close();
        }

        private void add_Click(object sender, EventArgs e) //추가 버튼
        {
            if(add_checktxt() == true) //모든 텍스트들이 입력되었으면
            {
                if(Overlap() == true) //중복되는 메뉴이름이 없을때
                {

                    db_ID += 1;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    string Sql = "insert into menu (ID,db_menu,db_price,db_count) values ('" + db_ID+ "','" + this.txtMname.Text + "','" + this.txtMprice.Text + "','" + this.txtMcount.Text +"')";
                    //메뉴 정보들을 추가한다.
                    var Comm = new OleDbCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("메뉴가 추가되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowMenu();
                        txtMname.Text = ""; 
                        txtMprice.Text = "";
                        txtMcount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("메뉴 추가에 실패하였습니다. 다시시도해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void fix_Click(object sender, EventArgs e) //수정버튼
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            string Sql = "update menu set db_menu='" + this.txtMname.Text + "', db_price='" + this.txtMprice.Text + "', db_count='" + this.txtMcount.Text + "'";
            Sql += "where db_menu='" + selectMenu +"' and db_price='" + selectPrice + "' and db_count='" + selectCount + "'"; //선택된 아이템의 정보들을 입력된 값으로 변경
            var Comm = new OleDbCommand(Sql, Conn);
            int i = Comm.ExecuteNonQuery();
            Conn.Close();
            if (i == 1)
            {
                MessageBox.Show("정보가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowMenu();
                txtMname.Text = "";
                txtMprice.Text = "";
                txtMcount.Text = "";
            }
            else
                MessageBox.Show("정보가 수정되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
