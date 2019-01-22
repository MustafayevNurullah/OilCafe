namespace WindowsFormsApp6
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
            this.Benzin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BenzinQiymeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LitrRB = new System.Windows.Forms.RadioButton();
            this.QiymetRB = new System.Windows.Forms.RadioButton();
            this.LitrTextBox = new System.Windows.Forms.TextBox();
            this.QiymetTextBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.HotdoqCB = new System.Windows.Forms.CheckBox();
            this.HamburgerCB = new System.Windows.Forms.CheckBox();
            this.KartofCB = new System.Windows.Forms.CheckBox();
            this.KolaCB = new System.Windows.Forms.CheckBox();
            this.HamburgerQitmetTB = new System.Windows.Forms.TextBox();
            this.HamburgerSayTB = new System.Windows.Forms.TextBox();
            this.HotdoqQiymetTB = new System.Windows.Forms.TextBox();
            this.HotDoqSayTB = new System.Windows.Forms.TextBox();
            this.KolaQiymetTB = new System.Windows.Forms.TextBox();
            this.KolaSayTB = new System.Windows.Forms.TextBox();
            this.KartofQiymetTB = new System.Windows.Forms.TextBox();
            this.KartofSayTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KafeUmuniTextBox = new System.Windows.Forms.TextBox();
            this.BenzinUmumTextBox = new System.Windows.Forms.TextBox();
            this.UmumiTextBox = new System.Windows.Forms.TextBox();
            this.Socar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KafeCem = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cem = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Socar.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.KafeCem.SuspendLayout();
            this.Cem.SuspendLayout();
            this.SuspendLayout();
            // 
            // Benzin
            // 
            this.Benzin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Benzin.FormattingEnabled = true;
            this.Benzin.Items.AddRange(new object[] {
            "A-92",
            "A-95",
            "A-98",
            "Dizel"});
            this.Benzin.Location = new System.Drawing.Point(97, 20);
            this.Benzin.Name = "Benzin";
            this.Benzin.Size = new System.Drawing.Size(121, 21);
            this.Benzin.TabIndex = 0;
            this.Benzin.SelectedIndexChanged += new System.EventHandler(this.Benzin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benzin";
            // 
            // BenzinQiymeyTextBox
            // 
            this.BenzinQiymeyTextBox.Location = new System.Drawing.Point(97, 66);
            this.BenzinQiymeyTextBox.Name = "BenzinQiymeyTextBox";
            this.BenzinQiymeyTextBox.ReadOnly = true;
            this.BenzinQiymeyTextBox.Size = new System.Drawing.Size(121, 20);
            this.BenzinQiymeyTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qiymet";
            // 
            // LitrRB
            // 
            this.LitrRB.AutoSize = true;
            this.LitrRB.Location = new System.Drawing.Point(6, 19);
            this.LitrRB.Name = "LitrRB";
            this.LitrRB.Size = new System.Drawing.Size(39, 17);
            this.LitrRB.TabIndex = 4;
            this.LitrRB.TabStop = true;
            this.LitrRB.Text = "Litr";
            this.LitrRB.UseVisualStyleBackColor = true;
            this.LitrRB.CheckedChanged += new System.EventHandler(this.LitrRB_CheckedChanged);
            // 
            // QiymetRB
            // 
            this.QiymetRB.AutoSize = true;
            this.QiymetRB.Location = new System.Drawing.Point(6, 44);
            this.QiymetRB.Name = "QiymetRB";
            this.QiymetRB.Size = new System.Drawing.Size(57, 17);
            this.QiymetRB.TabIndex = 5;
            this.QiymetRB.TabStop = true;
            this.QiymetRB.Text = "Qiymet";
            this.QiymetRB.UseVisualStyleBackColor = true;
            this.QiymetRB.CheckedChanged += new System.EventHandler(this.QiymetRB_CheckedChanged);
            // 
            // LitrTextBox
            // 
            this.LitrTextBox.Location = new System.Drawing.Point(97, 120);
            this.LitrTextBox.Name = "LitrTextBox";
            this.LitrTextBox.Size = new System.Drawing.Size(121, 20);
            this.LitrTextBox.TabIndex = 6;
            this.LitrTextBox.TextChanged += new System.EventHandler(this.LitrTextBox_TextChanged);
            // 
            // QiymetTextBox
            // 
            this.QiymetTextBox.Location = new System.Drawing.Point(97, 148);
            this.QiymetTextBox.Name = "QiymetTextBox";
            this.QiymetTextBox.Size = new System.Drawing.Size(121, 20);
            this.QiymetTextBox.TabIndex = 7;
            this.QiymetTextBox.TextChanged += new System.EventHandler(this.QiymetTextBox_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(97, 64);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(121, 39);
            this.OK.TabIndex = 9;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // HotdoqCB
            // 
            this.HotdoqCB.AutoSize = true;
            this.HotdoqCB.Location = new System.Drawing.Point(21, 24);
            this.HotdoqCB.Name = "HotdoqCB";
            this.HotdoqCB.Size = new System.Drawing.Size(61, 17);
            this.HotdoqCB.TabIndex = 10;
            this.HotdoqCB.Text = "Hotdoq";
            this.HotdoqCB.UseVisualStyleBackColor = true;
            this.HotdoqCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // HamburgerCB
            // 
            this.HamburgerCB.AutoSize = true;
            this.HamburgerCB.Location = new System.Drawing.Point(21, 65);
            this.HamburgerCB.Name = "HamburgerCB";
            this.HamburgerCB.Size = new System.Drawing.Size(78, 17);
            this.HamburgerCB.TabIndex = 11;
            this.HamburgerCB.Text = "Hamburger";
            this.HamburgerCB.UseVisualStyleBackColor = true;
            this.HamburgerCB.CheckedChanged += new System.EventHandler(this.HamburgerCB_CheckedChanged);
            // 
            // KartofCB
            // 
            this.KartofCB.AutoSize = true;
            this.KartofCB.Location = new System.Drawing.Point(21, 101);
            this.KartofCB.Name = "KartofCB";
            this.KartofCB.Size = new System.Drawing.Size(78, 17);
            this.KartofCB.TabIndex = 12;
            this.KartofCB.Text = "Kartof-Free";
            this.KartofCB.UseVisualStyleBackColor = true;
            this.KartofCB.CheckedChanged += new System.EventHandler(this.KartofCB_CheckedChanged);
            // 
            // KolaCB
            // 
            this.KolaCB.AutoSize = true;
            this.KolaCB.Location = new System.Drawing.Point(21, 139);
            this.KolaCB.Name = "KolaCB";
            this.KolaCB.Size = new System.Drawing.Size(47, 17);
            this.KolaCB.TabIndex = 13;
            this.KolaCB.Text = "Kola";
            this.KolaCB.UseVisualStyleBackColor = true;
            this.KolaCB.CheckedChanged += new System.EventHandler(this.KolaCB_CheckedChanged);
            // 
            // HamburgerQitmetTB
            // 
            this.HamburgerQitmetTB.Location = new System.Drawing.Point(138, 66);
            this.HamburgerQitmetTB.Name = "HamburgerQitmetTB";
            this.HamburgerQitmetTB.ReadOnly = true;
            this.HamburgerQitmetTB.Size = new System.Drawing.Size(100, 20);
            this.HamburgerQitmetTB.TabIndex = 14;
            // 
            // HamburgerSayTB
            // 
            this.HamburgerSayTB.Location = new System.Drawing.Point(303, 63);
            this.HamburgerSayTB.Name = "HamburgerSayTB";
            this.HamburgerSayTB.Size = new System.Drawing.Size(100, 20);
            this.HamburgerSayTB.TabIndex = 14;
            this.HamburgerSayTB.TextChanged += new System.EventHandler(this.HamburgerSayTB_TextChanged);
            // 
            // HotdoqQiymetTB
            // 
            this.HotdoqQiymetTB.Location = new System.Drawing.Point(138, 24);
            this.HotdoqQiymetTB.Name = "HotdoqQiymetTB";
            this.HotdoqQiymetTB.ReadOnly = true;
            this.HotdoqQiymetTB.Size = new System.Drawing.Size(100, 20);
            this.HotdoqQiymetTB.TabIndex = 14;
            // 
            // HotDoqSayTB
            // 
            this.HotDoqSayTB.Location = new System.Drawing.Point(303, 24);
            this.HotDoqSayTB.Name = "HotDoqSayTB";
            this.HotDoqSayTB.Size = new System.Drawing.Size(100, 20);
            this.HotDoqSayTB.TabIndex = 14;
            this.HotDoqSayTB.TextChanged += new System.EventHandler(this.HotDoqSayTB_TextChanged);
            // 
            // KolaQiymetTB
            // 
            this.KolaQiymetTB.Location = new System.Drawing.Point(138, 145);
            this.KolaQiymetTB.Name = "KolaQiymetTB";
            this.KolaQiymetTB.ReadOnly = true;
            this.KolaQiymetTB.Size = new System.Drawing.Size(100, 20);
            this.KolaQiymetTB.TabIndex = 14;
            // 
            // KolaSayTB
            // 
            this.KolaSayTB.Location = new System.Drawing.Point(303, 147);
            this.KolaSayTB.Name = "KolaSayTB";
            this.KolaSayTB.Size = new System.Drawing.Size(100, 20);
            this.KolaSayTB.TabIndex = 14;
            this.KolaSayTB.TextChanged += new System.EventHandler(this.KolaSayTB_TextChanged);
            // 
            // KartofQiymetTB
            // 
            this.KartofQiymetTB.Location = new System.Drawing.Point(138, 104);
            this.KartofQiymetTB.Name = "KartofQiymetTB";
            this.KartofQiymetTB.ReadOnly = true;
            this.KartofQiymetTB.Size = new System.Drawing.Size(100, 20);
            this.KartofQiymetTB.TabIndex = 14;
            // 
            // KartofSayTB
            // 
            this.KartofSayTB.Location = new System.Drawing.Point(303, 104);
            this.KartofSayTB.Name = "KartofSayTB";
            this.KartofSayTB.Size = new System.Drawing.Size(100, 20);
            this.KartofSayTB.TabIndex = 14;
            this.KartofSayTB.TextChanged += new System.EventHandler(this.KartofSayTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Qiymet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Say";
            // 
            // KafeUmuniTextBox
            // 
            this.KafeUmuniTextBox.Location = new System.Drawing.Point(36, 43);
            this.KafeUmuniTextBox.Multiline = true;
            this.KafeUmuniTextBox.Name = "KafeUmuniTextBox";
            this.KafeUmuniTextBox.ReadOnly = true;
            this.KafeUmuniTextBox.Size = new System.Drawing.Size(130, 44);
            this.KafeUmuniTextBox.TabIndex = 17;
            // 
            // BenzinUmumTextBox
            // 
            this.BenzinUmumTextBox.Location = new System.Drawing.Point(123, 19);
            this.BenzinUmumTextBox.Multiline = true;
            this.BenzinUmumTextBox.Name = "BenzinUmumTextBox";
            this.BenzinUmumTextBox.ReadOnly = true;
            this.BenzinUmumTextBox.Size = new System.Drawing.Size(211, 50);
            this.BenzinUmumTextBox.TabIndex = 8;
            this.BenzinUmumTextBox.TextChanged += new System.EventHandler(this.BenzinUmumTextBox_TextChanged);
            // 
            // UmumiTextBox
            // 
            this.UmumiTextBox.Location = new System.Drawing.Point(437, 83);
            this.UmumiTextBox.Name = "UmumiTextBox";
            this.UmumiTextBox.ReadOnly = true;
            this.UmumiTextBox.Size = new System.Drawing.Size(100, 20);
            this.UmumiTextBox.TabIndex = 17;
            // 
            // Socar
            // 
            this.Socar.Controls.Add(this.label6);
            this.Socar.Controls.Add(this.label5);
            this.Socar.Controls.Add(this.groupBox6);
            this.Socar.Controls.Add(this.groupBox5);
            this.Socar.Controls.Add(this.label1);
            this.Socar.Controls.Add(this.Benzin);
            this.Socar.Controls.Add(this.label2);
            this.Socar.Controls.Add(this.BenzinQiymeyTextBox);
            this.Socar.Controls.Add(this.LitrTextBox);
            this.Socar.Controls.Add(this.QiymetTextBox);
            this.Socar.Location = new System.Drawing.Point(6, 13);
            this.Socar.Name = "Socar";
            this.Socar.Size = new System.Drawing.Size(399, 306);
            this.Socar.TabIndex = 18;
            this.Socar.TabStop = false;
            this.Socar.Text = "Socar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Azn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Litr";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.BenzinUmumTextBox);
            this.groupBox6.Location = new System.Drawing.Point(18, 206);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 82);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SocarCem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Azn";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LitrRB);
            this.groupBox5.Controls.Add(this.QiymetRB);
            this.groupBox5.Location = new System.Drawing.Point(9, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(76, 82);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KafeCem);
            this.groupBox2.Controls.Add(this.HotdoqCB);
            this.groupBox2.Controls.Add(this.HamburgerCB);
            this.groupBox2.Controls.Add(this.KartofCB);
            this.groupBox2.Controls.Add(this.KolaCB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.KolaSayTB);
            this.groupBox2.Controls.Add(this.KartofSayTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.HotdoqQiymetTB);
            this.groupBox2.Controls.Add(this.HamburgerSayTB);
            this.groupBox2.Controls.Add(this.HotDoqSayTB);
            this.groupBox2.Controls.Add(this.HamburgerQitmetTB);
            this.groupBox2.Controls.Add(this.KartofQiymetTB);
            this.groupBox2.Controls.Add(this.KolaQiymetTB);
            this.groupBox2.Location = new System.Drawing.Point(411, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 306);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kafe";
            // 
            // KafeCem
            // 
            this.KafeCem.Controls.Add(this.label8);
            this.KafeCem.Controls.Add(this.KafeUmuniTextBox);
            this.KafeCem.Location = new System.Drawing.Point(21, 188);
            this.KafeCem.Name = "KafeCem";
            this.KafeCem.Size = new System.Drawing.Size(417, 100);
            this.KafeCem.TabIndex = 17;
            this.KafeCem.TabStop = false;
            this.KafeCem.Text = "KafeCem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Azn";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Cem
            // 
            this.Cem.Controls.Add(this.label9);
            this.Cem.Controls.Add(this.OK);
            this.Cem.Controls.Add(this.UmumiTextBox);
            this.Cem.Location = new System.Drawing.Point(6, 325);
            this.Cem.Name = "Cem";
            this.Cem.Size = new System.Drawing.Size(859, 149);
            this.Cem.TabIndex = 20;
            this.Cem.TabStop = false;
            this.Cem.Text = "UmumiCem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Azn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 517);
            this.Controls.Add(this.Cem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Socar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Socar.ResumeLayout(false);
            this.Socar.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.KafeCem.ResumeLayout(false);
            this.KafeCem.PerformLayout();
            this.Cem.ResumeLayout(false);
            this.Cem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Benzin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BenzinQiymeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton LitrRB;
        private System.Windows.Forms.RadioButton QiymetRB;
        private System.Windows.Forms.TextBox LitrTextBox;
        private System.Windows.Forms.TextBox QiymetTextBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.CheckBox HotdoqCB;
        private System.Windows.Forms.CheckBox HamburgerCB;
        private System.Windows.Forms.CheckBox KartofCB;
        private System.Windows.Forms.CheckBox KolaCB;
        private System.Windows.Forms.TextBox HamburgerQitmetTB;
        private System.Windows.Forms.TextBox HamburgerSayTB;
        private System.Windows.Forms.TextBox HotdoqQiymetTB;
        private System.Windows.Forms.TextBox HotDoqSayTB;
        private System.Windows.Forms.TextBox KolaQiymetTB;
        private System.Windows.Forms.TextBox KolaSayTB;
        private System.Windows.Forms.TextBox KartofQiymetTB;
        private System.Windows.Forms.TextBox KartofSayTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KafeUmuniTextBox;
        private System.Windows.Forms.TextBox BenzinUmumTextBox;
        private System.Windows.Forms.TextBox UmumiTextBox;
        private System.Windows.Forms.GroupBox Socar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox KafeCem;
        private System.Windows.Forms.GroupBox Cem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

