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
    public partial class PASSsearch : Form
    {
        public PASSsearch()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Member.mdb; Persist Security Info=False";

        private void PASSsearch_Load(object sender, EventArgs e)
        {

        }

        private void PW찾기_Click(object sender, EventArgs e) //비밀번호 확인 버튼
        {
            if (txtid.Text == "") //아이디가 공백일 때
            {
                MessageBox.Show("아이디를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid.Focus();
            }
            else if (txtname.Text == "") //이름이 공백일 때
            {
                MessageBox.Show("이름를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
            }
            else if (txtnum.Text == "") //전화번호가 공백일 때
            {
                MessageBox.Show("전화번호를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnum.Focus();
            }
            else
            {
                int PassCofirm = 0; //아이디, 이름, 번호 모두 일치할경우 값일 1로 설정
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From Member", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["M_ID"].ToString();
                    var strPw = myRead["M_Password"].ToString();
                    var strName = myRead["M_Name"].ToString();
                    var strTel = myRead["M_Tel"].ToString();

                    if (this.txtid.Text == strId && this.txtname.Text == strName && this.txtnum.Text == strTel)//아이디 이름 전화번호 일치할경우
                    {
                        PassCofirm = 1; 
                        passShow.Text = strName + "님의 비밀번호는" + strPw + "입니다.";
                    }
                }
                myRead.Close();
                Conn.Close();

                if(PassCofirm == 0) //아이디, 이름, 번호가 일치 못했을 경우
                {
                    MessageBox.Show("일치하는 비밀번호를 찾을수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
