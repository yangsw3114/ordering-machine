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
using System.IO;

namespace 무인주문기프로젝트
{
    public partial class 버거킹 : Form
    {

        public 버거킹()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=menu.mdb; Persist Security Info=False";
        private string StrSQL2 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=member.mdb; Persist Security Info=False";
        private string StrSQL3 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pay.mdb;Persist Security Info=False";
        private int[] Count = new int[300]; //상품들이 리스트뷰에 없으면 Count[i]= 0 이고, 리스트뷰에 있으면 0이 아닌숫자

        private string[] PictureName = new string[40]; //해당폴더에 있는 파일이름을 다 저장한다.
        private string[] PathPictureName = new string[32]; //출력할 사진들의 이름을 저장
        public static string Setname, Setprice; //setMenu클래스에 이름과 가격을 넘겨준다.
        public static string 대기번호= "1"; //실행시 대기번호 1로 설정, 결제완료시 1씩 증가한다.

        private void Alldelete() { //Pay.mdb내용들을 다 지운다
            var Conn = new OleDbConnection(StrSQL3);
            Conn.Open();
            string Sql = "Delete from Pay";
            var Comm = new OleDbCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();
        }

        private void tab1_Click(object sender, EventArgs e) // 세트 버튼, 클릭시 탭페이지1으로 이동
        {
            tabControl1.SelectedIndex = 0;
        }

        private void tab2_Click(object sender, EventArgs e) // 햄버거 버튼, 클릭시 탭페이지2으로 이동
        {
            tabControl1.SelectedIndex = 1;

            //menu.mdb에 있는 메뉴이름과 일치하는 사진들을 불러와서 picturebox에 로드한다.
            int i = 0;
            int j = 8;
            //폴더 경로를 입력
            string Path = "..\\..\\Resources\\버거";
            //해당 폴더가 존재하는지 확인
            if (System.IO.Directory.Exists(Path))
            {
                //DirectoryInfo 객체 생성
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);
                //해당 폴더에 있는 파일이름을 출력
                foreach (var item in di.GetFiles())
                {
                    PictureName[i] = item.Name;
                    i += 1;

                }
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();

                for (int k = 0; k < i; k++)
                { //사진파일에 저장된 사진갯수만큼 for문이 작동한다.
                    var Comm = new OleDbCommand("Select * From Menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read())
                    {
                        var strM = myRead["db_menu"].ToString();
                        string strname = strM + ".JPG";
                        
                            if (PictureName[k] == strname) //이름이 일치할경우 PathPictureName에 저장
                            {
                                PathPictureName[j] = strname;
                                j += 1;
                            }
                    }
                    myRead.Close();
                }

                Conn.Close();
            }
            PictureBox_buger_Load();
        }

        public void PictureBox_buger_Load()
        {

            if (PathPictureName[8] != null) //PathPictureName에 저장된 사진이름이 없을경우 로드되지 않도록 했다.
            {
                pictureBox9.Load(@"..\..\Resources\버거\" + PathPictureName[8]);
            }
            if (PathPictureName[9] != null)
            {
                pictureBox10.Load(@"..\..\Resources\버거\" + PathPictureName[9]);
            }
            if (PathPictureName[10] != null)
            {
                pictureBox11.Load(@"..\..\Resources\버거\" + PathPictureName[10]);
            }
            if (PathPictureName[11] != null)
            {
                pictureBox12.Load(@"..\..\Resources\버거\" + PathPictureName[11]);
            }
            if (PathPictureName[12] != null)
            {
                pictureBox13.Load(@"..\..\Resources\버거\" + PathPictureName[12]);
            }
            if (PathPictureName[13] != null)
            {
                pictureBox14.Load(@"..\..\Resources\버거\" + PathPictureName[13]);
            }
            if (PathPictureName[14] != null)
            {
                pictureBox15.Load(@"..\..\Resources\버거\" + PathPictureName[14]);
            }
            if (PathPictureName[15] != null)
            {
                pictureBox16.Load(@"..\..\Resources\버거\" + PathPictureName[15]);
            }
        }

        private void tab3_Click(object sender, EventArgs e) // 사이드 버튼, 클릭시 탭페이지3으로 이동
        {
            tabControl1.SelectedIndex = 2;

            //menu.mdb에 있는 메뉴이름과 일치하는 사진들을 불러와서 picturebox에 로드한다.
            int i = 0;
            int j = 16;
            //폴더 경로를 입력
            string Path = "..\\..\\Resources\\사이드";
            //해당 폴더가 존재하는지 확인
            if (System.IO.Directory.Exists(Path))
            {
                //DirectoryInfo 객체 생성
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);
                //해당 폴더에 있는 파일이름을 출력
                foreach (var item in di.GetFiles())
                {
                    PictureName[i] = item.Name;
                    i += 1;

                }
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();

                for (int k = 0; k < i; k++)
                { //사진파일에 저장된 사진갯수만큼 for문이 작동한다.
                    var Comm = new OleDbCommand("Select * From Menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read())
                    {
                        var strM = myRead["db_menu"].ToString();
                        string strname = strM + ".JPG";

                        if (PictureName[k] == strname)
                        {
                            PathPictureName[j] = strname;
                            j += 1;
                        }
                    }
                    myRead.Close();
                }

                Conn.Close();
            }
            PictureBox_side_Load();
        }

        public void PictureBox_side_Load()
        {

            if (PathPictureName[16] != null)
            {
                pictureBox17.Load(@"..\..\Resources\사이드\" + PathPictureName[16]);
            }
            if (PathPictureName[17] != null)
            {
                pictureBox18.Load(@"..\..\Resources\사이드\" + PathPictureName[17]);
            }
            if (PathPictureName[18] != null)
            {
                pictureBox19.Load(@"..\..\Resources\사이드\" + PathPictureName[18]);
            }
            if (PathPictureName[19] != null)
            {
                pictureBox20.Load(@"..\..\Resources\사이드\" + PathPictureName[19]);
            }
            if (PathPictureName[20] != null)
            {
                pictureBox21.Load(@"..\..\Resources\사이드\" + PathPictureName[20]);
            }
            if (PathPictureName[21] != null)
            {
                pictureBox22.Load(@"..\..\Resources\사이드\" + PathPictureName[21]);
            }
            if (PathPictureName[22] != null)
            {
                pictureBox23.Load(@"..\..\Resources\사이드\" + PathPictureName[22]);
            }
            if (PathPictureName[23] != null)
            {
                pictureBox24.Load(@"..\..\Resources\사이드\" + PathPictureName[23]);
            }
        }

        private void tab4_Click(object sender, EventArgs e) // 음료 버튼, 클릭시 탭페이지4으로 이동
        {
            tabControl1.SelectedIndex = 3;

            //menu.mdb에 있는 메뉴이름과 일치하는 사진들을 불러와서 picturebox에 로드한다.
            int i = 0;
            int j = 24;
            //폴더 경로를 입력
            string Path = "..\\..\\Resources\\음료디저트";
            //해당 폴더가 존재하는지 확인
            if (System.IO.Directory.Exists(Path))
            {
                //DirectoryInfo 객체 생성
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);
                //해당 폴더에 있는 파일이름을 출력
                foreach (var item in di.GetFiles())
                {
                    PictureName[i] = item.Name;
                    i += 1;

                }
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();

                for (int k = 0; k < i; k++)
                { //사진파일에 저장된 사진갯수만큼 for문이 작동한다.
                    var Comm = new OleDbCommand("Select * From Menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read())
                    {
                        var strM = myRead["db_menu"].ToString();
                        string strname = strM + ".JPG";

                        if (PictureName[k] == strname)
                        {
                            PathPictureName[j] = strname;
                            j += 1;
                        }
                    }
                    myRead.Close();
                }

                Conn.Close();
            }
            PictureBox_beverage_Load();
        }

        public void PictureBox_beverage_Load()
        {

            if (PathPictureName[24] != null)
            {
                pictureBox25.Load(@"..\..\Resources\음료디저트\" + PathPictureName[24]);
            }
            if (PathPictureName[25] != null)
            {
                pictureBox26.Load(@"..\..\Resources\음료디저트\" + PathPictureName[25]);
            }
            if (PathPictureName[26] != null)
            {
                pictureBox27.Load(@"..\..\Resources\음료디저트\" + PathPictureName[26]);
            }
            if (PathPictureName[27] != null)
            {
                pictureBox28.Load(@"..\..\Resources\음료디저트\" + PathPictureName[27]);
            }
            if (PathPictureName[28] != null)
            {
                pictureBox29.Load(@"..\..\Resources\음료디저트\" + PathPictureName[28]);
            }
            if (PathPictureName[29] != null)
            {
                pictureBox30.Load(@"..\..\Resources\음료디저트\" + PathPictureName[29]);
            }
            if (PathPictureName[30] != null)
            {
                pictureBox31.Load(@"..\..\Resources\음료디저트\" + PathPictureName[30]);
            }
            if (PathPictureName[31] != null)
            {
                pictureBox32.Load(@"..\..\Resources\음료디저트\" + PathPictureName[31]);
            }
        }

        private void go_admin_Click(object sender, EventArgs e) //back 버튼
        {
            string value = "";
            if (InputBox("비밀번호 입력", "비밀번호를 입력하세요", ref value) == DialogResult.OK) //비밀번호를 입력하는 팝업창이뜬다.
            {
                if(value != "")
                {
                    var Conn = new OleDbConnection(StrSQL2);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From member", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read())
                    {
                        var strId = myRead["M_ID"].ToString();
                        var strPw = myRead["M_Password"].ToString();
                        if (Form1.loginedID == strId)
                        {
                            if (value == strPw)  //아이디와 비밀번호가 일치할경우 관리자창으로 진입가능
                            {
                                Hide();
                                admin ad = new admin();
                                ad.ShowDialog();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("비밀번호가 일치하지않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    myRead.Close();
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("비밀번호를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            //손님들이 막건들지 못하게 비밀번호 입력창이 뜬후 비밀번호 일치할경우 관리자창 진입가능

        }

        private void button2_Click(object sender, EventArgs e) //선택삭제 버튼
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected) //선택된 아이템
                {
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        if (listView1.Items[i].SubItems[0].Text == strMenu)
                        {
                            Count[(int)strId] = 0; //선택된 메뉴의count를 0으로 초기화  0으로 초기화하여야 나중에 그 메뉴를 장바구니에 담았을때 제대로 실행된다.
                        }
                    }
                    listView1.Items.RemoveAt(i); //리스트뷰에서 선택된 아이템 삭제
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //전체삭제 버튼
        {
            listView1.Items.Clear(); //리스트뷰 모든 아이템 클리어
            for(int i=0; i<Count.Length; i++)
            {
                Count[i] = 0; // 모든 메뉴 Count[] = 0 으로 초기화
            }
        }

        public static DialogResult InputBox(string title, string content, ref string value) //로그아웃할때 비밀번호확인을 위한 input박스
        {
            Form form = new Form(); 
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.ClientSize = new Size(300, 100);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            form.Text = title;
            label.Text = content;
            textBox.Text = value;
            textBox.PasswordChar = '*';
            buttonOk.Text = "확인";
            buttonCancel.Text = "취소";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(65, 17, 200, 20);
            textBox.SetBounds(65, 40, 220, 20);
            buttonOk.SetBounds(135, 70, 70, 20);
            buttonCancel.SetBounds(215, 70, 70, 20);

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }


        private void 버거킹_Load(object sender, EventArgs e)
        {

            //menu.mdb에 있는 메뉴이름과 일치하는 사진들을 불러와서 picturebox에 로드한다.
            int i = 0;
            int j = 0;
            //폴더 경로를 입력
            string Path = "..\\..\\Resources";
            //해당 폴더가 존재하는지 확인
            if (System.IO.Directory.Exists(Path))
            {
                //DirectoryInfo 객체 생성
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);
                //해당 폴더에 있는 파일이름을 출력
                foreach (var item in di.GetFiles())
                {
                            PictureName[i] = item.Name; //폴더내의 모든 이미지 이름들을 배열에 저장
                            i += 1;

                }
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();

                for (int k = 0; k < i; k++) { //사진파일에 저장된 사진갯수만큼 for문이 작동한다.
                    var Comm = new OleDbCommand("Select * From Menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read())
                    {
                        var strM = myRead["db_menu"].ToString();
                        string strname = strM + ".JPG";
                        bool setMenuContain = strname.Contains("세트"); //세트 라는 명칭이 포함되어있으면 true 
                        if (setMenuContain == true) {
                            if (PictureName[k] == strname)
                            {
                                PathPictureName[j] = strname;
                                j += 1;
                            }
                        }
                    }
                    myRead.Close();
                }

                Conn.Close();
            }
            PictureBox_SetMenu_Load();
        }

        public void PictureBox_SetMenu_Load()
        {

            if (PathPictureName[0] != null) //저장된 이미지 이름이 없을경우 실행되지않는다.
            {
                pictureBox1.Load(@"..\..\Resources\" + PathPictureName[0]);
            }
            if (PathPictureName[1] != null)
            {
                pictureBox2.Load(@"..\..\Resources\" + PathPictureName[1]);
            } 
            if (PathPictureName[2] != null)
            {
                pictureBox3.Load(@"..\..\Resources\" + PathPictureName[2]);
            }
            if (PathPictureName[3] != null)
            {
                pictureBox4.Load(@"..\..\Resources\" + PathPictureName[3]);
            }
            if (PathPictureName[4] != null)
            {
                pictureBox5.Load(@"..\..\Resources\" + PathPictureName[4]);
            }
            if (PathPictureName[5] != null)
            {
                pictureBox6.Load(@"..\..\Resources\" + PathPictureName[5]);
            }
            if (PathPictureName[6] != null)
            {
                pictureBox7.Load(@"..\..\Resources\" + PathPictureName[6]);
            }
            if (PathPictureName[7] != null)
            {
                pictureBox8.Load(@"..\..\Resources\" + PathPictureName[7]);
            }
        }

        private void pay_Click(object sender, EventArgs e) //결제 버튼
        {
            var Conn = new OleDbConnection(StrSQL3); //pay.mdb
            Conn.Open();
            for (int j = 0; j < listView1.Items.Count; j++) { //리스트뷰 아이템 갯수만큼 주문목록을 pay에 추가한다.
                string Sql = "insert into Pay (db_menu,db_count,db_price,db_sidemenu,waitingNum,포장or매장) values ('" + listView1.Items[j].SubItems[0].Text + "','" + listView1.Items[j].SubItems[1].Text + "','" + listView1.Items[j].SubItems[2].Text + "','" + listView1.Items[j].SubItems[3].Text + "','" + 대기번호 + "','" + "선택중.." + "')";
                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
            }

            Conn.Close();

            pay PAY = new pay(this); //pay클래스 실행
            PAY.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e) 
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[0].Split(dot); //햄버거.jpg 중에 .jpg를 제외한 햄버거만 저장

                var Conn2 = new OleDbConnection(StrSQL);
                Conn2.Open();
                var Comm2 = new OleDbCommand("Select * From menu", Conn2);
                var myRead2 = Comm2.ExecuteReader();
                while (myRead2.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strMenu = myRead2["db_menu"].ToString();
                    var strPrice = myRead2["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        Setname = strMenu; //  setmenu클래스에 이름과 가격을 전달한다.
                        Setprice = strPrice; 
                    }
                }
                myRead2.Close();
                Conn2.Close();


                SetMenu setmenu = new SetMenu();
                setmenu.ShowDialog();

                if (SetMenu.checkbutton == 1) //setmenu클래스에서 주문담기 버튼을 선택했을경우 리스트뷰에 추가한다.
                {
                    //int menu_ID = 0;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        var strPrice = myRead["db_price"].ToString();
                        if (BugerName[0] == strMenu) 
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("1");
                            LVI.SubItems.Add(SetMenu.세트수정된가격);
                            LVI.SubItems.Add(SetMenu.사이드메뉴구성품);
                            listView1.Items.Add(LVI);
                        }
                    }
                    myRead.Close();
                    Conn.Close();
                }

            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //아래의 picturebox의 click이벤트 내용은 picturebox_click이벤트 내용과 동일하다
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[1].Split(dot);

                var Conn2 = new OleDbConnection(StrSQL);
                Conn2.Open();
                var Comm2 = new OleDbCommand("Select * From menu", Conn2);
                var myRead2 = Comm2.ExecuteReader();
                while (myRead2.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strMenu = myRead2["db_menu"].ToString();
                    var strPrice = myRead2["db_price"].ToString();
                    if (BugerName[0] == strMenu)
                    {
                        Setname = strMenu;
                        Setprice = strPrice;
                    }
                }
                myRead2.Close();
                Conn2.Close();


                SetMenu setmenu = new SetMenu();
                setmenu.ShowDialog();

                if (SetMenu.checkbutton == 1)
                {
                    //int menu_ID = 0;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        var strPrice = myRead["db_price"].ToString();

                        if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                        {

                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("1");
                            LVI.SubItems.Add(SetMenu.세트수정된가격);
                            LVI.SubItems.Add(SetMenu.사이드메뉴구성품);
                            listView1.Items.Add(LVI);
                        }

                    }
                    myRead.Close();
                    Conn.Close();
                }

            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[2].Split(dot);

                var Conn2 = new OleDbConnection(StrSQL);
                Conn2.Open();
                var Comm2 = new OleDbCommand("Select * From menu", Conn2);
                var myRead2 = Comm2.ExecuteReader();
                while (myRead2.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strMenu = myRead2["db_menu"].ToString();
                    var strPrice = myRead2["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        Setname = strMenu;
                        Setprice = strPrice;
                    }
                }
                myRead2.Close();
                Conn2.Close();


                SetMenu setmenu = new SetMenu();
                setmenu.ShowDialog();

                if (SetMenu.checkbutton == 1)
                {
                    //int menu_ID = 0;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        var strPrice = myRead["db_price"].ToString();
                        if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("1");
                            LVI.SubItems.Add(SetMenu.세트수정된가격);
                            LVI.SubItems.Add(SetMenu.사이드메뉴구성품);
                            listView1.Items.Add(LVI);
                        }
                    }
                    myRead.Close();
                    Conn.Close();
                }
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[3].Split(dot);

                var Conn2 = new OleDbConnection(StrSQL);
                Conn2.Open();
                var Comm2 = new OleDbCommand("Select * From menu", Conn2);
                var myRead2 = Comm2.ExecuteReader();
                while (myRead2.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strMenu = myRead2["db_menu"].ToString();
                    var strPrice = myRead2["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        Setname = strMenu;
                        Setprice = strPrice;
                    }
                }
                myRead2.Close();
                Conn2.Close();


                SetMenu setmenu = new SetMenu();
                setmenu.ShowDialog();

                if (SetMenu.checkbutton == 1)
                {
                    //int menu_ID = 0;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        var strPrice = myRead["db_price"].ToString();
                        if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("1");
                            LVI.SubItems.Add(SetMenu.세트수정된가격);
                            LVI.SubItems.Add(SetMenu.사이드메뉴구성품);
                            listView1.Items.Add(LVI);
                        }
                    }
                    myRead.Close();
                    Conn.Close();
                }
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[4].Split(dot);

                var Conn2 = new OleDbConnection(StrSQL);
                Conn2.Open();
                var Comm2 = new OleDbCommand("Select * From menu", Conn2);
                var myRead2 = Comm2.ExecuteReader();
                while (myRead2.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strMenu = myRead2["db_menu"].ToString();
                    var strPrice = myRead2["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        Setname = strMenu;
                        Setprice = strPrice;
                    }
                }
                myRead2.Close();
                Conn2.Close();


                SetMenu setmenu = new SetMenu();
                setmenu.ShowDialog();

                if (SetMenu.checkbutton == 1)
                {
                    //int menu_ID = 0;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        var strPrice = myRead["db_price"].ToString();
                        if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("1");
                            LVI.SubItems.Add(SetMenu.세트수정된가격);
                            LVI.SubItems.Add(SetMenu.사이드메뉴구성품);
                            listView1.Items.Add(LVI);
                        }
                    }
                    myRead.Close();
                    Conn.Close();
                }
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[5].Split(dot);

                var Conn2 = new OleDbConnection(StrSQL);
                Conn2.Open();
                var Comm2 = new OleDbCommand("Select * From menu", Conn2);
                var myRead2 = Comm2.ExecuteReader();
                while (myRead2.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strMenu = myRead2["db_menu"].ToString();
                    var strPrice = myRead2["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        Setname = strMenu;
                        Setprice = strPrice;
                    }
                }
                myRead2.Close();
                Conn2.Close();


                SetMenu setmenu = new SetMenu();
                setmenu.ShowDialog();

                if (SetMenu.checkbutton == 1)
                {
                    //int menu_ID = 0;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        var strPrice = myRead["db_price"].ToString();
                        if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("1");
                            LVI.SubItems.Add(SetMenu.세트수정된가격);
                            LVI.SubItems.Add(SetMenu.사이드메뉴구성품);
                            listView1.Items.Add(LVI);
                        }
                    }
                    myRead.Close();
                    Conn.Close();
                }
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[6].Split(dot);

                var Conn2 = new OleDbConnection(StrSQL);
                Conn2.Open();
                var Comm2 = new OleDbCommand("Select * From menu", Conn2);
                var myRead2 = Comm2.ExecuteReader();
                while (myRead2.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strMenu = myRead2["db_menu"].ToString();
                    var strPrice = myRead2["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        Setname = strMenu;
                        Setprice = strPrice;
                    }
                }
                myRead2.Close();
                Conn2.Close();


                SetMenu setmenu = new SetMenu();
                setmenu.ShowDialog();

                if (SetMenu.checkbutton == 1)
                {
                    //int menu_ID = 0;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        var strPrice = myRead["db_price"].ToString();
                        if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("1");
                            LVI.SubItems.Add(SetMenu.세트수정된가격);
                            LVI.SubItems.Add(SetMenu.사이드메뉴구성품);
                            listView1.Items.Add(LVI);
                        }
                    }
                    myRead.Close();
                    Conn.Close();
                }
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[7].Split(dot);

                var Conn2 = new OleDbConnection(StrSQL);
                Conn2.Open();
                var Comm2 = new OleDbCommand("Select * From menu", Conn2);
                var myRead2 = Comm2.ExecuteReader();
                while (myRead2.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strMenu = myRead2["db_menu"].ToString();
                    var strPrice = myRead2["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        Setname = strMenu;
                        Setprice = strPrice;
                    }
                }
                myRead2.Close();
                Conn2.Close();


                SetMenu setmenu = new SetMenu();
                setmenu.ShowDialog();

                if (SetMenu.checkbutton == 1)
                {
                    //int menu_ID = 0;
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();
                    var Comm = new OleDbCommand("Select * From menu", Conn);
                    var myRead = Comm.ExecuteReader();
                    while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                    {
                        var strId = myRead["ID"];
                        var strMenu = myRead["db_menu"].ToString();
                        var strPrice = myRead["db_price"].ToString();
                        if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("1");
                            LVI.SubItems.Add(SetMenu.세트수정된가격);
                            LVI.SubItems.Add(SetMenu.사이드메뉴구성품);
                            listView1.Items.Add(LVI);
                        }
                    }
                    myRead.Close();
                    Conn.Close();
                }
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //=============================햄버거 탭페이지==========================
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[8].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[9].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch//picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[10].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[11].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[12].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[13].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[14].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[15].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //==============사이드메뉴 탭페이지==================

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[16].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[17].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[18].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[19].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[20].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[21].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[22].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void pictureBox24_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[23].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }

        //====================음료디저트=====================================

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[24].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[25].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[26].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[27].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[28].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[29].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[30].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            try
            {
                char dot = '.';
                string[] BugerName = PathPictureName[31].Split(dot);

                int menu_ID = 0;
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Comm = new OleDbCommand("Select * From menu", Conn);
                var myRead = Comm.ExecuteReader();
                while (myRead.Read()) //데이터베이스 파일을 다 읽을 때까지 반복한다.
                {
                    var strId = myRead["ID"];
                    var strMenu = myRead["db_menu"].ToString();
                    var strPrice = myRead["db_price"].ToString();
                    if (BugerName[0] == strMenu) //설정한 사진과 동일한 메뉴이름을 찾는다
                    {
                        menu_ID = (int)strId;
                        Count[menu_ID] += 1;


                        if (Count[menu_ID] == 1)  //리스트뷰에 현재 이 메뉴가 추가 안되있을시 추가
                        {
                            ListViewItem LVI = new ListViewItem(strMenu);
                            LVI.SubItems.Add("0");
                            LVI.SubItems.Add(strPrice);
                            LVI.SubItems.Add("");
                            listView1.Items.Add(LVI);
                        }
                        for (int i = 0; i < listView1.Items.Count; i++) //추가되있을때는 수량만 변경
                        {
                            if (listView1.Items[i].SubItems[0].Text == strMenu)
                            {
                                listView1.Items[i].SubItems[1].Text = (int.Parse(listView1.Items[i].SubItems[1].Text) + 1).ToString();
                            }
                        }
                    }
                }
                myRead.Close();
                Conn.Close();
            }
            catch //picturebox의 사진이 없어서 Click이벤트가 실행안되는 부분 예외처리
            {
                MessageBox.Show("메뉴 준비중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
