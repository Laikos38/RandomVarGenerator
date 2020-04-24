using GeneradorDeNumerosAleatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVarGenerator
{
    class PoissonGenerator
    {
        public double lambda { get; set; }

        public Generator congruentialGenerator = new Generator() { seed = 31767, a = 71561, c = 56822, M = 341157 };

        public double Generate()
        {
            double x = -1;
            double p = 1;
            double a = Math.Exp(-lambda);
            do
            {
                double u = congruentialGenerator.NextRnd();
                p = p * u;
                x = x + 1;
            } while (p >= a);
            return x;
        }

        public Intervalo[] getExpectedFrequencies(int n, Intervalo[] intervalos)
        {            
            foreach(Intervalo interv in intervalos)
            {
                double acum = 0;
                for (double i=interv.LimInf; i<interv.LimSup; i++)
                {
                    double freq = Math.Round((Math.Pow(this.lambda, i) * Math.Exp(-this.lambda) / factorial(i))*n, 2);
                    acum += freq;
                }
                interv.expectedCount = acum;
            }

            return intervalos;
        }

        public double factorial(double n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
