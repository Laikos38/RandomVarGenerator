using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomVarGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cmbDistribution.SelectedIndex = 0;
            this.cmbIntervalsQuantity.SelectedIndex = 0;
        }

        // Metodo para permitir solo el ingreso de numeros en los textInputs
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbDistribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbDistribution.SelectedIndex == 0)
            {
                this.lblInput1.Text = "A:";
                this.lblInput2.Text = "B:";
                this.txtInput1.Enabled = true;
                this.txtInput2.Enabled = true;
                this.txtLambda.Enabled = false;
            }
            else if (this.cmbDistribution.SelectedIndex == 1 || this.cmbDistribution.SelectedIndex == 2)
            {
                this.lblInput1.Text = "A:";
                this.lblInput2.Text = "B:";
                this.txtInput1.Enabled = false;
                this.txtInput2.Enabled = false;
                this.txtLambda.Enabled = true;
            }
            else if (this.cmbDistribution.SelectedIndex == 3)
            {
                this.lblInput1.Text = "Media:";
                this.lblInput2.Text = "Desviación";
                this.txtInput1.Enabled = true;
                this.txtInput2.Enabled = true;
                this.txtLambda.Enabled = false;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.txtQuantity.Text = "";
            this.txtGeneratedList.Text = "";
            this.txtInput1.Text = "";
            this.txtInput2.Text = "";
            this.txtLambda.Text = "";
            this.cmbDistribution.SelectedIndex = 0;
            this.cmbIntervalsQuantity.SelectedIndex = 0;
        }
    }
}
