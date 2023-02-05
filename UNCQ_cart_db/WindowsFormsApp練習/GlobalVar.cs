using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp練習
{
    internal class GlobalVar
    {
        public static string 訂購人資訊 = "";
        public static int 所選數量;
        public static int 商品價位;
        // ********************************************************************* //
        public static List<string> list商品名稱 = new List<string>();
        public static List<int> list商品價格 = new List<int>();
        // ********************************************************************* //
        public static List<ArrayList> list訂購品項資訊列表 = new List<ArrayList>();
        // ********************************************************************* //
        public static List<string> list顏色 = new List<string>();
        public static List<string> list尺寸 = new List<string>();
        public static List<ArrayList> bought = new List<ArrayList>();
        public static List<ArrayList> favorites = new List<ArrayList>();
        public static string account = "";
        public static int status;
        public static int total_amount;
    }
}
