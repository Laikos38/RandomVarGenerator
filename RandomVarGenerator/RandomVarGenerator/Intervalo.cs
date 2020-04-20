using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNumerosAleatorios
{
    class Intervalo
    {
        decimal limSup = 0;
        decimal limInf = 0;
        int acumulador;

        public decimal LimSup { get => limSup; set => limSup = value; }
        public decimal LimInf { get => limInf; set => limInf = value; }
        public int contador { get => acumulador; set => acumulador = value; }

        public Intervalo(decimal lI, decimal lS)
        {
            this.limInf = lI;
            this.limSup = lS;
        }

        public bool belongsToMe(decimal num)
        {
            return (LimInf <= num) && (num <= LimSup);
        }

        public override string ToString()
        {
            return "[" + Math.Round(this.LimInf, 2).ToString() +" - " + Math.Round(this.limSup, 2).ToString() + ")";
        }
    }

 
        

        
}
