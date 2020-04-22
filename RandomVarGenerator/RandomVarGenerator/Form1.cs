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
        public List<double> generatedList = new List<double>();

        public Form1()
        {
            InitializeComponent();
            this.cmbDistribution.SelectedIndex = 0;
            this.cmbIntervalsQuantity.SelectedIndex = 0;
        }

        // Metodo para permitir solo el ingreso de numeros positivos en los textInputs
        private void AllowPositiveIntegerNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Metodo para permitir solo el ingreso de numeros reales en los textInputs
        private void AllowNegativeIntegerNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
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
                this.txtInput1.Text = "";
                this.txtInput2.Text = "";
                this.txtLambda.Text = "";
                this.txtLambda.Enabled = false;
            }
            else if (this.cmbDistribution.SelectedIndex == 2 || this.cmbDistribution.SelectedIndex == 1)
            {
                this.lblInput1.Text = "A:";
                this.lblInput2.Text = "B:";
                this.txtInput1.Text = "";
                this.txtInput2.Text = "";
                this.txtLambda.Text = "";
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
                this.txtInput1.Text = "";
                this.txtInput2.Text = "";
                this.txtLambda.Text = "";
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
            this.chartFreq.Series["Freq observada"].Points.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
               return;

            generatedList.Clear();
            StringBuilder numbersList = new StringBuilder();
            int subInt = Convert.ToInt32(this.cmbIntervalsQuantity.Text);
            int quantity = Convert.ToInt32(this.txtQuantity.Text);

            if ((string)this.cmbDistribution.SelectedItem == "Uniforme")
            {
                int a = Convert.ToInt32(this.txtInput1.Text);
                int b = Convert.ToInt32(this.txtInput2.Text);

                UniformGenerator uniformGenerator = new UniformGenerator() { a = a, b = b };
                for (int i = 0; i < quantity; i++)
                {
                    double rnd = uniformGenerator.Generate();
                    rnd = (Math.Truncate(rnd * 10000) / 10000);
                    generatedList.Add(rnd);
                    numbersList.Append((i + 1) + ")\t" + rnd + Environment.NewLine);
                }
            }

            else if ((string)this.cmbDistribution.SelectedItem == "Exponencial")
            {
                double lambda = Convert.ToDouble(this.txtLambda.Text);
                ExponentialGenerator exponentialGenerator = new ExponentialGenerator() { lambda = lambda };
                for (int i = 0; i < quantity; i++)
                {
                    double expRnd = exponentialGenerator.Generate();
                    expRnd = (Math.Truncate(expRnd * 10000) / 10000);
                    generatedList.Add(expRnd);
                    numbersList.Append((i + 1) + ")\t" + expRnd + Environment.NewLine);
                }
            }
            else if ((string)this.cmbDistribution.SelectedItem == "Normal - Box Muller")
            {
                double mean = Convert.ToDouble(this.txtInput1.Text);
                double stDeviation = Convert.ToDouble(this.txtInput2.Text);
                BoxMullerGenerator boxMullerGenerator = new BoxMullerGenerator() { mean=mean, stDeviation=stDeviation };
                for (int i = 0; i < quantity; i++)
                {
                    double[] boxRnd = boxMullerGenerator.Generate();
                    if(i % 2 == 0)
                    {
                        boxRnd[0] = (Math.Truncate(boxRnd[0] * 10000) / 10000);
                        generatedList.Add(boxRnd[0]);
                        numbersList.Append((i + 1) + ")\t" + boxRnd[0] + Environment.NewLine);
                    }
                    else
                    {
                        boxRnd[1] = (Math.Truncate(boxRnd[1] * 10000) / 10000);
                        generatedList.Add(boxRnd[1]);
                        numbersList.Append((i + 1) + ")\t" + boxRnd[1] + Environment.NewLine);
                    }
                }
            }
            else if ((string)this.cmbDistribution.SelectedItem == "Poisson")
            {
                double lambda = Convert.ToDouble(this.txtLambda.Text);
                PoissonGenerator poissonGenerator = new PoissonGenerator() { lambda = lambda };
                for (int i = 0; i < quantity; i++)
                {
                    double expRnd = poissonGenerator.Generate();
                    generatedList.Add(expRnd);
                    numbersList.Append((i + 1) + ")\t" + expRnd + Environment.NewLine);
                }

            }


            this.txtGeneratedList.Text = numbersList.ToString();
            ChiCuadrado chi2 = new ChiCuadrado();
            Intervalo[] intervals = new Intervalo[subInt];
            intervals = chi2.getFrequencies(generatedList, subInt);
            GenerateGraphicAndChiTable(intervals);
        }

        private bool ValidateInputs()
        {
            if (String.IsNullOrEmpty(txtQuantity.Text) || txtQuantity.Text == "0")
            {
                MessageBox.Show("Error: Debe ingresar una cantidad correcta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            switch (this.cmbDistribution.Text)
            {
                case "Uniforme":
                    if (String.IsNullOrEmpty(this.txtInput1.Text) || String.IsNullOrEmpty(this.txtInput2.Text))
                    {
                        MessageBox.Show("Error: Los campos A y B deben tener un valor correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (Convert.ToInt32(this.txtInput2.Text) < Convert.ToInt32(this.txtInput1.Text))
                    {
                        MessageBox.Show("Error: El campo B debe ser mayor al campo A", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;
                case "Exponencial":
                    if (String.IsNullOrEmpty(txtLambda.Text))
                    {
                        MessageBox.Show("Error: Debe ingresar un valor en el campo lambda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (Convert.ToInt32(this.txtLambda.Text) == 0)
                    {
                        MessageBox.Show("Error: Lambda debe ser distinto a cero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;
                case "Normal - Box Muller":
                    if (String.IsNullOrEmpty(txtInput1.Text) || String.IsNullOrEmpty(txtInput2.Text))
                    {
                        MessageBox.Show("Error: Los campos Media y Desviacion deben tener un valor correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;
                case "Poisson":
                    if (String.IsNullOrEmpty(txtLambda.Text))
                    {
                        MessageBox.Show("Error: Debe ingresar un valor en el campo lambda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (Convert.ToInt32(this.txtLambda.Text) == 0)
                    {
                        MessageBox.Show("Error: Lambda debe ser distinto a cero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;
                default:
                    return false;
            }
            return true;
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
