using GeneradorDeNumerosAleatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVarGenerator
{
    class ConvolutionGenerator
    {
        public double mean { get; set; }

        public double stDeviation { get; set; }

        public Generator congruentialGenerator = new Generator() { seed = 31767, a = 71561, c = 56822, M = 341157 };
        
        public Double Generate()
        {
            double ac = 0;
            for (int i = 0; i < 12; i++)
            {
                ac += congruentialGenerator.NextRnd();
            }
            double rnd = (ac - 6) * this.stDeviation + this.mean;

            return rnd;
        }

        public Intervalo[] getExpectedFrequencies(int n, Intervalo[] intervalos)
        {
            foreach (Intervalo interv in intervalos)
            {
                double classMark = interv.getClassMark();

                interv.expectedCount = n * Math.Exp(-0.5 * Math.Pow((classMark - this.mean) / this.stDeviation, 2)) / (this.stDeviation * Math.Sqrt(2 * Math.PI)) * interv.getWidth();
            }

            return intervalos;
        }
    }
}
