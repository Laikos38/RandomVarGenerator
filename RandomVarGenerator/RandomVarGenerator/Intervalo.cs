using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNumerosAleatorios
{
    class Intervalo
    {
        double limSup = 0;
        double limInf = 0;
        int acumulador;

        public double LimSup { get => limSup; set => limSup = value; }
        public double LimInf { get => limInf; set => limInf = value; }
        public int contador { get => acumulador; set => acumulador = value; }

        public Intervalo(double lI, double lS)
        {
            this.limInf = lI;
            this.limSup = lS;
        }

        public bool belongsToMe(double num)
        {
            return (LimInf <= num) && (num <= LimSup);
        }

        public override string ToString()
        {
            return "[" + Math.Round(this.LimInf, 2).ToString() +" - " + Math.Round(this.limSup, 2).ToString() + ")";
        }
    }

 
        

        
}
