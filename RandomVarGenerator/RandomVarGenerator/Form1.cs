﻿using GeneradorDeNumerosAleatorios;
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
                (e.KeyChar != '-') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
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

            else if (this.cmbDistribution.SelectedIndex == 3 || this.cmbDistribution.SelectedIndex == 4)
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
            this.txtResChi.Text = "";
            this.txtTabuledChi.Text = "";
            this.txtObtainedSChiSum.Text = "";
            this.cmbDistribution.SelectedIndex = 0;
            this.cmbIntervalsQuantity.SelectedIndex = 0;
            this.chartFreq.Series["Freq observada"].Points.Clear();
            this.chartFreq.Series["Freq esperada"].Points.Clear();
            this.dgvChi.Rows.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
               return;

            this.chartFreq.Series["Freq observada"].Points.Clear();
            this.chartFreq.Series["Freq esperada"].Points.Clear();
            this.dgvChi.Rows.Clear();

            int subInt = Convert.ToInt32(this.cmbIntervalsQuantity.Text);
            int quantity = Convert.ToInt32(this.txtQuantity.Text);

            Intervalo[] intervals = new Intervalo[subInt];
            ChiCuadrado chi2 = new ChiCuadrado();
            generatedList.Clear();
            StringBuilder numbersList = new StringBuilder();

            if ((string)this.cmbDistribution.SelectedItem == "Uniforme")
            {
                double a = Convert.ToDouble(this.txtInput1.Text);
                double b = Convert.ToDouble(this.txtInput2.Text);

                UniformGenerator uniformGenerator = new UniformGenerator() { a = a, b = b };
                for (int i = 0; i < quantity; i++)
                {
                    double rnd = uniformGenerator.Generate();
                    rnd = (Math.Truncate(rnd * 10000) / 10000);
                    generatedList.Add(rnd);
                    numbersList.Append((i + 1) + ")\t" + rnd + Environment.NewLine);
                }
                
                intervals = chi2.getFrequencies(generatedList, subInt, this.cmbDistribution.SelectedIndex, a, b);
                intervals = uniformGenerator.getExpectedFrequencies(intervals, quantity);
                int v = intervals.Length - 1;
                this.testChi(chi2, intervals, v);
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

                intervals = chi2.getFrequencies(generatedList, subInt, this.cmbDistribution.SelectedIndex);
                intervals = exponentialGenerator.getExpectedFrequencies(intervals, quantity);
                int v = intervals.Length - 2;
                this.testChi(chi2, intervals, v);
            }

            else if ((string)this.cmbDistribution.SelectedItem == "Normal - Box Muller")
            {
                double mean = Convert.ToDouble(this.txtInput1.Text);
                double stDeviation = Convert.ToDouble(this.txtInput2.Text);
                BoxMullerGenerator boxMullerGenerator = new BoxMullerGenerator() { mean = mean, stDeviation = stDeviation };
                for (int i = 0; i < quantity; i++)
                {
                    double[] boxRnd = boxMullerGenerator.Generate();
                    if (i % 2 == 0)
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

                intervals = chi2.getFrequencies(generatedList, subInt, this.cmbDistribution.SelectedIndex);
                intervals = boxMullerGenerator.getExpectedFrequencies(quantity, intervals);
                int v = intervals.Length - 3;
                this.testChi(chi2, intervals, v);
            }

            else if ((string)this.cmbDistribution.SelectedItem == "Normal - Convolucion")
            {
                double mean = Convert.ToDouble(this.txtInput1.Text);
                double stDeviation = Convert.ToDouble(this.txtInput2.Text);
                ConvolutionGenerator convolutionGenerator = new ConvolutionGenerator() { mean = mean, stDeviation = stDeviation };

                for (int i = 0; i < quantity; i++)
                {
                    double convRnd = convolutionGenerator.Generate();
                    convRnd = (Math.Truncate(convRnd * 10000) / 10000);
                    generatedList.Add(convRnd);
                    numbersList.Append((i + 1) + ")\t" + convRnd + Environment.NewLine);
                }

                intervals = chi2.getFrequencies(generatedList, subInt, this.cmbDistribution.SelectedIndex);
                intervals = convolutionGenerator.getExpectedFrequencies(quantity, intervals);
                int v = intervals.Length - 3;
                this.testChi(chi2, intervals, v);
            }

            else if ((string)this.cmbDistribution.SelectedItem == "Poisson")
            {
                double lambda = Convert.ToDouble(this.txtLambda.Text);
                PoissonGenerator poissonGenerator = new PoissonGenerator() { lambda = lambda };
                for (int i = 0; i < quantity; i++)
                {
                    double poissonRnd = poissonGenerator.Generate();
                    generatedList.Add(poissonRnd);
                    numbersList.Append((i + 1) + ")\t" + poissonRnd + Environment.NewLine);
                }
                intervals = chi2.getFrequencies(generatedList, subInt, this.cmbDistribution.SelectedIndex);
                intervals = poissonGenerator.getExpectedFrequencies(quantity, intervals);
                int v = intervals.Length - 2;
                this.testChi(chi2, intervals, v);
            }


            this.txtGeneratedList.Text = numbersList.ToString();
            
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
                    if (Convert.ToDouble(this.txtInput2.Text) < Convert.ToDouble(this.txtInput1.Text))
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
                    if (Convert.ToDouble(this.txtLambda.Text) == 0)
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
                case "Normal - Convolucion":
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
                    if (Convert.ToDouble(this.txtLambda.Text) == 0)
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
            this.chartFreq.Series["Freq esperada"].Points.Clear();
            double sum = 0;

            foreach (Intervalo interval in intervals)
            {
                double col4 = Math.Round(Math.Pow(interval.contador - interval.expectedCount, 2), 4);
                double col5 = Math.Round(col4 / interval.expectedCount, 4);
                sum += col5;
                string intervalStr = interval.ToString();
                // Agrego points de grafico de frecuencia observada
                this.chartFreq.Series["Freq observada"].Points.AddXY(
                    intervalStr,
                    interval.contador
                    );
                this.chartFreq.Series["Freq esperada"].Points.Add(interval.expectedCount);
                this.dgvChi.Rows.Add(
                    intervalStr,
                    interval.contador,
                    interval.expectedCount,
                    col4,
                    col5,
                    sum
                    );
            }
        }

        private void testChi(ChiCuadrado chi, Intervalo[] intervalos, int v)
        {
            double cCalc = chi.calcEstadistico(intervalos);
            double cTab = chi.getCriticalValue(v);

            this.txtObtainedSChiSum.Text = cCalc.ToString();
            this.txtTabuledChi.Text = cTab.ToString();

            if (cCalc < cTab) this.txtResChi.Text = "No se rechaza la hipótesis nula";
            else this.txtResChi.Text = " Se rechaza la hipótesis nula";
        }
    }
}
