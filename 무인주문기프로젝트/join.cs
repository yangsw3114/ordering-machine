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
    public partial class join : Form
    {
        public join()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=member.mdb; Persist Security Info=False";
        int checkOverlap = 0; //중복이 있는지 확인
        private void join_Load(object sender, EventArgs e)
        {

        }
        private bool Overlap() //아이디 중복확인을 찾는 함수
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            var Comm = new OleDbCommand("Select * From member", Conn);
            var myRead = Comm.ExecuteReader();
            int idcheck = 0; //idcheck가 0이면 사용 가능한 아이디이고 1이면 이미 존재하는 아이디이다.
            while (myRead.Read())
            {
                var strId = myRead["M_ID"].ToString();

                if (txtid.Text == strId) //입력한 아이디와 DB에 존재하는 아이디가 같으면
                {
                    idcheck = 1; //idcheck에 1을 대입함으로써 사용중인 아이디임을 뜻한다.
                }
            }
            myRead.Close(); Conn.Close();

            if (idcheck == 1) //사용중인 아이디이면
            {
                MessageBox.Show("이미 사용중인 아이디입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid.Focus();
                return false;
            }
            else 
            {
                return true; 
            }
        }
        private bool JoinCheck() //회원가입 조건 함수
        {
            if (this.txtid.Text == "") //아이디 입력이 공백일 때
            {
                MessageBox.Show("아이디를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtid.Focus();
                return false;
            }
            else if (this.txtpass.Text == "") // 비밀번호 입력이 공백일 때
            {
                MessageBox.Show("비밀번호를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtpass.Focus();
                return false;
            }
            else if (this.txtname.Text == "") //이름 입력이 공백일 때
            {
                MessageBox.Show("이름을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtname.Focus();
                return false;
            }
            else if (this.txtnum.Text == "") //전화번호 입력이 공백일 때
            {
                MessageBox.Show("전화번호를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtnum.Focus();
                return false;
            }
            else if(this.txtpass.Text != this.txtrepass.Text) //비밀번호와 비밀번호 확인이 일치하지않을 때
            {
                MessageBox.Show("비밀번호를 다시 확인해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtrepass.Focus();
                return false;
            }
            else //어느 텍스트상자도 공백이 아닐 때
            {
                if (this.txtpass.Text.Length < 4) //입력한 비밀번호의 길이가 4보다 작을 때
                {
                    MessageBox.Show("비밀번호는 최소 4자리 이상 입력해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true; //모든 조건을 만족할 때 true를 반환
            }
        }
        private void 가입_Click(object sender, EventArgs e) //가입하기 버튼
        {
            if(JoinCheck() == true) //회원조건 충족시
            {
                if (checkOverlap == 1) //중복된 아이디가 없을시
                {
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    string Sql = "insert into Member (M_ID,M_Password,M_Name,M_Tel) values ('" + this.txtid.Text + "','" + this.txtpass.Text + "','" + this.txtname.Text + "','" + this.txtnum.Text + "')";
                    //아이디, 비밀번호, 이름 전화번호를 member.mdb 에 넣는다.
                    var Comm = new OleDbCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("정상적으로 회원가입이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 회원가입이 되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("아이디 중복여부를 확인해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e) //중복확인 버튼
        {
            if (Overlap() == true)
            {
                MessageBox.Show("사용 가능한 아이디입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkOverlap = 1;
            }
        }
    }
}
