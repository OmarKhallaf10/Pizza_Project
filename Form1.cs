using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float CalculateToppingsPrice()
        {
            float toppingsTotalPrice = 0;

            if(chbExtraChees.Checked) 
            {
                toppingsTotalPrice += Convert.ToSingle(chbExtraChees.Tag);
            }

            if (chbGreenPapper.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chbGreenPapper.Tag);
            }

            if (chbMashroom.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chbMashroom.Tag);
            }

            if (chbOlives.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chbOlives.Tag);
            }

            if (chbOnion.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chbOnion.Tag);
            }

            if (chbTomatos.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chbTomatos.Tag);
            }


            return toppingsTotalPrice;
        }

        float GetSelectedSizePrice()
        {
            if (rdSmall.Checked)
                return Convert.ToSingle(rdSmall.Tag);
            else if (rdMidum.Checked)
                return Convert.ToSingle(rdMidum.Tag);
            else  
                return Convert.ToSingle(rdLarge.Tag);
        }

        float GetSelectedCrustPrice()
        {
            if (rdThick.Checked)
                return Convert.ToSingle(rdThick.Tag);
            else
                return Convert.ToSingle(rdThin.Tag);
         }

        float Calculate_Total_Price()
        {
            

            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();

        }

        void UpdateTotalPrice() 
        { 
            lblPrice.Text = "$" + Calculate_Total_Price().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rdSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rdMidum.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rdLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rdThick.Checked)
            {
                lblCrust.Text = "Thick Crust";
                return;
            }

            if (rdThin.Checked)
            {
                lblCrust.Text = "Thin Crust";
                return;
            }

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        void ResetForm()
        {
            //reset Groups
            gpPizzSize.Enabled = true;
            gbToppings.Enabled = true;
            gpCrustSize.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rdSmall.Checked = true;

            //reset Toppings.
            chbExtraChees.Checked = false;
            chbOnion.Checked = false;
            chbMashroom.Checked = false;
            chbOlives.Checked = false;
            chbTomatos.Checked = false;
            chbGreenPapper.Checked = false;

            //reset CrustType
            rdThin.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrder.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdMidum_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Orded", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrder.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                gpCrustSize.Enabled = false;
                gpPizzSize.Enabled = false;

            }

            else
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWehreToEat.Text = "Eat In";
            }


            if (rbTakeOut.Checked)
            {
                lblWehreToEat.Text = "take Out";
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chbExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chbOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chbMashroom.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chbOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chbTomatos.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chbGreenPapper.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbMashroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbGreenPapper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void gpPizzSize_Enter(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
