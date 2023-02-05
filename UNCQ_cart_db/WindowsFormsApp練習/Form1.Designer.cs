namespace WindowsFormsApp練習
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_test = new System.Windows.Forms.Panel();
            this.panel_4p1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_leave = new System.Windows.Forms.Button();
            this.panel_acc_detail = new System.Windows.Forms.Panel();
            this.btn_cancel_add = new System.Windows.Forms.Button();
            this.btn_add2myFav = new System.Windows.Forms.Button();
            this.btn_add2Cart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_footer_IG = new System.Windows.Forms.Button();
            this.btn_footer_YT = new System.Windows.Forms.Button();
            this.btn_footer_LINE = new System.Windows.Forms.Button();
            this.btn_footer_fb = new System.Windows.Forms.Button();
            this.pbox_bar_footer = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_favorite = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbox_footer = new System.Windows.Forms.PictureBox();
            this.panel_4p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_bar_footer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_footer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_test
            // 
            this.panel_test.AutoScroll = true;
            this.panel_test.BackColor = System.Drawing.Color.White;
            this.panel_test.Location = new System.Drawing.Point(0, 113);
            this.panel_test.Margin = new System.Windows.Forms.Padding(6);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(1687, 1067);
            this.panel_test.TabIndex = 0;
            // 
            // panel_4p1
            // 
            this.panel_4p1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_4p1.Controls.Add(this.label1);
            this.panel_4p1.Controls.Add(this.btn_leave);
            this.panel_4p1.Controls.Add(this.panel_acc_detail);
            this.panel_4p1.Location = new System.Drawing.Point(0, 118);
            this.panel_4p1.Margin = new System.Windows.Forms.Padding(6);
            this.panel_4p1.Name = "panel_4p1";
            this.panel_4p1.Size = new System.Drawing.Size(1687, 1065);
            this.panel_4p1.TabIndex = 0;
            this.panel_4p1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(406, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 112);
            this.label1.TabIndex = 17;
            this.label1.Text = "會員已成功登入!";
            // 
            // btn_leave
            // 
            this.btn_leave.AllowDrop = true;
            this.btn_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_leave.FlatAppearance.BorderSize = 0;
            this.btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave.Font = new System.Drawing.Font("微軟正黑體", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_leave.ForeColor = System.Drawing.Color.White;
            this.btn_leave.Location = new System.Drawing.Point(663, 575);
            this.btn_leave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(330, 112);
            this.btn_leave.TabIndex = 18;
            this.btn_leave.Text = "前往採購";
            this.btn_leave.UseVisualStyleBackColor = false;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // panel_acc_detail
            // 
            this.panel_acc_detail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_acc_detail.BackColor = System.Drawing.Color.Black;
            this.panel_acc_detail.Location = new System.Drawing.Point(15, 601);
            this.panel_acc_detail.Margin = new System.Windows.Forms.Padding(6);
            this.panel_acc_detail.Name = "panel_acc_detail";
            this.panel_acc_detail.Size = new System.Drawing.Size(303, 374);
            this.panel_acc_detail.TabIndex = 16;
            this.panel_acc_detail.Visible = false;
            // 
            // btn_cancel_add
            // 
            this.btn_cancel_add.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_cancel_add.FlatAppearance.BorderSize = 0;
            this.btn_cancel_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel_add.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancel_add.Location = new System.Drawing.Point(1249, 1212);
            this.btn_cancel_add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cancel_add.Name = "btn_cancel_add";
            this.btn_cancel_add.Size = new System.Drawing.Size(172, 77);
            this.btn_cancel_add.TabIndex = 5;
            this.btn_cancel_add.Text = "全部取消";
            this.btn_cancel_add.UseVisualStyleBackColor = false;
            this.btn_cancel_add.Click += new System.EventHandler(this.btn_cancel_add_Click);
            // 
            // btn_add2myFav
            // 
            this.btn_add2myFav.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_add2myFav.FlatAppearance.BorderSize = 0;
            this.btn_add2myFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add2myFav.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add2myFav.ForeColor = System.Drawing.Color.White;
            this.btn_add2myFav.Location = new System.Drawing.Point(1069, 1211);
            this.btn_add2myFav.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add2myFav.Name = "btn_add2myFav";
            this.btn_add2myFav.Size = new System.Drawing.Size(176, 77);
            this.btn_add2myFav.TabIndex = 6;
            this.btn_add2myFav.Text = "加入最愛";
            this.btn_add2myFav.UseVisualStyleBackColor = false;
            this.btn_add2myFav.Visible = false;
            // 
            // btn_add2Cart
            // 
            this.btn_add2Cart.BackColor = System.Drawing.Color.Purple;
            this.btn_add2Cart.FlatAppearance.BorderSize = 0;
            this.btn_add2Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add2Cart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add2Cart.ForeColor = System.Drawing.Color.White;
            this.btn_add2Cart.Location = new System.Drawing.Point(1441, 1211);
            this.btn_add2Cart.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add2Cart.Name = "btn_add2Cart";
            this.btn_add2Cart.Size = new System.Drawing.Size(198, 77);
            this.btn_add2Cart.TabIndex = 5;
            this.btn_add2Cart.Text = "選入購物車";
            this.btn_add2Cart.UseVisualStyleBackColor = false;
            this.btn_add2Cart.Click += new System.EventHandler(this.btn_add2Cart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(1291, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 47);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(1530, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "搜尋";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_footer_IG
            // 
            this.btn_footer_IG.BackColor = System.Drawing.Color.Transparent;
            this.btn_footer_IG.BackgroundImage = global::WindowsFormsApp練習.Properties.Resources.logo_Instagram1;
            this.btn_footer_IG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_footer_IG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_footer_IG.FlatAppearance.BorderSize = 0;
            this.btn_footer_IG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_footer_IG.Location = new System.Drawing.Point(204, 1261);
            this.btn_footer_IG.Margin = new System.Windows.Forms.Padding(6);
            this.btn_footer_IG.Name = "btn_footer_IG";
            this.btn_footer_IG.Size = new System.Drawing.Size(56, 53);
            this.btn_footer_IG.TabIndex = 1;
            this.btn_footer_IG.UseVisualStyleBackColor = false;
            this.btn_footer_IG.Click += new System.EventHandler(this.btn_footer_fb_Click);
            // 
            // btn_footer_YT
            // 
            this.btn_footer_YT.BackColor = System.Drawing.Color.Transparent;
            this.btn_footer_YT.BackgroundImage = global::WindowsFormsApp練習.Properties.Resources.logo_Youtube;
            this.btn_footer_YT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_footer_YT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_footer_YT.FlatAppearance.BorderSize = 0;
            this.btn_footer_YT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_footer_YT.Location = new System.Drawing.Point(136, 1261);
            this.btn_footer_YT.Margin = new System.Windows.Forms.Padding(6);
            this.btn_footer_YT.Name = "btn_footer_YT";
            this.btn_footer_YT.Size = new System.Drawing.Size(56, 53);
            this.btn_footer_YT.TabIndex = 1;
            this.btn_footer_YT.UseVisualStyleBackColor = false;
            this.btn_footer_YT.Click += new System.EventHandler(this.btn_footer_fb_Click);
            // 
            // btn_footer_LINE
            // 
            this.btn_footer_LINE.BackColor = System.Drawing.Color.Transparent;
            this.btn_footer_LINE.BackgroundImage = global::WindowsFormsApp練習.Properties.Resources.logo_LINE;
            this.btn_footer_LINE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_footer_LINE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_footer_LINE.FlatAppearance.BorderSize = 0;
            this.btn_footer_LINE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_footer_LINE.Location = new System.Drawing.Point(67, 1261);
            this.btn_footer_LINE.Margin = new System.Windows.Forms.Padding(6);
            this.btn_footer_LINE.Name = "btn_footer_LINE";
            this.btn_footer_LINE.Size = new System.Drawing.Size(56, 53);
            this.btn_footer_LINE.TabIndex = 1;
            this.btn_footer_LINE.UseVisualStyleBackColor = false;
            this.btn_footer_LINE.Click += new System.EventHandler(this.btn_footer_fb_Click);
            // 
            // btn_footer_fb
            // 
            this.btn_footer_fb.BackColor = System.Drawing.Color.Transparent;
            this.btn_footer_fb.BackgroundImage = global::WindowsFormsApp練習.Properties.Resources.logo_facebook;
            this.btn_footer_fb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_footer_fb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_footer_fb.FlatAppearance.BorderSize = 0;
            this.btn_footer_fb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_footer_fb.Location = new System.Drawing.Point(0, 1261);
            this.btn_footer_fb.Margin = new System.Windows.Forms.Padding(6);
            this.btn_footer_fb.Name = "btn_footer_fb";
            this.btn_footer_fb.Size = new System.Drawing.Size(56, 53);
            this.btn_footer_fb.TabIndex = 1;
            this.btn_footer_fb.UseVisualStyleBackColor = false;
            this.btn_footer_fb.Click += new System.EventHandler(this.btn_footer_fb_Click);
            // 
            // pbox_bar_footer
            // 
            this.pbox_bar_footer.BackColor = System.Drawing.Color.Transparent;
            this.pbox_bar_footer.Image = global::WindowsFormsApp練習.Properties.Resources.img_footer_sns;
            this.pbox_bar_footer.Location = new System.Drawing.Point(22, 1212);
            this.pbox_bar_footer.Margin = new System.Windows.Forms.Padding(6);
            this.pbox_bar_footer.Name = "pbox_bar_footer";
            this.pbox_bar_footer.Size = new System.Drawing.Size(312, 73);
            this.pbox_bar_footer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_bar_footer.TabIndex = 0;
            this.pbox_bar_footer.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Location = new System.Drawing.Point(21, 1203);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(351, 97);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_account.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_account.BackgroundImage")));
            this.btn_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_account.FlatAppearance.BorderSize = 0;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_account.Location = new System.Drawing.Point(48, 34);
            this.btn_account.Margin = new System.Windows.Forms.Padding(6);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(45, 43);
            this.btn_account.TabIndex = 7;
            this.btn_account.UseVisualStyleBackColor = false;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_favorite
            // 
            this.btn_favorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_favorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_favorite.BackgroundImage")));
            this.btn_favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_favorite.FlatAppearance.BorderSize = 0;
            this.btn_favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_favorite.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_favorite.Location = new System.Drawing.Point(116, 31);
            this.btn_favorite.Margin = new System.Windows.Forms.Padding(6);
            this.btn_favorite.Name = "btn_favorite";
            this.btn_favorite.Size = new System.Drawing.Size(45, 43);
            this.btn_favorite.TabIndex = 7;
            this.btn_favorite.UseVisualStyleBackColor = false;
            this.btn_favorite.Click += new System.EventHandler(this.btn_favorite_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_admin.BackgroundImage")));
            this.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_admin.Location = new System.Drawing.Point(252, 34);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(6);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(45, 43);
            this.btn_admin.TabIndex = 7;
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Visible = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_cart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cart.BackgroundImage")));
            this.btn_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cart.FlatAppearance.BorderSize = 0;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cart.Location = new System.Drawing.Point(183, 31);
            this.btn_cart.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(45, 43);
            this.btn_cart.TabIndex = 7;
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox4.Location = new System.Drawing.Point(0, 113);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1687, 3);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(832, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(747, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1182);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1687, 6);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pbox_footer
            // 
            this.pbox_footer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbox_footer.Location = new System.Drawing.Point(0, 1182);
            this.pbox_footer.Margin = new System.Windows.Forms.Padding(6);
            this.pbox_footer.Name = "pbox_footer";
            this.pbox_footer.Size = new System.Drawing.Size(1687, 133);
            this.pbox_footer.TabIndex = 8;
            this.pbox_footer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1684, 1315);
            this.Controls.Add(this.panel_4p1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_footer_IG);
            this.Controls.Add(this.btn_footer_YT);
            this.Controls.Add(this.btn_footer_LINE);
            this.Controls.Add(this.btn_footer_fb);
            this.Controls.Add(this.pbox_bar_footer);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.btn_favorite);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_add2Cart);
            this.Controls.Add(this.btn_cancel_add);
            this.Controls.Add(this.btn_add2myFav);
            this.Controls.Add(this.pbox_footer);
            this.Controls.Add(this.panel_test);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "有你真酷 - 商城系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_4p1.ResumeLayout(false);
            this.panel_4p1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_bar_footer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_footer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_test;
        private System.Windows.Forms.Button btn_cancel_add;
        private System.Windows.Forms.Button btn_add2myFav;
        private System.Windows.Forms.PictureBox pbox_footer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add2Cart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.Button btn_favorite;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_4p1;
        private System.Windows.Forms.PictureBox pbox_bar_footer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_footer_fb;
        private System.Windows.Forms.Button btn_footer_LINE;
        private System.Windows.Forms.Button btn_footer_YT;
        private System.Windows.Forms.Button btn_footer_IG;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Panel panel_acc_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_leave;
    }
}

