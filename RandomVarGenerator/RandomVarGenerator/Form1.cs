using GeneradorDeNumerosAleatorios;
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
        public List<decimal> generatedList = new List<decimal>();

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

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            // ====================
            // Agregar validaciones
            //=====================

            int quantity = Convert.ToInt32(this.txtQuantity.Text);
            int subInt = Convert.ToInt32(this.cmbIntervalsQuantity.Text);
            int a = Convert.ToInt32(this.txtInput1.Text);
            int b = Convert.ToInt32(this.txtInput2.Text);

            if ((string)this.cmbDistribution.SelectedItem == "Uniforme")
            {
                UniformGenerator uniformGenerator = new UniformGenerator() { a=a, b=b };
                
                StringBuilder numbersList = new StringBuilder();

                for (int i = 0; i < quantity; i++)
                {
                    decimal rnd = uniformGenerator.Generate();
                    rnd = (Math.Truncate(rnd * 10000) / 10000);
                    generatedList.Add(rnd);
                    numbersList.Append((i + 1) + ")\t" + rnd + Environment.NewLine);
                }

                this.txtGeneratedList.Text = numbersList.ToString();
            }

            ChiCuadrado chi2 = new ChiCuadrado();
            Intervalo[] intervals = new Intervalo[subInt];
            intervals = chi2.getFrequencies(generatedList, subInt);
            GenerateGraphicAndChiTable(intervals);
        }


        private void GenerateGraphicAndChiTable(Intervalo[] intervals)
        {
            this.chartFreq.Series["Freq observada"].Points.Clear();
            foreach (Intervalo interval in intervals)
            {
                string intervalStr = interval.ToString();
                // Agrego points de grafico de frecuencia observada
                this.chartFreq.Series["Freq observada"].Points.AddXY(
                    intervalStr,
                    interval.contador
                    );
            }
        }
    }
}
