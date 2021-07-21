using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 무인주문기프로젝트
{
    abstract class 메뉴정보얻기 //추상클래스
    {
        public String 메뉴 { get; set; } //프로퍼티로 메뉴정보를 받아온다.
        public String 가격 { get; set; }
        public String 수량 { get; set; }
        abstract public List<ListViewItem> 메뉴보기();
    }
}
