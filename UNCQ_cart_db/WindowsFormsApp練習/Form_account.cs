using System;
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
    public partial class Form_account : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconnectionString = "";
        public Form_account()
        {
            InitializeComponent();
        }

        private void Form_account_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //.就是本機 //@就是不處理特殊符號
            scsb.InitialCatalog = "UNCQ"; //database名稱
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ToString();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void btn_signup_Click(object sender, EventArgs e)
        {
            if(textBoxacc.Text!="" && textBoxpass.Text != "" && textBoxname.Text != "" && textBoxphone.Text != "" && textBoxaddress.Text != "" && textBoxemail.Text != "" && Convert.ToString(dtp_birth.Value) != "")
            {
                string acc_check = textBoxacc.Text;
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string check_if_account_is_availible = "select [帳號] from account where [帳號] = @acc;";
                SqlCommand cmd = new SqlCommand(check_if_account_is_availible, con);
                cmd.Parameters.AddWithValue("@acc", acc_check);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("此帳號已有人使用");
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd.CommandText = "insert into account ([帳號],[密碼],[姓名],[電話],[地址],[email],[生日],[身分層級]) values (@account,@password,@name,@phone,@address,@email,@birthday,@class);";
                    cmd.Parameters.AddWithValue("@account", textBoxacc.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxpass.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxname.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxphone.Text);
                    cmd.Parameters.AddWithValue("@address", textBoxaddress.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxemail.Text);
                    cmd.Parameters.AddWithValue("@birthday", dtp_birth.Value);
                    cmd.Parameters.AddWithValue("@class", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("註冊成功");
                    this.Parent.Visible = false;
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入完整資料！");
            }
            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;
        }
    }
}
