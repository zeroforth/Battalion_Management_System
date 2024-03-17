namespace BMS
{
    partial class update_qm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_qm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manufac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.cic_forceno = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.TextBox();
            this.sic_forceno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.label;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1095, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(413, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update QM Inventory";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(730, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 20);
            this.label13.TabIndex = 126;
            this.label13.Text = "Unit of Storage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(533, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 125;
            this.label11.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(101, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 123;
            this.label10.Text = "Added to";
            // 
            // unit
            // 
            this.unit.FormattingEnabled = true;
            this.unit.Items.AddRange(new object[] {
            "Units",
            "Pieces",
            "Ltr ",
            "ML",
            "KG",
            "GM",
            "TONNES",
            "Sq.FT",
            "FT",
            "INCH",
            "CM"});
            this.unit.Location = new System.Drawing.Point(897, 374);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(107, 24);
            this.unit.TabIndex = 119;
            this.unit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(586, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 118;
            this.label6.Text = " ";
            // 
            // manufac
            // 
            this.manufac.Location = new System.Drawing.Point(224, 322);
            this.manufac.Name = "manufac";
            this.manufac.Size = new System.Drawing.Size(316, 22);
            this.manufac.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 116;
            this.label5.Text = "Inventory Type";
            // 
            // type
            // 
            this.type.Controls.Add(this.radioButton2);
            this.type.Controls.Add(this.radioButton1);
            this.type.Location = new System.Drawing.Point(224, 365);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(288, 33);
            this.type.TabIndex = 115;
            this.type.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(148, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non Electronic";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Electronic";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-mm-dd";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(772, 320);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(232, 22);
            this.date.TabIndex = 114;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(574, 648);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(430, 51);
            this.button2.TabIndex = 112;
            this.button2.Text = "Update to log";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Furniture",
            "Decoration",
            "Electronics",
            "Electricals",
            "Construction",
            "Access",
            "Mobility",
            "Medical",
            "Chemical",
            "PPE",
            "Uniforms",
            "KIT"});
            this.category.Location = new System.Drawing.Point(665, 263);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(339, 24);
            this.category.TabIndex = 110;
            // 
            // cic_forceno
            // 
            this.cic_forceno.AutoSize = true;
            this.cic_forceno.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cic_forceno.Location = new System.Drawing.Point(31, 484);
            this.cic_forceno.Name = "cic_forceno";
            this.cic_forceno.Size = new System.Drawing.Size(231, 20);
            this.cic_forceno.TabIndex = 109;
            this.cic_forceno.Text = "Summary of pre-damage";
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(320, 484);
            this.summary.Multiline = true;
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(684, 68);
            this.summary.TabIndex = 108;
            // 
            // sic_forceno
            // 
            this.sic_forceno.AutoSize = true;
            this.sic_forceno.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sic_forceno.Location = new System.Drawing.Point(81, 322);
            this.sic_forceno.Name = "sic_forceno";
            this.sic_forceno.Size = new System.Drawing.Size(132, 20);
            this.sic_forceno.TabIndex = 107;
            this.sic_forceno.Text = "Manufacturer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(558, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 20);
            this.label8.TabIndex = 106;
            this.label8.Text = "Date of Procurement";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 105;
            this.label4.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(224, 265);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(316, 22);
            this.name.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Category";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(224, 217);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(316, 22);
            this.id.TabIndex = 102;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Inventory ID";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(627, 375);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(88, 22);
            this.quantity.TabIndex = 127;
            this.quantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(578, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 128;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 51);
            this.button1.TabIndex = 129;
            this.button1.Text = "Click to add new Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "QM Store 1 - Adm",
            "Warehouse 1A",
            "Warehouse 1B",
            "Warehouse 2A",
            "QM Store - Field",
            "Central Warehouse",
            "Workshop"});
            this.comboBox1.Location = new System.Drawing.Point(224, 425);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 24);
            this.comboBox1.TabIndex = 130;
            // 
            // update_qm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 726);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.manufac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.category);
            this.Controls.Add(this.cic_forceno);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.sic_forceno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_qm";
            this.Text = "Update QM Store";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox unit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox manufac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label cic_forceno;
        private System.Windows.Forms.TextBox summary;
        private System.Windows.Forms.Label sic_forceno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}