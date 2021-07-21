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
    public partial class 회원탈퇴 : Form
    {
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=member.mdb;Persist Security Info=False";
        public 회원탈퇴()
        {
            InitializeComponent();
        }
        private string name, id, pw,tel;
        private void MyInfo()
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("Select * From member", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strId = myRead["M_ID"].ToString();
                var strName = myRead["M_Name"].ToString();
                var strTel = myRead["M_Tel"].ToString();
                if (Form1.loginedID == strId)  //아이디가 일치할시 나의 정보(아이디, 이름, 전화번호)를 보여준다.
                {
                    아이디label.Text = strId;
                    이름label.Text = strName;
                    전화번호label.Text = strTel;
                    break;
                }
            }
            myRead.Close();
            Conn.Close();
        }

        private void 닫기_Click(object sender, EventArgs e) //닫기 버튼
        {
            Hide();
            admin ad = new admin(); //관리자 창으로 간다.
            ad.ShowDialog();
            Close();
        }

        private void 회원탈퇴_Load(object sender, EventArgs e)
        {
            MyInfo(); // 비밀번호를 제외한 나의 정보를 보여준다.
        }

        private void 탈_Click(object sender, EventArgs e) //회원탈퇴 버튼
        {
            int check = 0; //비밀번호 일치시 값이 1로 설정

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            DialogResult result = MessageBox.Show(Form1.loginedID + "의 계정을 탈퇴하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                var Comm = new OleDbCommand("Select * From member", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read())
                {
                    var strId = myRead["M_ID"].ToString();
                    var strPw = myRead["M_Password"].ToString();
                    var strName = myRead["M_Name"].ToString();
                    var strTel = myRead["M_Tel"].ToString();
                    if (Form1.loginedID == strId)
                    {
                        if (PW입력.Text == strPw) //비밀번호 일치시 모든 정보를 따로 선언해둔 변수에 저장
                        {
                            check = 1;

                            name = strName;
                            id = strId;
                            pw = strPw;
                            tel = strTel;
                        }
                        else {
                            check = 0;
                        }
                    }
                }
                myRead.Close();
                //Conn.Close();

                if (check == 1) //비밀번호 일치
                {
                    string Sql = "Delete from member where M_Name='" + name + "' and M_ID='" + id +
    "' and M_Password='" + pw + "' and M_Tel='" + tel + "'"; // 탈퇴하고자 하는 계정의 정보들을 다 삭제한다.
                    var Comm2 = new OleDbCommand(Sql, Conn);
                    int i = Comm2.ExecuteNonQuery();
                    Conn.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("탈퇴가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Hide();
                        Form1 F = new Form1();
                        F.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("삭제되지 않았습니다.다시 시도해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("비밀번호가 일치하지않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                }

        }
    }
}
