using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp練習
{
    public partial class Form2cart : Form
    {
        List<int> selected_id = new List<int>();
        int Selected_cart_id = 0;

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconnectionString = "";
        public Form2cart()
        {
            InitializeComponent();
        }

        private void Form2_cart_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            scsb.DataSource = @"."; //.就是本機 //@就是不處理特殊符號
            scsb.InitialCatalog = "UNCQ"; //database名稱
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ToString();

            loaddd();
        }


        void loaddd()
        {
            List<ArrayList> cart_list = new List<ArrayList>();


            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string cart_query = "select product, price, quantity, size, color, total_amount, cart_id from Cartdata join Orderdata on Orderdata.order_id = Cartdata.order_id where Orderdata.orderer = @account;";
            SqlCommand cmd = new SqlCommand(cart_query, con);
            cmd.Parameters.AddWithValue("@account", GlobalVar.account);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ArrayList cart = new ArrayList();
                cart.Add(reader["product"].ToString());
                cart.Add(int.Parse(reader["price"].ToString()));
                cart.Add(int.Parse(reader["quantity"].ToString()));
                cart.Add(reader["size"].ToString());
                cart.Add(reader["color"].ToString());
                cart.Add(int.Parse(reader["total_amount"].ToString()));
                cart_list.Add(cart);
                selected_id.Add(int.Parse(reader["cart_id"].ToString()));
            }      

            listBox訂購品項列表.SelectionMode = SelectionMode.MultiExtended;
            int total_amount = 0;
            foreach (ArrayList order in cart_list)
            {
                string merch = (string)order[0];
                int price = (int)order[1];
                string size = (string)order[3];
                string color = (string)order[4];
                int quan = (int)order[2];
                int total = 0;
                total = price * quan;
                total_amount = total_amount + total;


                string str_order = merch + calculate_word(merch, 22) + size + "/" + color + calculate_word(size, 4) + price + calculate_word(price.ToString(), 7) + quan + "　　" + total;
                listBox訂購品項列表.Items.Add(str_order);

            }
            lbl訂單總價.Text = "總金額：" + total_amount.ToString() + "元";
            GlobalVar.total_amount = (int)total_amount;

            if (GlobalVar.status == 1000)
            {
                lbl訂單總價.Text = "優惠價：" + (GlobalVar.total_amount * 0.7).ToString() + "元";
                lbl_4client.Visible = true;
                lbl_4client.Text = "(員工專屬七折) 原價NT$" + GlobalVar.total_amount.ToString() + "元";
            }
            else
            {
                lbl_4client.Visible = false;
            }

            reader.Close();
            con.Close();
        }

        string calculate_word(string word, int j)
        {
            string sp = "";
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            byte[] s = ascii.GetBytes(word);
            for (int a = 0; a < s.Length; a++)
            {
                if ((int)s[a] == 63)
                {
                    tempLen += 2;
                }
                else
                {
                    tempLen += 1;
                }
            }
            int i = j - tempLen;
            if (i % 2 == 0)
            {
                for (int n = 0; n < i / 2; n++)
                {
                    sp += "　";
                }
            }
            else
            {
                sp += " ";
                for (int n = 0; n < (i - 1) / 2; n++)
                {
                    sp += "　";
                }
            }
            return sp;
        }



        private void listBox訂購品項列表_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox訂購品項列表.SelectedIndex >= 0)
            {
                Selected_cart_id = selected_id[listBox訂購品項列表.SelectedIndex];
            }
        }
        private void lbl_remove_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string delete_query = "delete from Cartdata where cart_id = @cid;";
            SqlCommand cmd = new SqlCommand(delete_query, con);
            cmd.Parameters.AddWithValue("@cid", Selected_cart_id);
            cmd.ExecuteNonQuery();
            con.Close();
            listBox訂購品項列表.Items.RemoveAt(listBox訂購品項列表.SelectedIndex);
        }
    }
}
