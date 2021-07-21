using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 무인주문기프로젝트
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void 영업시작_Click(object sender, EventArgs e) //영어시작버튼
        {
            Hide();
            버거킹 main = new 버거킹(); //현재 창을 끄고 판매창으로 이동한다
            main.ShowDialog();
            Close();
        }

        private void logout_Click(object sender, EventArgs e) //로그아웃 버튼
        {
            DialogResult result = MessageBox.Show("로그아웃 하시겠습니까?", "LogOut", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(result == DialogResult.Yes) //팝업창 YES 클릭시 로그인창으로 돌아간다
            {
                Hide();
                Form1 login = new Form1();
                login.ShowDialog();
                Close();
            }
        }

        private void 상품재고_Click(object sender, EventArgs e) //상품재고 버튼
        {
            product_control.counnt = 0;// 메뉴정보 클래스에서 List<listviewItem>의 인덱스를 0으로 초기화하기 위함이다.
            Hide();
            product_control p = new product_control(); //상품관리창으로 이동한다.
            p.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e) //회원탈퇴버튼
        {
            Hide();
            회원탈퇴 leave = new 회원탈퇴();
            leave.ShowDialog();
            Close();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void PassChange_Click(object sender, EventArgs e) //비밀번호변경 버튼
        {

            PWchange change = new PWchange();  
            change.ShowDialog();  //모달창으로 표시된다.

        }

        private void 주문목록_Click(object sender, EventArgs e) //주문목록 버튼
        {
            OrderList order = new OrderList();
            order.ShowDialog(); //모달창으로 표시된다.
        }
    }
}
