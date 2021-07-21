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
    public partial class SetMenu : Form
    {
        public String sideSelect, BeverageSelect; //사이드메뉴선택되었을때의 가격과 음료선택되었을때의 가격저장
        
        public SetMenu()
        {
            InitializeComponent();
        }
        public static int checkbutton = 0; //checkbutton 값이 1이어야 버거킹 메인창의 리스트뷰에 추가된다.(장바구니에 추가됨)
        public static string 사이드메뉴구성품; //사이드메뉴구성품을 저장한다.
        public static string 세트수정된가격; //사이드메뉴 선택후 변경된 가격을 저장한다.
        //public String DB_sidemenuList;
        private void SetMenu_Load(object sender, EventArgs e)
        {
            
            세트메뉴이름.Text = 버거킹.Setname; //클릭된 세트메뉴이름 설정
            주문금액.Text = "주문금액 : " + 버거킹.Setprice; // 세트메뉴 가격 설정

            string 버거단품이름 = 세트메뉴이름.Text.Replace("세트", ""); //ex) "몬스터와퍼세트" 중에 세트라는 단어를 뺀 "몬스터와퍼"만 저장
            버거구성품.Text = 버거단품이름 + "+" + "프렌치프라이" + "+" + "코카콜라";
        }

        private void PB1_Click(object sender, EventArgs e) //프렌치프라이
        {
            String 버거이름나누기 = 버거구성품.Text; 
            char dot = '+';
            string[] setBuger = 버거이름나누기.Split(dot); //버거 구성품을 '+'를 기준으로 나눈다
            버거구성품.Text = setBuger[0] + "+" + "프렌치프라이" + "+" + setBuger[2]; // 사이드메뉴의 내용만 변경
            int PricePlus = int.Parse(버거킹.Setprice);
            sideSelect = (PricePlus + 0).ToString(); //선택된 사이드메뉴의 추가가격을 더한다.
            주문금액.Text = "주문금액 : " + sideSelect; //주문금액 레이블 설정
        }

        //아래의 사이드메뉴 click이벤트도 위의 내용과 동일하다.
        private void PB2_Click(object sender, EventArgs e)  //어니언링
        {
            String 버거이름나누기 = 버거구성품.Text;
            char dot = '+';
            string[] setBuger = 버거이름나누기.Split(dot);
            버거구성품.Text = setBuger[0] + "+" + "어니언링" + "+" + setBuger[2];
            int PricePlus = int.Parse(버거킹.Setprice);
            sideSelect = (PricePlus + 300).ToString();
            주문금액.Text = "주문금액 : " + sideSelect;
        }
         
        private void PB3_Click(object sender, EventArgs e) //21치즈스틱
        {
            String 버거이름나누기 = 버거구성품.Text;
            char dot = '+';
            string[] setBuger = 버거이름나누기.Split(dot);
            버거구성품.Text = setBuger[0] + "+" + "21치즈스틱" + "+" + setBuger[2];
            int PricePlus = int.Parse(버거킹.Setprice);
            sideSelect = (PricePlus + 300).ToString();
            주문금액.Text = "주문금액 : " + sideSelect;
        }

        private void PB4_Click(object sender, EventArgs e) //크리미모찌볼
        {
            String 버거이름나누기 = 버거구성품.Text;
            char dot = '+';
            string[] setBuger = 버거이름나누기.Split(dot);
            버거구성품.Text = setBuger[0] + "+" + "크리미모찌볼" + "+" + setBuger[2];
            int PricePlus = int.Parse(버거킹.Setprice);
            sideSelect = (PricePlus + 500).ToString();
            주문금액.Text = "주문금액 : " + sideSelect;
        }

        private void PB5_Click(object sender, EventArgs e) //코카콜라
        {
            String 버거이름나누기 = 버거구성품.Text;
            char dot = '+';
            string[] setBuger = 버거이름나누기.Split(dot); //'+'를 기준으로 나눈다.
            버거구성품.Text = setBuger[0] + "+" + setBuger[1] + "+" + "코카콜라"; //음료메뉴의 내용만 수정한다.

            int PricePlus2 = int.Parse(sideSelect);
            BeverageSelect = (PricePlus2 + 0).ToString(); //선택된 음료메뉴의 추가가격을 더한다.
            주문금액.Text = "주문금액 : " + BeverageSelect; //가격레이블 수정
        }

        //아래의 음료메뉴 click이벤트도 위의 내용과 동일하다.
        private void PB6_Click(object sender, EventArgs e) //코카콜라제로
        {
            String 버거이름나누기 = 버거구성품.Text;
            char dot = '+';
            string[] setBuger = 버거이름나누기.Split(dot);
            버거구성품.Text = setBuger[0] + "+" + setBuger[1] + "+" + "코카콜라제로";

            int PricePlus2 = int.Parse(sideSelect);
            BeverageSelect = (PricePlus2 + 200).ToString();
            주문금액.Text = "주문금액 : " + BeverageSelect;
        }

        private void PB7_Click(object sender, EventArgs e) //스프라이트
        {
            String 버거이름나누기 = 버거구성품.Text;
            char dot = '+';
            string[] setBuger = 버거이름나누기.Split(dot);
            버거구성품.Text = setBuger[0] + "+" + setBuger[1] + "+" + "스프라이트";

            int PricePlus2 = int.Parse(sideSelect);
            BeverageSelect = (PricePlus2 + 0).ToString();
            주문금액.Text = "주문금액 : " + BeverageSelect;
        }

        private void PB8_Click(object sender, EventArgs e) //환타오렌지
        {
            String 버거이름나누기 = 버거구성품.Text;
            char dot = '+';
            string[] setBuger = 버거이름나누기.Split(dot);
            버거구성품.Text = setBuger[0] + "+" + setBuger[1] + "+" + "환타오렌지";
            int PricePlus2 = int.Parse(sideSelect);
            BeverageSelect = (PricePlus2 + 200).ToString();
            주문금액.Text = "주문금액 : " + BeverageSelect;
        }

        private void 주문담기_Click(object sender, EventArgs e) //주문담기 버튼
        {
            checkbutton = 1;  //값이 1로 설정되어 버거킹 주문창의 리스트뷰에 추가된다.
            사이드메뉴구성품 = 버거구성품.Text; //사이드메뉴, 음료메뉴 선택으로인해 수정된 사이드메뉴구성품을 수정한다.
            if (BeverageSelect == null) //사이드, 음료 아무것도 선택안하고 주문담기했을경우
            {
                세트수정된가격 = 버거킹.Setprice;
            }
            else {
                세트수정된가격 = BeverageSelect;
            }

            Close();

        }

        private void 취소_Click(object sender, EventArgs e) //취소 버튼
        {
            checkbutton = 0; //리스트뷰에 추가안됨
            Close();
        }


    }
}
