using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalcIvaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            decimal basePrice;

            if (!decimal.TryParse(txtPrice.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out basePrice) || basePrice < 0)
            {
                MessageBox.Show("Por favor, introduce un precio válido (mayor o igual a 0).", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Por favor, introduce una cantidad válida (mínimo 1).", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal discountRate = 0.0m;
            if (chkPartner.Checked)
            {

                discountRate = 0.30m;
            }
            else
            {

                if (rbD5.Checked)
                    discountRate = 0.05m;
                else if (rbD10.Checked)
                    discountRate = 0.10m;
                else if (rbD20.Checked)
                    discountRate = 0.20m;
            }


            decimal ivaRate = 0.0m;
            if (rbIva4.Checked)
                ivaRate = 0.04m;
            else if (rbIva10.Checked)
                ivaRate = 0.10m;
            else if (rbIva21.Checked)
                ivaRate = 0.21m;

            decimal subTotal = basePrice * quantity;


            decimal discountAmount = subTotal * discountRate;
            decimal priceAfterDiscount = subTotal - discountAmount; 

            decimal ivaAmount = priceAfterDiscount * ivaRate;
            decimal finalPrice = priceAfterDiscount + ivaAmount;   


            txtNoIva.Text = priceAfterDiscount.ToString("N2");
            txtWithIva.Text = finalPrice.ToString("N2");
        }



        private void chkPartner_CheckedChanged(object sender, EventArgs e)
        {

            grpDiscount.Enabled = !chkPartner.Checked;
        }


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

            txtNoIva.Text = "";
            txtWithIva.Text = "";
        }



        private void label1_Click(object sender, EventArgs e) { }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter_1(object sender, EventArgs e) { }
        private void rbD0_CheckedChanged(object sender, EventArgs e) { }
        private void rbIva4_CheckedChanged(object sender, EventArgs e) { }
    }
}