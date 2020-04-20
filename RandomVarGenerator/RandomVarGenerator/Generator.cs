using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNumerosAleatorios
{
    public class Generator
    {
        public double seed { get; set; }
        public double a { get; set; }
        public double c { get; set; }
        public double M { get; set; }
        public double type { get; set; }

        public List<double> Generate(int quantity)
        {
            List<double> result = new List<double>();

            for (int i=0; i<quantity; i++)
            {
                double rnd = ((this.a * this.seed) + this.c) % this.M;
                this.seed = rnd;
                rnd = rnd / (this.M -1 );
                rnd = Math.Truncate(rnd * 10000) / 10000;
                result.Add(rnd);
            }

            return result;
        }

        public double NextRnd()
        {
            double rnd = ((this.a * this.seed) + this.c) % this.M;
            this.seed = rnd;
            rnd = rnd / (this.M - 1);
            return rnd;
        }
    }
}
