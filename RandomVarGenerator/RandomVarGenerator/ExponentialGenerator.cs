﻿using GeneradorDeNumerosAleatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVarGenerator
{
    class ExponentialGenerator
    {
        public float lambda { get; set; }

        public Generator congruentialGenerator = new Generator() { a = 71561, c= 56822, seed= 31767, M= 341157 };

        public decimal Generate()
        {
            double rnd = Convert.ToDouble(congruentialGenerator.NextRnd());
            decimal num = Convert.ToDecimal((-1 / this.lambda) * Math.Log(1 - rnd));
            return num;
        }
    }
}