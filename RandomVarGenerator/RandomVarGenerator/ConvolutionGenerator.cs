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

       // public Intervalo[] getExpectedFrequencies()
       
    }
}
