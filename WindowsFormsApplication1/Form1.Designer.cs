namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_key_encrypt = new System.Windows.Forms.TextBox();
            this.btn_toEncrypt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox_plaintText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_ciphertext = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_key_decrypt = new System.Windows.Forms.TextBox();
            this.btn_tryDecrypt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_find_key = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox_decrypt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifu_lbl_bar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_set_mock = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_clear_text = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btn_toEncrypt);
            this.groupBox1.Controls.Add(this.textBox_plaintText);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(839, 123);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plain Text";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.textBox_key_encrypt);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(634, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(113, 90);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Key Encrypt";
            // 
            // textBox_key_encrypt
            // 
            this.textBox_key_encrypt.BackColor = System.Drawing.Color.Lavender;
            this.textBox_key_encrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_key_encrypt.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_key_encrypt.Location = new System.Drawing.Point(3, 24);
            this.textBox_key_encrypt.Multiline = true;
            this.textBox_key_encrypt.Name = "textBox_key_encrypt";
            this.textBox_key_encrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_key_encrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_key_encrypt.Size = new System.Drawing.Size(107, 63);
            this.textBox_key_encrypt.TabIndex = 42;
            this.textBox_key_encrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_key_encrypt.DoubleClick += new System.EventHandler(this.textBox_key_encrypt_DoubleClick);
            this.textBox_key_encrypt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_key_encrypt_KeyUp);
            // 
            // btn_toEncrypt
            // 
            this.btn_toEncrypt.ActiveBorderThickness = 2;
            this.btn_toEncrypt.ActiveCornerRadius = 10;
            this.btn_toEncrypt.ActiveFillColor = System.Drawing.Color.Chocolate;
            this.btn_toEncrypt.ActiveForecolor = System.Drawing.Color.White;
            this.btn_toEncrypt.ActiveLineColor = System.Drawing.Color.Chocolate;
            this.btn_toEncrypt.BackColor = System.Drawing.Color.Silver;
            this.btn_toEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_toEncrypt.BackgroundImage")));
            this.btn_toEncrypt.ButtonText = "Encrypt";
            this.btn_toEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toEncrypt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_toEncrypt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toEncrypt.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_toEncrypt.IdleBorderThickness = 2;
            this.btn_toEncrypt.IdleCornerRadius = 10;
            this.btn_toEncrypt.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_toEncrypt.IdleForecolor = System.Drawing.Color.Chocolate;
            this.btn_toEncrypt.IdleLineColor = System.Drawing.Color.Chocolate;
            this.btn_toEncrypt.Location = new System.Drawing.Point(747, 30);
            this.btn_toEncrypt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_toEncrypt.Name = "btn_toEncrypt";
            this.btn_toEncrypt.Size = new System.Drawing.Size(89, 90);
            this.btn_toEncrypt.TabIndex = 32;
            this.btn_toEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_toEncrypt.Click += new System.EventHandler(this.btn_toEncrypt_Click_1);
            // 
            // textBox_plaintText
            // 
            this.textBox_plaintText.BackColor = System.Drawing.Color.Lavender;
            this.textBox_plaintText.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_plaintText.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_plaintText.Location = new System.Drawing.Point(3, 30);
            this.textBox_plaintText.Multiline = true;
            this.textBox_plaintText.Name = "textBox_plaintText";
            this.textBox_plaintText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_plaintText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_plaintText.Size = new System.Drawing.Size(631, 90);
            this.textBox_plaintText.TabIndex = 29;
            this.textBox_plaintText.DoubleClick += new System.EventHandler(this.textBox_plaintText_DoubleClick);
            this.textBox_plaintText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_plaintText_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_ciphertext);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(15, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 272);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cipher Text";
            // 
            // textBox_ciphertext
            // 
            this.textBox_ciphertext.BackColor = System.Drawing.Color.Lavender;
            this.textBox_ciphertext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ciphertext.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ciphertext.Location = new System.Drawing.Point(3, 30);
            this.textBox_ciphertext.Multiline = true;
            this.textBox_ciphertext.Name = "textBox_ciphertext";
            this.textBox_ciphertext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ciphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ciphertext.Size = new System.Drawing.Size(833, 169);
            this.textBox_ciphertext.TabIndex = 33;
            this.textBox_ciphertext.DoubleClick += new System.EventHandler(this.textBox_ciphertext_DoubleClick);
            this.textBox_ciphertext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ciphertext_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.btn_tryDecrypt);
            this.panel2.Controls.Add(this.btn_find_key);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 70);
            this.panel2.TabIndex = 38;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.textBox_key_decrypt);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(290, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 70);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Key Decrypt";
            // 
            // textBox_key_decrypt
            // 
            this.textBox_key_decrypt.BackColor = System.Drawing.Color.Lavender;
            this.textBox_key_decrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_key_decrypt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_key_decrypt.Location = new System.Drawing.Point(3, 30);
            this.textBox_key_decrypt.Multiline = true;
            this.textBox_key_decrypt.Name = "textBox_key_decrypt";
            this.textBox_key_decrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_key_decrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_key_decrypt.Size = new System.Drawing.Size(247, 37);
            this.textBox_key_decrypt.TabIndex = 42;
            this.textBox_key_decrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_key_decrypt.DoubleClick += new System.EventHandler(this.textBox_key_decrypt_DoubleClick);
            this.textBox_key_decrypt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_key_decrypt_KeyUp);
            // 
            // btn_tryDecrypt
            // 
            this.btn_tryDecrypt.ActiveBorderThickness = 2;
            this.btn_tryDecrypt.ActiveCornerRadius = 10;
            this.btn_tryDecrypt.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_tryDecrypt.ActiveForecolor = System.Drawing.Color.White;
            this.btn_tryDecrypt.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_tryDecrypt.BackColor = System.Drawing.Color.Silver;
            this.btn_tryDecrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tryDecrypt.BackgroundImage")));
            this.btn_tryDecrypt.ButtonText = "Decrypt";
            this.btn_tryDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tryDecrypt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_tryDecrypt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tryDecrypt.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_tryDecrypt.IdleBorderThickness = 2;
            this.btn_tryDecrypt.IdleCornerRadius = 10;
            this.btn_tryDecrypt.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_tryDecrypt.IdleForecolor = System.Drawing.Color.MediumSeaGreen;
            this.btn_tryDecrypt.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_tryDecrypt.Location = new System.Drawing.Point(543, 0);
            this.btn_tryDecrypt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_tryDecrypt.Name = "btn_tryDecrypt";
            this.btn_tryDecrypt.Size = new System.Drawing.Size(290, 70);
            this.btn_tryDecrypt.TabIndex = 46;
            this.btn_tryDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tryDecrypt.Click += new System.EventHandler(this.btn_tryDecrypt_Click);
            // 
            // btn_find_key
            // 
            this.btn_find_key.ActiveBorderThickness = 2;
            this.btn_find_key.ActiveCornerRadius = 10;
            this.btn_find_key.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_find_key.ActiveForecolor = System.Drawing.Color.White;
            this.btn_find_key.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_find_key.BackColor = System.Drawing.Color.Silver;
            this.btn_find_key.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_find_key.BackgroundImage")));
            this.btn_find_key.ButtonText = "Try to Find Key";
            this.btn_find_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find_key.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_find_key.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_key.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_find_key.IdleBorderThickness = 2;
            this.btn_find_key.IdleCornerRadius = 10;
            this.btn_find_key.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_find_key.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btn_find_key.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_find_key.Location = new System.Drawing.Point(0, 0);
            this.btn_find_key.Margin = new System.Windows.Forms.Padding(0);
            this.btn_find_key.Name = "btn_find_key";
            this.btn_find_key.Size = new System.Drawing.Size(290, 70);
            this.btn_find_key.TabIndex = 45;
            this.btn_find_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_find_key.Click += new System.EventHandler(this.btn_find_key_Click);
            // 
            // textBox_decrypt
            // 
            this.textBox_decrypt.BackColor = System.Drawing.Color.Lavender;
            this.textBox_decrypt.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_decrypt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_decrypt.Location = new System.Drawing.Point(6, 30);
            this.textBox_decrypt.Multiline = true;
            this.textBox_decrypt.Name = "textBox_decrypt";
            this.textBox_decrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_decrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_decrypt.Size = new System.Drawing.Size(830, 90);
            this.textBox_decrypt.TabIndex = 29;
            this.textBox_decrypt.DoubleClick += new System.EventHandler(this.textBox_decrypt_DoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_decrypt);
            this.groupBox5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(15, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(839, 123);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Decrypt Text";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.bunifuCustomLabel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(2, 617);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 33);
            this.panel3.TabIndex = 45;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(199, 2);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(493, 28);
            this.bunifuCustomLabel3.TabIndex = 40;
            this.bunifuCustomLabel3.Text = "- and - ";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(692, 2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(174, 28);
            this.bunifuCustomLabel1.TabIndex = 39;
            this.bunifuCustomLabel1.Text = "Adir Zoari";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(0, 2);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(199, 28);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = "Hadriel Benjo";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(866, 2);
            this.bunifuCustomLabel4.TabIndex = 41;
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bunifu_lbl_bar);
            this.panel1.Controls.Add(this.btn_set_mock);
            this.panel1.Controls.Add(this.btn_clear_text);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 43);
            this.panel1.TabIndex = 26;
            // 
            // bunifu_lbl_bar
            // 
            this.bunifu_lbl_bar.BackColor = System.Drawing.Color.Black;
            this.bunifu_lbl_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifu_lbl_bar.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifu_lbl_bar.ForeColor = System.Drawing.Color.White;
            this.bunifu_lbl_bar.Location = new System.Drawing.Point(130, 0);
            this.bunifu_lbl_bar.Name = "bunifu_lbl_bar";
            this.bunifu_lbl_bar.Size = new System.Drawing.Size(696, 43);
            this.bunifu_lbl_bar.TabIndex = 28;
            this.bunifu_lbl_bar.Text = "Vigenère Cryptanalysis";
            this.bunifu_lbl_bar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifu_lbl_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifu_lbl_bar_MouseDown);
            this.bunifu_lbl_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifu_lbl_bar_MouseMove);
            this.bunifu_lbl_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifu_lbl_bar_MouseUp);
            // 
            // btn_set_mock
            // 
            this.btn_set_mock.ActiveBorderThickness = 2;
            this.btn_set_mock.ActiveCornerRadius = 10;
            this.btn_set_mock.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btn_set_mock.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_set_mock.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.btn_set_mock.BackColor = System.Drawing.Color.Black;
            this.btn_set_mock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_set_mock.BackgroundImage")));
            this.btn_set_mock.ButtonText = "Mock Data";
            this.btn_set_mock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_set_mock.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_set_mock.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set_mock.ForeColor = System.Drawing.Color.White;
            this.btn_set_mock.IdleBorderThickness = 2;
            this.btn_set_mock.IdleCornerRadius = 10;
            this.btn_set_mock.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_set_mock.IdleForecolor = System.Drawing.Color.White;
            this.btn_set_mock.IdleLineColor = System.Drawing.Color.White;
            this.btn_set_mock.Location = new System.Drawing.Point(32, 0);
            this.btn_set_mock.Margin = new System.Windows.Forms.Padding(0);
            this.btn_set_mock.Name = "btn_set_mock";
            this.btn_set_mock.Size = new System.Drawing.Size(98, 43);
            this.btn_set_mock.TabIndex = 33;
            this.btn_set_mock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_set_mock.Click += new System.EventHandler(this.btn_set_mock_Click);
            // 
            // btn_clear_text
            // 
            this.btn_clear_text.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear_text.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_clear_text.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.icons8_waste;
            this.btn_clear_text.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_waste;
            this.btn_clear_text.ImageActive = null;
            this.btn_clear_text.Location = new System.Drawing.Point(0, 0);
            this.btn_clear_text.Name = "btn_clear_text";
            this.btn_clear_text.Size = new System.Drawing.Size(32, 43);
            this.btn_clear_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_clear_text.TabIndex = 29;
            this.btn_clear_text.TabStop = false;
            this.btn_clear_text.Zoom = 10;
            this.btn_clear_text.Click += new System.EventHandler(this.btn_clear_text_Click);
            this.btn_clear_text.MouseEnter += new System.EventHandler(this.btn_clear_text_MouseEnter);
            this.btn_clear_text.MouseLeave += new System.EventHandler(this.btn_clear_text_MouseLeave);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_multiply_filled;
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(826, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 43);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 0;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifu_lbl_bar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(868, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(3, 650);
            this.bunifuCustomLabel5.TabIndex = 46;
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(2, 650);
            this.bunifuCustomLabel6.TabIndex = 47;
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(0, 30);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(866, 3);
            this.bunifuCustomLabel7.TabIndex = 42;
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(871, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_ciphertext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_plaintText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_key_encrypt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_decrypt;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_toEncrypt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_key_decrypt;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_tryDecrypt;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_find_key;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifu_lbl_bar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_set_mock;
        private Bunifu.Framework.UI.BunifuImageButton btn_clear_text;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}

