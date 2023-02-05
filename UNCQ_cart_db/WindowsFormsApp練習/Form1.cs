using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp練習
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconnectionString = "";
        Form actform;

        public List<GroupBox> listGroupBox = new List<GroupBox>(); //step1
        public List<Label> listLabel = new List<Label>(); 
        public List<PictureBox> listPictureBox = new List<PictureBox>(); 
        public List<CheckBox> listCheckBox = new List<CheckBox>();
        public List<ComboBox> listComboBox數量 = new List<ComboBox>();
        public List<ComboBox> listComboBox尺寸 = new List<ComboBox>();
        public List<ComboBox> listComboBox顏色 = new List<ComboBox>();
        public List<Button> listButton單選商品 = new List<Button>();

        //-------------- 資料庫儲存區 -------------------
        List <string> list商品名稱 = new List<string>();
        List<int> list商品價格 = new List<int>();
        List<string> list顏色 = new List<string>();
        List<string> list尺寸 = new List<string>();
        List<string> list圖片 = new List<string>();

        /* ------------------------------------------ */
        string image_dir = @"image\";


        public Form1()
        {
            InitializeComponent();
            Form_signin form登入 = new Form_signin();
            form登入.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            scsb.DataSource = @"."; //.就是本機 //@就是不處理特殊符號
            scsb.InitialCatalog = "UNCQ"; //database名稱
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ToString();

            load_data();
            footer_fucntion();
            動態產生GB(5, 3);
        }

        void 動態產生GB(int intRow, int IntColumn)
        {
            /* SQL_to_LIST  */
            S_from_product();
            S_from_p_color();
            S_from_p_size();
            /* ------------ */

            int serialNo = 0;
            int p = 0;
            PictureBox banner_home = new PictureBox();
            banner_home.Image = Image.FromFile(@"image\top_bar.png");
            banner_home.SizeMode = PictureBoxSizeMode.StretchImage;
            banner_home.Size = new Size(780, 99);
            banner_home.Location = new Point(65, 5);
            Controls.Add(banner_home);
            panel_test.Controls.Add(banner_home);

            for (int i = 0; i < intRow; i += 1)
            {
                for (int j = 0; j < IntColumn; j += 1)
                {
                    serialNo += 1;
                    /* ---------------------- 產生GB ---------------------- */
                    System.Windows.Forms.GroupBox dgroupBox = new System.Windows.Forms.GroupBox();
                    dgroupBox.BackColor = Color.White;
                    dgroupBox.ForeColor = Color.Black;
                    dgroupBox.Font = new Font("微軟正黑體", 8);
                    dgroupBox.Text = "";
                    dgroupBox.Location = new Point(65 + 265 * j, 105 + 300 * i);
                    dgroupBox.Size = new Size(250, 285);
                    Controls.Add(dgroupBox);
                    listGroupBox.Add(dgroupBox); //step2

                    /* -------------------- 產生Label -------------------- */
                    Label dLabel = new Label();
                    dLabel.ForeColor = Color.Red;
                    dLabel.Font = new Font("微軟正黑體", 15, FontStyle.Bold);
                    dLabel.Text = "NT$" + "XXXX";
                    dLabel.Location = new Point(130, 180);
                    dLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    dLabel.AutoSize = true;
                    dLabel.Size = new Size(125, 50);
                    Controls.Add(dLabel);
                    listLabel.Add(dLabel);

                    if (p < list商品名稱.Count)
                    {
                        listLabel[p].Text = "NT$" + Convert.ToString(list商品價格[p]);
                    }

                    /* -------------------- 產生圖檔 -------------------- */
                    PictureBox dPictureBox = new PictureBox();
                    dPictureBox.Image = Image.FromFile(@"image\1.png");
                    dPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    dPictureBox.BackColor = Color.LightGray;
                    dPictureBox.Size = new Size(165, 150);
                    dPictureBox.Location = new Point(40, 30);
                    Controls.Add(dPictureBox);
                    listPictureBox.Add(dPictureBox);

                    int pp = p + 1;
                    if (pp <= list商品名稱.Count)
                    {
                        listPictureBox[p].Image = Image.FromFile(image_dir + list圖片[p]);
                    }

                    /* -------------------- 產生CBOX -------------------- */
                    CheckBox dCheckBox = new CheckBox();
                    dCheckBox.ForeColor = Color.Black;
                    dCheckBox.Font = new Font("微軟正黑體", 8);
                    dCheckBox.Text = "XXXXXXX" + serialNo.ToString();
                    dCheckBox.Size = new Size(185, 20);
                    dCheckBox.Location = new Point(5, 9);
                    Controls.Add(dCheckBox);
                    listCheckBox.Add(dCheckBox);


                    if (p < list商品名稱.Count)
                    {
                        listCheckBox[p].Text = list商品名稱[p];
                    }

                    /* -------------------- 產生Combo數量 -------------------- */
                    ComboBox dCombo數量 = new ComboBox();
                    dCombo數量.ForeColor = Color.Black;
                    dCombo數量.Font = new Font("微軟正黑體", 8);
                    dCombo數量.Text = "選擇數量";
                    dCombo數量.Location = new Point(10, 185);
                    dCombo數量.Size = new Size(85, 10);
                    Controls.Add(dCombo數量);
                    listComboBox數量.Add(dCombo數量);


                    /* -------------------- 產生Combo尺寸 -------------------- */
                    ComboBox dCombo尺寸 = new ComboBox();
                    dCombo尺寸.ForeColor = Color.Black;
                    dCombo尺寸.Font = new Font("微軟正黑體", 8);
                    dCombo尺寸.Text = "選擇尺寸";
                    dCombo尺寸.Location = new Point(10, 215);
                    dCombo尺寸.Size = new Size(85, 10);
                    Controls.Add(dCombo尺寸);
                    listComboBox尺寸.Add(dCombo尺寸);

                    /* -------------------- 產生Combo顏色 -------------------- */
                    ComboBox dCombo顏色 = new ComboBox();
                    dCombo顏色.ForeColor = Color.Black;
                    dCombo顏色.Font = new Font("微軟正黑體", 8);
                    dCombo顏色.Text = "選擇顏色";
                    dCombo顏色.Location = new Point(10, 245);
                    dCombo顏色.Size = new Size(85, 10);
                    Controls.Add(dCombo顏色);
                    listComboBox顏色.Add(dCombo顏色);

                    /* -------------------- 產生按此商品 -------------------- */
                    Button dbutton = new Button();
                    dbutton.BackColor = Color.Pink;
                    dbutton.ForeColor = Color.Black;
                    dbutton.Font = new Font("微軟正黑體", 12);
                    dbutton.Text = "加入購物車";
                    dbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    //dbutton.Name = serialNo.ToString();
                    dbutton.Location = new Point(120, 230);
                    dbutton.Size = new Size(105, 40);
                    Controls.Add(dbutton);
                    listButton單選商品.Add(dbutton); //step2

                    /* ----------------------------------------------------- */
                    p += 1;
                }
            }

            for (int i = 0; i < listGroupBox.Count; i++)
            {
                System.Windows.Forms.GroupBox groupBox = listGroupBox[i];
                Label dLabel = listLabel[i];
                PictureBox dPictureBox = listPictureBox[i];
                CheckBox dCheckBox = listCheckBox[i];
                ComboBox dComboBox數量 = listComboBox數量[i];
                ComboBox dComboBox尺寸 = listComboBox尺寸[i];
                ComboBox dComboBox顏色 = listComboBox顏色[i];
                Button dbutton = listButton單選商品[i];

                panel_test.Controls.Add(groupBox);
                listGroupBox[i].Controls.Add(dLabel);
                listGroupBox[i].Controls.Add(dPictureBox);
                listGroupBox[i].Controls.Add(dCheckBox);
                listGroupBox[i].Controls.Add(dComboBox數量);
                listGroupBox[i].Controls.Add(dComboBox尺寸);
                listGroupBox[i].Controls.Add(dComboBox顏色);
                listGroupBox[i].Controls.Add(dbutton);

                listButton單選商品[i].Click += btn_add2Cart_Click;
                listButton單選商品[i].FlatStyle = FlatStyle.Flat;
                listButton單選商品[i].FlatAppearance.BorderSize = 1;
                listButton單選商品[i].ForeColor = Color.Red;
                listButton單選商品[i].BackColor = Color.White;


                /* ----------- cbox帶資料 ----------- */
                for (int num = 1; num <= 10; num++)
                {
                    listComboBox數量[i].Items.Add(num);
                }

                foreach (var item in list尺寸)
                {
                    listComboBox尺寸[i].Items.Add(item);
                }

                foreach (var item in list顏色)
                {
                    listComboBox顏色[i].Items.Add(item);
                }

                int balan = listGroupBox.Count - list商品名稱.Count;

                if (balan == 2)
                {
                    listGroupBox[listGroupBox.Count - balan].Visible = false;
                    listGroupBox[listGroupBox.Count - balan +1].Visible = false;
                }
                else if(balan == 1)
                {
                    listGroupBox[listGroupBox.Count - balan].Visible = false;
                }
            }
        }

        public void S_from_product()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            //使用資料庫連線字串做參數
            con.Open();
            string strSQL = "select * from product;";     //
            SqlCommand cmd = new SqlCommand(strSQL, con); //製作cmd物件
            //cmd.Parameters.AddWithValue("@id",o);
            SqlDataReader reader = cmd.ExecuteReader();   //reader透過SQL語法取資料

            while (reader.Read())
            {
                list商品名稱.Add(reader["商品名稱"].ToString());
                list商品價格.Add(Convert.ToInt32(reader["商品價格"]));
                list圖片.Add(reader["商品圖片"].ToString());
            }

            reader.Close();
            con.Close();
        }

        public void S_from_p_color()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from p_color;";    
            SqlCommand cmd = new SqlCommand(strSQL, con); 
            SqlDataReader reader = cmd.ExecuteReader();  

            while (reader.Read())
            {
                list顏色.Add(reader["顏色"].ToString());
            }

            reader.Close();
            con.Close();
        }
        public void S_from_p_size()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from p_size;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list尺寸.Add(reader["尺寸"].ToString());
            }

            reader.Close();
            con.Close();
        }
        void load_data()
        {
            //Key                
            GlobalVar.list商品名稱.Add("清涼有型涼感機能外套");
            GlobalVar.list商品名稱.Add("時尚帥氣襯衫");
            GlobalVar.list商品名稱.Add("格紋襯衫");
            GlobalVar.list商品名稱.Add("厚磅素T");

            //Value                
            GlobalVar.list商品價格.Add(690);
            GlobalVar.list商品價格.Add(390);
            GlobalVar.list商品價格.Add(790);
            GlobalVar.list商品價格.Add(590);

            //顏色
            GlobalVar.list顏色.Add("白色");
            GlobalVar.list顏色.Add("黑色");
            GlobalVar.list顏色.Add("棕色");
            GlobalVar.list顏色.Add("黃色");
            GlobalVar.list顏色.Add("綠色");

            //尺寸
            GlobalVar.list尺寸.Add("XS");
            GlobalVar.list尺寸.Add("S");
            GlobalVar.list尺寸.Add("M");
            GlobalVar.list尺寸.Add("L");
            GlobalVar.list尺寸.Add("XL");
            GlobalVar.list尺寸.Add("XXL");
            GlobalVar.list尺寸.Add("3XL");
            GlobalVar.list尺寸.Add("4XL");
        }

        public void footer_fucntion()
        {
            pbox_bar_footer.Parent = pictureBox5;
            pbox_bar_footer.BackColor = Color.Transparent;
            pbox_bar_footer.Location = new Point(10, 7);

            btn_footer_fb.Parent = pbox_bar_footer;
            btn_footer_fb.BackColor = Color.Transparent;
            btn_footer_fb.Location = new Point(0, 12);

            btn_footer_LINE.Parent = pbox_bar_footer;
            btn_footer_LINE.BackColor = Color.Transparent;
            btn_footer_LINE.Location = new Point(46, 12);

            btn_footer_YT.Parent = pbox_bar_footer;
            btn_footer_YT.BackColor = Color.Transparent;
            btn_footer_YT.Location = new Point(93, 12);

            btn_footer_IG.Parent = pbox_bar_footer;
            btn_footer_IG.BackColor = Color.Transparent;
            btn_footer_IG.Location = new Point(139, 12);
        }

        private void btn_footer_fb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬請期待");
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            Form2cart form訂單品項列表 = new Form2cart();
            form訂單品項列表.ShowDialog();
        }

        private void btn_add2Cart_Click(object sender, EventArgs e)
        {
            int checkstatenum = 0;
            int order_id = 0;
            for (int i = 0; i < listGroupBox.Count; i++)
            {
                if (listCheckBox[i].Checked == true)
                {
                    checkstatenum++;
                }
            }

            if (checkstatenum > 0)
            {
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "insert into Orderdata ([order_date],[orderer]) OUTPUT INSERTED.order_id values (@date,@orderer);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@date", "2022-11-3");
                cmd.Parameters.AddWithValue("@orderer", GlobalVar.account);
                Int32 newId = (Int32)cmd.ExecuteScalar();
                order_id = newId;
                con.Close();
                MessageBox.Show("成功加入" + checkstatenum.ToString() + "件商品");
            }
            else
            {
                MessageBox.Show("您並未勾選任何商品");
            }

            for (int i = 0; i < listGroupBox.Count; i++)
            {
                if (listCheckBox[i].Checked == true)
                {
                    int total_p = list商品價格[i] * Convert.ToInt16(listComboBox數量[i].Text);
                    SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string strSQL = "insert into Cartdata ([order_id],[product],[price],[quantity],[size],[color],[total_amount]) values (@id,@product,@price,@quantity,@size,@color,@total_price);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@id", order_id);
                    cmd.Parameters.AddWithValue("@product", list商品名稱[i]);
                    cmd.Parameters.AddWithValue("@price", list商品價格[i]);
                    cmd.Parameters.AddWithValue("@quantity", listComboBox數量[i].Text);
                    cmd.Parameters.AddWithValue("@size", listComboBox尺寸[i].Text);
                    cmd.Parameters.AddWithValue("@color", listComboBox顏色[i].Text);
                    cmd.Parameters.AddWithValue("@total_price", total_p);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            foreach (Control c in panel_test.Controls.OfType<GroupBox>())
            {
                foreach (Control ctr in c.Controls)
                {
                    if (ctr is CheckBox)
                    {
                        ((CheckBox)ctr).CheckState = CheckState.Unchecked;
                    }
                    else if (ctr is ComboBox)
                    {
                        ((ComboBox)ctr).SelectedIndex = -1;
                    }
                }
            }
        }

        private void btn_cancel_add_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel_test.Controls.OfType<GroupBox>())
            {
                foreach (Control ctr in c.Controls)
                {
                    if (ctr is CheckBox)
                    {
                        ((CheckBox)ctr).CheckState = CheckState.Unchecked;
                    }
                    else if (ctr is ComboBox)
                    {
                        ((ComboBox)ctr).SelectedIndex = -1;
                    }
                }
            }
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            if(GlobalVar.account != "")
            {
                OpenNewForm(new Form_acc_detail(), sender);
            }
            else
            {
                Form_signin form登入 = new Form_signin();
                form登入.ShowDialog();
            }
            
        }

        private void btn_favorite_Click(object sender, EventArgs e)
        {
            if (panel_4p1.Visible == false)
            {
                /*Form_signin form11 = new Form_signin();
                panel_4p1.Controls.Add(form11);
                form11.Show();
                panel_4p1.Visible = true;*/
                OpenNewForm(new Form_signin(),sender);

            } else
            {
                panel_4p1.Visible = false;
            }
        }
        void OpenNewForm(Form Test,object btnsender)
        {
            panel_4p1.Visible = true;
            if (actform != null)
            {
                actform.Close();
            }actform = Test;
            Test.TopLevel = false;
            Test.FormBorderStyle = FormBorderStyle.None;
            Test.Dock = DockStyle.Fill;
            panel_4p1.Controls.Add(Test);
            Test.BringToFront();
            Test.Show();
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            panel_4p1.Visible = false;
        }
    }
}
