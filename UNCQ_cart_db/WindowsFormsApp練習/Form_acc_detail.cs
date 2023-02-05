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
    public partial class Form_acc_detail : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconnectionString = "";
        public Form_acc_detail()
        {
            InitializeComponent();
        }

        private void Form_acc_detail_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //.就是本機 //@就是不處理特殊符號
            scsb.InitialCatalog = "UNCQ"; //database名稱
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ToString();
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from account where [帳號] = @account;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@account", GlobalVar.account);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                label8.Text = reader["帳號"].ToString();
                textBoxpass.Text = reader["密碼"].ToString();
                textBoxname.Text = reader["姓名"].ToString();
                textBoxphone.Text = reader["電話"].ToString();
                textBoxaddress.Text = reader["地址"].ToString();
                textBoxemail.Text = reader["email"].ToString();
                dtp_birth.Value = Convert.ToDateTime(reader["生日"]);
                GlobalVar.status = Convert.ToInt32(reader["身分層級"]);

                if (GlobalVar.status == 1000)
                {
                    lbl_grade.Text = "管理者權限";
                } else
                {
                    lbl_grade.Text = "一般會員";
                }
            }
            reader.Close();
            con.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "update account set 密碼=@pass, 姓名=@name, 電話=@phone, 地址=@address, email=@email, 生日=@birth where 帳號 = @acc;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@acc", GlobalVar.account);
            cmd.Parameters.AddWithValue("@pass", textBoxpass.Text);
            cmd.Parameters.AddWithValue("@name", textBoxname.Text);
            cmd.Parameters.AddWithValue("@phone", textBoxphone.Text);
            cmd.Parameters.AddWithValue("@address", textBoxaddress.Text);
            cmd.Parameters.AddWithValue("@email", textBoxemail.Text);
            cmd.Parameters.AddWithValue("@birth", dtp_birth.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("修改成功！");
            this.Parent.Visible = false;
        }
    }
}
