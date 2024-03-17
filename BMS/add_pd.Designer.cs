namespace BMS
{
    partial class add_pd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_pd));
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.doj = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.sector = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trade = new System.Windows.Forms.ComboBox();
            this.rank = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paygrade = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.forceno = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.address_rtb = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(174, 200);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(378, 22);
            this.firstname.TabIndex = 0;
            this.firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(174, 231);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(378, 22);
            this.lastname.TabIndex = 3;
            this.lastname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth";
            // 
            // dob
            // 
            this.dob.CustomFormat = "yyyy-MM-dd";
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(174, 267);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(164, 22);
            this.dob.TabIndex = 5;
            this.dob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of Joining";
            // 
            // doj
            // 
            this.doj.CustomFormat = "yyyy-MM-dd";
            this.doj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.doj.Location = new System.Drawing.Point(176, 559);
            this.doj.Name = "doj";
            this.doj.Size = new System.Drawing.Size(167, 22);
            this.doj.TabIndex = 7;
            this.doj.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sector";
            // 
            // sector
            // 
            this.sector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sector.FormattingEnabled = true;
            this.sector.Items.AddRange(new object[] {
            "NORTH",
            "EAST",
            "WEST",
            "SOUTH",
            "NORTH EAST"});
            this.sector.Location = new System.Drawing.Point(422, 560);
            this.sector.Name = "sector";
            this.sector.Size = new System.Drawing.Size(169, 24);
            this.sector.TabIndex = 9;
            this.sector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // gender_cb
            // 
            this.gender_cb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gender_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.gender_cb.Location = new System.Drawing.Point(422, 269);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(130, 24);
            this.gender_cb.TabIndex = 12;
            this.gender_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Rank";
            // 
            // trade
            // 
            this.trade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trade.FormattingEnabled = true;
            this.trade.Items.AddRange(new object[] {
            "Executive",
            "General Duty",
            "Intelligence",
            "Technical",
            "Ministerial",
            "Administrative",
            "Law",
            "Medical",
            "Tradesman"});
            this.trade.Location = new System.Drawing.Point(422, 611);
            this.trade.Name = "trade";
            this.trade.Size = new System.Drawing.Size(169, 24);
            this.trade.TabIndex = 17;
            this.trade.SelectedIndexChanged += new System.EventHandler(this.trade_SelectedIndexChanged);
            // 
            // rank
            // 
            this.rank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rank.FormattingEnabled = true;
            this.rank.Items.AddRange(new object[] {
            "Deputy Commandant",
            "Assistant Commandant",
            "Inspector",
            "Sub Inspector",
            "Assistant Sub-Inspector",
            "Havildar Major",
            "Head Constable",
            "Constable"});
            this.rank.Location = new System.Drawing.Point(176, 610);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(164, 24);
            this.rank.TabIndex = 18;
            this.rank.SelectedIndexChanged += new System.EventHandler(this.rank_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Trade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 665);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Pay Grade";
            // 
            // paygrade
            // 
            this.paygrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paygrade.FormattingEnabled = true;
            this.paygrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.paygrade.Location = new System.Drawing.Point(176, 662);
            this.paygrade.Name = "paygrade";
            this.paygrade.Size = new System.Drawing.Size(91, 24);
            this.paygrade.TabIndex = 21;
            this.paygrade.SelectedIndexChanged += new System.EventHandler(this.paygrade_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(180, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(372, 32);
            this.label12.TabIndex = 22;
            this.label12.Text = "OFFICIAL INFORMATION";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(168, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(391, 32);
            this.label13.TabIndex = 23;
            this.label13.Text = "PERSONAL INFORMATION";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(284, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(351, 26);
            this.label14.TabIndex = 25;
            this.label14.Text = "Personnel Data Entry Portal";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Upload a photo";
            this.toolTip1.SetToolTip(this.button1, "Upload your recent photo - should be PNG or JPEG/JPG");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(72, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Force Number";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // forceno
            // 
            this.forceno.Location = new System.Drawing.Point(176, 516);
            this.forceno.Name = "forceno";
            this.forceno.Size = new System.Drawing.Size(415, 22);
            this.forceno.TabIndex = 29;
            this.forceno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(445, 702);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(328, 71);
            this.button3.TabIndex = 32;
            this.button3.Text = "Click here to submit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // address_rtb
            // 
            this.address_rtb.Location = new System.Drawing.Point(176, 308);
            this.address_rtb.Name = "address_rtb";
            this.address_rtb.Size = new System.Drawing.Size(376, 96);
            this.address_rtb.TabIndex = 33;
            this.address_rtb.Text = "New Town\nSample City\nDist. - Sample\nMadhya Pradesh - 9999\t";
            this.address_rtb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(612, 408);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(161, 23);
            this.progressBar1.TabIndex = 34;
            this.toolTip1.SetToolTip(this.progressBar1, "Progress of the form");
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(27, 733);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 40);
            this.button2.TabIndex = 35;
            this.button2.Text = "Save to text";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(612, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 167);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::BMS.Properties.Resources.label;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // add_pd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(819, 801);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.address_rtb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.forceno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.paygrade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.trade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gender_cb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_pd";
            this.Text = "Add new personnel data";
            this.Load += new System.EventHandler(this.add_pd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker doj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox trade;
        private System.Windows.Forms.ComboBox rank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox paygrade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox forceno;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox address_rtb;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}