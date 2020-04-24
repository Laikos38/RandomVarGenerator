using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradorDeNumerosAleatorios;

namespace RandomVarGenerator
{
    class BoxMullerGenerator
    {
        public Generator congruentialGenerator = new Generator() { seed = 31767, a = 71561, c = 56822, M = 341157 };
        double[] resultPair = new double[2];
        public double stDeviation { get; set; }
        public double mean { get; set; }

        public double[] Generate()
        {
   
            double n1 = this.congruentialGenerator.NextRnd();
            double n2 = this.congruentialGenerator.NextRnd();

            double r1 = ((Math.Sqrt(-2 * Math.Log(n1))) * Math.Cos(2 * Math.PI * n2)) * this.stDeviation + this.mean;
            double r2 = ((Math.Sqrt(-2 * Math.Log(n1))) * Math.Sin(2 * Math.PI * n2)) * this.stDeviation + this.mean;


            this.resultPair[0] = r1;
            this.resultPair[1] = r2;

            return this.resultPair;
        }

        public Intervalo[] getExpectedFrequencies(int n, Intervalo[] intervalos)
        {
            foreach(Intervalo interv in intervalos)
            {
                double classMark = interv.getClassMark();

                interv.expectedCount = Math.Round( n * Math.Exp(-0.5 * Math.Pow((classMark - this.mean) / this.stDeviation, 2)) / (this.stDeviation * Math.Sqrt(2 * Math.PI)) * interv.getWidth());
            }

            return intervalos;
        }
    }
}
