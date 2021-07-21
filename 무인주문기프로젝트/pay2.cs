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
    public partial class pay2 : Form
    {
        버거킹 Buger;
        public pay2(버거킹 buger)
        {
            InitializeComponent();
            Buger = buger;
        }

        private void pay2_Load(object sender, EventArgs e)
        {
            Num.Text = 버거킹.대기번호.ToString(); //대기번호 출력
        }

        private void OK_Click(object sender, EventArgs e) //확인 버튼
        {
            Buger.listView1.Items.Clear(); //대기번호 확인시 메인창의 리스트뷰를 clear한다.
            버거킹.대기번호 = (int.Parse(버거킹.대기번호) + 1).ToString(); //대기번호에 +1을 해준다.
            Close();
        }
    }
}
