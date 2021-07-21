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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string loginedID; //로그인후에 비밀번호변경, 정보 등에 연동시키기 위해 static으로 선언
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=member.mdb; Persist Security Info=False"; //member.mdb
        private string StrSQL2 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pay.mdb; Persist Security Info=False"; //pay.mdb
        private void login_Click(object sender, EventArgs e) //로그인버튼
        {
            int idcheck = 0; //아이디가 맞을경우 값을 1로 설정
            if (txtid.Text == "") //아이디 텍스트창이 비었을떄
            {
                MessageBox.Show("아이디를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid.Focus();
            }
            else if (txtpass.Text == "") //비밀번호 텍스트창이 비었을떄
            {
                MessageBox.Show("비밀번호를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Focus();
            }
            else
            {
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From Member", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read())
                {
                    var strId = myRead["M_ID"].ToString();
                    var strPw = myRead["M_Password"].ToString();
                    var strName = myRead["M_Name"].ToString();
                    var strTel = myRead["M_Tel"].ToString();

                    if (this.txtid.Text == strId) //DB에 저장되어 있는 아이디와 입력한 아이디가 같을경우(중복되는 아이디는 없다)
                    {
                        if (this.txtpass.Text == strPw) //DB에 저장되어 있는 비밀번호와 입력한 비밀번호가 같으면 checkid에 1을 대입한다.
                        {
                            loginedID = strId; //아이디를 static String loginedID에 저장
                            idcheck = 1;


                            var Conn2 = new OleDbConnection(StrSQL2); //pay DB 내용들 모두 삭제 (이전에 있던 주문목록들을 다삭제한다)
                            Conn2.Open();
                            string Sql = "Delete from Pay";
                            var Comm2 = new OleDbCommand(Sql, Conn2);
                            int i = Comm2.ExecuteNonQuery();
                            Conn2.Close();


                            Hide();
                            admin ad = new admin(); //관리자 창으로 들어간다
                            ad.ShowDialog();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 일치하지않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtpass.Focus();
                            idcheck = 1;
                        }
                    }
                }
                myRead.Close();
                Conn.Close();

                if(idcheck == 0) // idcheck 값이  0이므로 아이디가 일치하지않는다.
                {
                    MessageBox.Show("아이디가 일치하지않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtid.Focus();
                }
            }
        }

        private void join_Click(object sender, EventArgs e) //회원가입 버튼
        {
            join ji = new join();
            ji.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e) //비밀번호 찾기 버튼
        {
            PASSsearch PS = new PASSsearch();
            PS.ShowDialog();
        }
    }
}
