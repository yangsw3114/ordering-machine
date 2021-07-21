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
    public partial class PWchange : Form
    {
        public PWchange()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=member.mdb;Persist Security Info=False";
        private string PW;
        private string ID;
        private void PWchange_Load(object sender, EventArgs e)
        {
            showID.Text = Form1.loginedID+"님"; //로그인한 계정의 아이디를 텍스트에 설정
        }

        private void changebutton_Click(object sender, EventArgs e) //비밀번호 변경 버튼
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            var Comm = new OleDbCommand("Select * From member", Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                var strId = myRead["M_ID"].ToString();
                var strPw = myRead["M_Password"].ToString();
                if (Form1.loginedID == strId) //일치하는 아이디를 찾아서 ID와 PW에 저장한다.
                {
                    ID = strId; PW = strPw;
                }

            }
            myRead.Close();
            //Conn.Close();

            if (Form1.loginedID == ID) //아이디 일치할 때
            {
                if (PW == txtCurrent.Text) //현재 비밀번호와 일치할 때
                {

                    string Sql = "update member set M_Password='" + this.txtChange.Text + "'"; //변경하고자하는 비밀번호로 변경
                    Sql += "where M_Password='" + this.txtCurrent.Text + "'";
                    var Comm2 = new OleDbCommand(Sql, Conn);
                    int i = Comm2.ExecuteNonQuery();
                    Conn.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("비밀번호를 변경하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        MessageBox.Show("알수 없는 오류입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("현재 비밀번호가 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
