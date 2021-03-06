﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public int counter { get; set; } = 1;
        public Form1()
        {
            InitializeComponent();
            BenzinUmumTextBox.Font = new Font("Calibri", 20);
            KafeUmuniTextBox.Font = new Font("Calibri", 20);
            UmumiTextBox.Font = new Font("Calibri", 20);
            LitrTextBox.Enabled = false;
         QiymetTextBox.Enabled = false;
            HotDoqSayTB.Enabled = false;
            HamburgerSayTB.Enabled = false;
            KartofSayTB.Enabled = false;
            KolaSayTB.Enabled = false;
            HotdoqQiymetTB.Text = "4.00";
            HamburgerQitmetTB.Text = "5.40";
            KartofQiymetTB.Text = "7.20";
            KolaQiymetTB.Text = "1.00";
            
        }

        private void LitrRB_CheckedChanged(object sender, EventArgs e)
        {
           if(LitrRB.Checked)
            {
                LitrTextBox.Enabled = true;
            }
            else
            {
                LitrTextBox.Enabled = false;
                LitrTextBox.Text = string.Empty;
                BenzinUmumTextBox.Text = string.Empty;
            }
        }

        private void QiymetRB_CheckedChanged(object sender, EventArgs e)
        {
            if(QiymetRB.Checked)
            {
                QiymetTextBox.Enabled = true;
            }
            else
            {
                QiymetTextBox.Enabled = false;
                LitrTextBox.Text = string.Empty;
                BenzinUmumTextBox.Text = string.Empty;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (HotdoqCB.Checked)
            {
                
                HotDoqSayTB.Enabled = true;
            }
            else
            {
                if(KafeUmuniTextBox.Text!=string.Empty)
                {
                    double q = Convert.ToDouble(4.00 * Convert.ToDouble(HotDoqSayTB.Text));
                    KafeUmuniTextBox.Text =Convert.ToString( Convert.ToDouble(KafeUmuniTextBox.Text) - q);
                }
                HotDoqSayTB.Text = string.Empty;
                HotDoqSayTB.Enabled = false;
                
            }
        }

        private void HamburgerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (HamburgerCB.Checked)
            {
                HamburgerSayTB.Enabled = true;
            }
            else
            {
                if (KafeUmuniTextBox.Text != string.Empty)
                {
                    double q =Convert.ToDouble( 5.40 * Convert.ToDouble(HamburgerSayTB.Text));
                    KafeUmuniTextBox.Text = Convert.ToString(Convert.ToDouble(KafeUmuniTextBox.Text) - q);
                }
                HamburgerSayTB.Text = string.Empty;
                HamburgerSayTB.Enabled = false;

            }
        }

        private void KartofCB_CheckedChanged(object sender, EventArgs e)
        {
            if (KartofCB.Checked)
            {
                KartofSayTB.Enabled = true;
            }
            else
            {
                if (KartofSayTB.Text != string.Empty)
                {
                    KafeUmuniTextBox.Text = Convert.ToString(Convert.ToDouble(KafeUmuniTextBox.Text) - 7.20 * Convert.ToDouble(KartofSayTB.Text));
                }
                KartofSayTB.Text = string.Empty;
                KartofSayTB.Enabled = false;
            }
        }

        private void KolaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (KolaCB.Checked)
            {
                KolaSayTB.Enabled = true;
            }
            else
            {
                if (KafeUmuniTextBox.Text != string.Empty)
                {
                    double q = Convert.ToDouble(1.00) * Convert.ToDouble(KolaSayTB.Text);
                    KafeUmuniTextBox.Text = Convert.ToString(Convert.ToDouble(KafeUmuniTextBox.Text) - q);
                }
                KolaSayTB.Text = string.Empty;
                KolaSayTB.Enabled = false;

            }
        }

        private void Benzin_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (Benzin.Text)
            {

                case "A-92":
                    if (LitrTextBox.Text != string.Empty )
                    {
                        BenzinUmumTextBox.Text = Convert.ToString(0.90 * (Convert.ToDouble(LitrTextBox.Text)));

                    }
                    BenzinQiymeyTextBox.Text = "0,90";
                    break;

                case "A-95":
                    if (LitrTextBox.Text != string.Empty)
                    {
                        BenzinUmumTextBox.Text = Convert.ToString(1.50 * (Convert.ToDouble(LitrTextBox.Text)));

                    }
                    BenzinQiymeyTextBox.Text = "1.50";
                    break;
                case "A-98":
                    if (LitrTextBox.Text != string.Empty)
                    {
                        BenzinUmumTextBox.Text = Convert.ToString(1.60 * (Convert.ToDouble(LitrTextBox.Text)));

                    }
                    BenzinQiymeyTextBox.Text = "1,60";
                    break;
                case "Dizel":
                    if (LitrTextBox.Text != string.Empty)
                    {
                        BenzinUmumTextBox.Text = Convert.ToString(0.60 * (Convert.ToDouble(LitrTextBox.Text)));

                    }
                    BenzinQiymeyTextBox.Text = "60";
                    break;

            }

        }

        private void LitrTextBox_TextChanged(object sender, EventArgs e)
        {
            double b;

            bool a = double.TryParse(LitrTextBox.Text, out b);
            bool q=Int32.TryParse(LitrTextBox.Text,out)
            if ( a & q>0)
            {
                switch (Benzin.Text)
                {

                    case "A-92":

                        BenzinUmumTextBox.Text = Convert.ToString(0.90 * (Convert.ToDouble(LitrTextBox.Text)));
                        break;

                    case "A-95":
                        BenzinUmumTextBox.Text = Convert.ToString(1.50 * (Convert.ToDouble(LitrTextBox.Text)));
                        break;
                    case "A-98":

                        BenzinUmumTextBox.Text = Convert.ToString(1.60 * (Convert.ToDouble(LitrTextBox.Text)));

                        break;
                    case "Dizel":
                        BenzinUmumTextBox.Text = Convert.ToString(0.60 * (Convert.ToDouble(LitrTextBox.Text)));

                        break;

                }
            }
            else
            {
                LitrTextBox.Text = string.Empty;
            }
        }

        private void BenzinUmumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void QiymetTextBox_TextChanged(object sender, EventArgs e)
        {
            double b;

            bool a = double.TryParse(BenzinQiymeyTextBox.Text, out b);
            int B = Convert.ToInt32(BenzinQiymeyTextBox.Text);
            if (a & b>0)
            {


                BenzinUmumTextBox.Text = QiymetTextBox.Text;
            }
        }
        private void HotDoqSayTB_TextChanged(object sender, EventArgs e)
        {
            int b;
           
            bool a = Int32.TryParse(HotDoqSayTB.Text, out b);
            
            if (a | Convert.ToInt32( HotDoqSayTB.Text)>0)
            {
                
                if (HamburgerCB.Checked | KartofCB.Checked | KolaCB.Checked)
                {
                    
                    KafeUmuniTextBox.Text = Convert.ToString(4.00 * Convert.ToDouble(HotDoqSayTB.Text)+Convert.ToDouble(KafeUmuniTextBox.Text));

                }
                else
                {
                    KafeUmuniTextBox.Text = Convert.ToString(4.00 * Convert.ToDouble(HotDoqSayTB.Text));

                }
            }
            else
            {
                HotDoqSayTB.Text = string.Empty;
            }
        }

        private void HamburgerSayTB_TextChanged(object sender, EventArgs e)
        {
            int b;
            bool a = Int32.TryParse(HamburgerSayTB.Text, out b);
            if (a | Convert.ToInt32(HamburgerSayTB.Text)>0)
            {
                if (HotdoqCB.Checked | KartofCB.Checked | KolaCB.Checked)
                {


                    KafeUmuniTextBox.Text = Convert.ToString(5.40 * Convert.ToDouble(HamburgerSayTB.Text)+Convert.ToDouble(KafeUmuniTextBox.Text));
                }
                else
                {
                    KafeUmuniTextBox.Text = Convert.ToString(5.40 * Convert.ToDouble(HamburgerSayTB.Text));

                }
                {

                }
	{
                        
                }
            }
            else
            {
                HamburgerSayTB.Text = string.Empty;
            }
        }

        private void KartofSayTB_TextChanged(object sender, EventArgs e)
        {
            int b;
            bool a = Int32.TryParse(KartofSayTB.Text, out b);
            if (a | Convert.ToInt32(KartofSayTB.Text)>0 )
            {
                if (HotdoqCB.Checked | HamburgerCB.Checked | KolaCB.Checked)
                {


                    KafeUmuniTextBox.Text = Convert.ToString(7.20 * Convert.ToDouble(KartofSayTB.Text)+Convert.ToDouble(KafeUmuniTextBox.Text));
                }
                else
                {
                    KafeUmuniTextBox.Text = Convert.ToString(7.20 * Convert.ToDouble(KartofSayTB.Text));

                }
            }
            else
            {
                KartofSayTB.Text = string.Empty;
            }
        }

        private void KolaSayTB_TextChanged(object sender, EventArgs e)
        {
            int b;
            bool a = Int32.TryParse(KolaSayTB.Text, out b);
            if (a | Convert.ToInt32(KolaSayTB)>0)
            {
                if (HamburgerCB.Checked | HotdoqCB.Checked | KartofCB.Checked)
                {


                    KafeUmuniTextBox.Text = Convert.ToString(1.00 * Convert.ToDouble(KolaSayTB.Text) + Convert.ToDouble(KafeUmuniTextBox.Text));
                }
                else
                {
                    KafeUmuniTextBox.Text = Convert.ToString(1.00 * Convert.ToDouble(KolaSayTB.Text));

                }
            }
            else
            {
                KolaSayTB.Text = string.Empty;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            OilCafe oilCafe = new OilCafe();
            if (HotdoqCB.Checked)
            {
                oilCafe.Hotdoq = HotdoqCB.Text;
                oilCafe.HotdoqQiymeti = HotdoqQiymetTB.Text;
                oilCafe.HotdoqSay = HotDoqSayTB.Text;
            }
            if (HamburgerCB.Checked)
            {
                oilCafe.Hamburger = HamburgerCB.Text;
                oilCafe.HamburgerQiymet = HamburgerQitmetTB.Text;
                oilCafe.HamburgerSay = HamburgerSayTB.Text;
            }
            if (KartofCB.Checked)
            {
                oilCafe.Kartof = KartofCB.Text;
                oilCafe.KartofQiymet = KartofQiymetTB.Text;
                oilCafe.KartofSay = KartofSayTB.Text;
            }

            if (KolaCB.Checked)
            {
                oilCafe.Kartof = KartofCB.Text;
                oilCafe.KolaQiymet = KolaQiymetTB.Text;
                oilCafe.KolaSay = KolaSayTB.Text;

            }
            if (Benzin.Text != string.Empty & BenzinUmumTextBox.Text != string.Empty)
            {
                oilCafe.Benzin = Benzin.Text;
                oilCafe.BenzinQiymet = BenzinUmumTextBox.Text;

            }
            if (BenzinUmumTextBox.Text == string.Empty & KafeUmuniTextBox.Text != string.Empty)
            {
                UmumiTextBox.Text = KafeUmuniTextBox.Text;

            }
            if (BenzinUmumTextBox.Text != string.Empty & KafeUmuniTextBox.Text == string.Empty)
            {
                UmumiTextBox.Text = BenzinUmumTextBox.Text;
            }
            if (BenzinUmumTextBox.Text != string.Empty & KafeUmuniTextBox.Text != string.Empty)
            {

                UmumiTextBox.Text = Convert.ToString(Convert.ToDouble(BenzinUmumTextBox.Text) + Convert.ToDouble(KafeUmuniTextBox.Text)).ToString();
            }
            oilCafe.UmumiQiymet = UmumiTextBox.Text;
            string json = JsonConvert.SerializeObject(oilCafe);
            System.IO.File.WriteAllText($"Cek{counter++}.json", json);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    class OilCafe
    {
       
        public string Hotdoq { get; set; }
        public string HotdoqQiymeti { get; set; }
        public string HotdoqSay { get; set; }
        public string Hamburger { get; set; }
        public string HamburgerQiymet { get; set; }
        public string HamburgerSay { get; set; }
        public string Kartof { get; set; }
        public string KartofQiymet { get; set; }
        public string KartofSay { get; set; }
        public string Kola { get; set; }
        public string KolaQiymet { get; set; }
        public string KolaSay { get; set; }
        public string Benzin { get; set; }
        public string BenzinQiymet { get; set; }
        public string UmumiQiymet { get; set; }

    }
}
