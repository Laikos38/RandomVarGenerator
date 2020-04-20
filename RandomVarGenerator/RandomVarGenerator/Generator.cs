using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNumerosAleatorios
{
    public class Generator
    {
        public decimal seed { get; set; }
        public decimal a { get; set; }
        public decimal c { get; set; }
        public decimal M { get; set; }
        public int type { get; set; }

        public List<decimal> Generate(int quantity)
        {
            List<decimal> result = new List<decimal>();

            for (int i=0; i<quantity; i++)
            {
                decimal rnd = ((this.a * this.seed) + this.c) % this.M;
                this.seed = rnd;
                rnd = rnd / (this.M -1 );
                rnd = Math.Truncate(rnd * 10000) / 10000;
                result.Add(rnd);
            }

            return result;
        }

        public decimal NextRnd()
        {
            decimal rnd = ((this.a * this.seed) + this.c) % this.M;
            this.seed = rnd;
            rnd = rnd / (this.M - 1);
            return rnd;
        }
    }
}
