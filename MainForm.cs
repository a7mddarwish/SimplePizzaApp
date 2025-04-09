using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_APP
{
    public partial class MainForm : Form
    {
        int NumberOfPizza=1;
        public MainForm()
        {
            InitializeComponent();
        }

        // Calculate Monyyyyyyyyyyyyy
         decimal GetSizePrice()
        {
            if (rbSizeSmall.Checked)
                return Convert.ToDecimal(rbSizeSmall.Tag);
            
            else if (rbSizeMed.Checked)
                return Convert.ToDecimal(rbSizeMed.Tag);

            else
                return Convert.ToDecimal(rbSizeLarg.Tag);
        }
        decimal GetCrustPrice()
        {

            if (rbThickCrust.Checked)
                return (Convert.ToDecimal(rbThickCrust.Tag));
            else
                return (Convert.ToDecimal(rbThinCrust.Tag));
        }
        decimal GetToppingPrice ()
        {
            decimal TotalPrice = 00;


            if (ChBEx1.Checked)
                TotalPrice += Convert.ToDecimal(ChBEx1.Tag);

             if (ChbEx2.Checked)
                TotalPrice += Convert.ToDecimal(ChbEx2.Tag);

             if (ChbEx3.Checked)
                TotalPrice += Convert.ToDecimal(ChbEx3.Tag);

             if (ChbEx4.Checked)
                TotalPrice += Convert.ToDecimal(ChbEx4.Tag);
            
            if (ChbEx5.Checked)
                TotalPrice += Convert.ToDecimal(ChbEx5.Tag);
           
            if (ChbEx6.Checked)
                TotalPrice += Convert.ToDecimal(ChbEx6.Tag);


            return TotalPrice;

        }
        decimal GetSurvicesPrice ()
        {
            if (rbTakeAway.Checked)
                return 00;
            else
                return Convert.ToDecimal(rbyeseatHere.Tag);
        }
        decimal CalculateTotalPrice ()
        {
            return (GetSizePrice() + GetCrustPrice() + GetToppingPrice() + GetSurvicesPrice());
        }
        
        void RefreshPrice ()
        {
            
            LbTotalPrice.Text = "$" + (NumberOfPizza*CalculateTotalPrice());
        }


        //  Size Change
        void RefreahSize()
        {
            RefreshPrice();

            if (rbSizeSmall.Checked)
            {
                LbSizeSum.Text = "Size : Small";
              
            }
            else if (rbSizeMed.Checked)
            {
                LbSizeSum.Text = "Size : Medeium";
             
            }
            else
            {
                LbSizeSum.Text = "Size : Larg";
            }

        }
        private void rbSizeSmall_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreahSize();
        }
        private void rbSizeMed_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreahSize();

        }
        private void rbSizeLarg_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreahSize();
            
        }


        // Crust Change

        void RefrshCrust()
        {
            RefreshPrice();

            if (rbThickCrust.Checked)
            {
                LbcrustSum.Text = "Crust : Thick Crust";

            }
            else
            {
                LbcrustSum.Text = "Crust : Thin Crust";

            }
        }
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            RefrshCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            RefrshCrust();

        }


        // Survice Change
        
        void RefreshSurvices()
        {
            RefreshPrice();

            if (rbyeseatHere.Checked)
            {
                LbeatHere.Text = "Eat here  ? => Yes ";
            }
            else
                LbeatHere.Text = "Eat here  ? => Take away ";


        }

        private void rbyeseatHere_CheckedChanged(object sender, EventArgs e)
        {
            RefreshSurvices();
        }
        private void rbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            RefreshSurvices();

        }


        // Toppings Change 
        string GetToppings()
        {
            string v = "";

            if (ChBEx1.Checked) v += "Chees ";
            if (ChbEx2.Checked) v += ", Onion ";
            if (ChbEx4.Checked) v += ", Oliver ";
            if (ChbEx3.Checked) v += ", Green Paper ";
            if (ChbEx5.Checked) v += ", Mashruooms ";
            if (ChbEx6.Checked) v += ", Tomatous ";
           
            if (v[0] == ',')
            {
                return v.Substring(1);
            }
            return v ;
        }

        void RefreshToppings()
        {
            RefreshPrice();
            LbTopSum.Text = "Toppings : " + GetToppings();
        }
        private void ChBEx1_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreshToppings();
        }

        private void ChbEx2_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreshToppings();

        }

        private void ChbEx3_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreshToppings();

        }

        private void ChbEx4_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreshToppings();

        }

        private void ChbEx5_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreshToppings();

        }

        private void ChbEx6_CheckedChanged(object sender, System.EventArgs e)
        {
            RefreshToppings();

        }



        private void gbSize_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

          if (MessageBox.Show("Do you want to confirm order ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                MessageBox.Show("كللللللللللله تمااااااااااام ", "Message");

                gbcrust.Enabled = false;
                gbSize.Enabled = false;
                gbeatwhere.Enabled = false;
                gbToppings.Enabled = false;
                //gbSum.Visible = false;


            }

          else
                MessageBox.Show("Ok , Check again ", "Message");


        }


        // Reset All options 
        void ResetSize()
        {
            rbSizeLarg.Checked = false;
            rbSizeSmall.Checked = true;
            rbSizeMed.Checked = false;
        }
        void ResetToppings()
        {
            ChBEx1.Checked = false;
            ChbEx2.Checked = false;
            ChbEx3.Checked = false;
            ChbEx4.Checked = false;
            ChbEx5.Checked = false;
            ChbEx6.Checked = false;
        }
        void ResetCrust()
        {
            rbThickCrust.Checked = false;
            rbThinCrust.Checked = true;
        }
        void EatPlace ()
        {
            rbyeseatHere.Checked = true;
            rbTakeAway.Checked = false;

        }
        void ResetAll()
        {
            ResetSize();
            ResetToppings();
            ResetCrust();
            EatPlace();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gbcrust.Enabled = true;
            gbSize.Enabled = true;
            gbeatwhere.Enabled = true;
            gbToppings.Enabled = true;

            ResetAll();
        }

        private void gbSum_Enter(object sender, EventArgs e)
        {

        }

        private void LbTopSum_Click(object sender, EventArgs e)
        {

        }

        private void LbTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumberOfPizza = Convert.ToInt16( guna2NumericUpDown1.Value);
            RefreshPrice();
        }
    }

    
}
