namespace WindowsFormsApp練習
{
    partial class Form2cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_toFav = new System.Windows.Forms.Label();
            this.lbl_remove = new System.Windows.Forms.Label();
            this.ck_cart_all = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.listBox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lbl_4client = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_toFav);
            this.groupBox1.Controls.Add(this.lbl_remove);
            this.groupBox1.Controls.Add(this.ck_cart_all);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(116, 1000);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(331, 112);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lbl_toFav
            // 
            this.lbl_toFav.AutoSize = true;
            this.lbl_toFav.Location = new System.Drawing.Point(205, 49);
            this.lbl_toFav.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_toFav.Name = "lbl_toFav";
            this.lbl_toFav.Size = new System.Drawing.Size(94, 21);
            this.lbl_toFav.TabIndex = 1;
            this.lbl_toFav.Text = "加入最愛";
            // 
            // lbl_remove
            // 
            this.lbl_remove.AutoSize = true;
            this.lbl_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_remove.Location = new System.Drawing.Point(126, 49);
            this.lbl_remove.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_remove.Name = "lbl_remove";
            this.lbl_remove.Size = new System.Drawing.Size(52, 21);
            this.lbl_remove.TabIndex = 1;
            this.lbl_remove.Text = "刪除";
            this.lbl_remove.Click += new System.EventHandler(this.lbl_remove_Click_1);
            // 
            // ck_cart_all
            // 
            this.ck_cart_all.AutoSize = true;
            this.ck_cart_all.Location = new System.Drawing.Point(16, 48);
            this.ck_cart_all.Margin = new System.Windows.Forms.Padding(6);
            this.ck_cart_all.Name = "ck_cart_all";
            this.ck_cart_all.Size = new System.Drawing.Size(78, 25);
            this.ck_cart_all.TabIndex = 0;
            this.ck_cart_all.Text = "全選";
            this.ck_cart_all.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(132, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1150, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品訊息                            尺寸/顏色售價         數量           合計        操作訂單";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(842, 1098);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 81);
            this.button2.TabIndex = 8;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1122, 1098);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 81);
            this.button1.TabIndex = 9;
            this.button1.Text = "結帳";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.AutoSize = true;
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.ForeColor = System.Drawing.Color.Red;
            this.lbl訂單總價.Location = new System.Drawing.Point(1073, 1039);
            this.lbl訂單總價.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(197, 53);
            this.lbl訂單總價.TabIndex = 7;
            this.lbl訂單總價.Text = "xxxxxx元";
            // 
            // listBox訂購品項列表
            // 
            this.listBox訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購品項列表.FormattingEnabled = true;
            this.listBox訂購品項列表.ItemHeight = 47;
            this.listBox訂購品項列表.Location = new System.Drawing.Point(116, 328);
            this.listBox訂購品項列表.Margin = new System.Windows.Forms.Padding(6);
            this.listBox訂購品項列表.Name = "listBox訂購品項列表";
            this.listBox訂購品項列表.Size = new System.Drawing.Size(1214, 521);
            this.listBox訂購品項列表.TabIndex = 5;
            this.listBox訂購品項列表.SelectedIndexChanged += new System.EventHandler(this.listBox訂購品項列表_SelectedIndexChanged_1);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox9.Image = global::WindowsFormsApp練習.Properties.Resources.top_bar_011;
            this.pictureBox9.Location = new System.Drawing.Point(0, -1);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1464, 241);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // lbl_4client
            // 
            this.lbl_4client.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_4client.ForeColor = System.Drawing.Color.Red;
            this.lbl_4client.Location = new System.Drawing.Point(1082, 1009);
            this.lbl_4client.Name = "lbl_4client";
            this.lbl_4client.Size = new System.Drawing.Size(400, 35);
            this.lbl_4client.TabIndex = 12;
            this.lbl_4client.Text = "(員工專屬) 原價NT$xxxx";
            this.lbl_4client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_4client.Visible = false;
            // 
            // Form2cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 1253);
            this.Controls.Add(this.lbl_4client);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.listBox訂購品項列表);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2cart";
            this.Text = "有你真酷 - 購物車";
            this.Load += new System.EventHandler(this.Form2_cart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_toFav;
        private System.Windows.Forms.Label lbl_remove;
        private System.Windows.Forms.CheckBox ck_cart_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.ListBox listBox訂購品項列表;
        private System.Windows.Forms.Label lbl_4client;
    }
}