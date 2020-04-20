using GeneradorDeNumerosAleatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVarGenerator
{
    class ExponentialGenerator
    {
        public double lambda { get; set; }

        public Generator congruentialGenerator = new Generator() { a = 71561, c= 56822, seed= 31767, M= 341157 };

        public double Generate()
        {
            double rnd = congruentialGenerator.NextRnd();
            double num = (-1 / this.lambda) * Math.Log(1 - rnd);
            return num;
        }
    }
}
