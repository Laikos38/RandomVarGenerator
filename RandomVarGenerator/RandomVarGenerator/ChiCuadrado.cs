using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNumerosAleatorios
{
    class ChiCuadrado
    {
        public ChiCuadrado()
        {
        }

        public Intervalo[] getFrequencies(List<decimal> serie, int k)
        {
            if ((serie.Count / k) < 5 && k > 1) k /= 2; //Para distribución uniforme

            Intervalo[] intervalos = new Intervalo[k];
            double acum = 0;
            for (int j = 0; j < k; j++)
            {
                intervalos[j] = new Intervalo(0, 0);
                intervalos[j].LimInf = (decimal) acum;
                acum += (double) 1/k;
                intervalos[j].LimSup = (decimal) acum;                
            }

            int n = serie.Count;

            for (int i = 0; i < n; i++)
            {
                foreach (Intervalo interv in intervalos)
                {
                    if (interv.belongsToMe(serie[i]))
                    {
                        interv.contador += 1;
                        break;
                    }
                }
            }
            
            return intervalos;
        }

        public double calcEstadistico(Intervalo[] intervalos, int n)
        {
            double c = 0;
            double fe = (n / intervalos.Length); //Revisar si la frecuencia esperada debe ser un int o un double

            foreach (Intervalo interv in intervalos)
            {
                c += Math.Pow((fe - interv.contador), 2) / fe;
            }
            c = (Math.Truncate(c * 10000) / 10000);
            return c;
        }

        public double getCriticalValue(int v)
        {
            v -= 1;
            double[] tablaChiCuadrado95 = new double[100];

            tablaChiCuadrado95[0] = 3.841;
            tablaChiCuadrado95[1] = 5.991;
            tablaChiCuadrado95[2] = 7.815;
            tablaChiCuadrado95[3] = 9.488;
            tablaChiCuadrado95[4] = 11.070;
            tablaChiCuadrado95[5] = 12.592;
            tablaChiCuadrado95[6] = 14.067;
            tablaChiCuadrado95[7] = 15.507;
            tablaChiCuadrado95[8] = 16.919;
            tablaChiCuadrado95[9] = 18.307;
            tablaChiCuadrado95[10] = 19.675;
            tablaChiCuadrado95[11] = 21.026;
            tablaChiCuadrado95[12] = 22.362;
            tablaChiCuadrado95[13] = 23.685;
            tablaChiCuadrado95[14] = 24.996;
            tablaChiCuadrado95[15] = 26.296;
            tablaChiCuadrado95[16] = 27.587;
            tablaChiCuadrado95[17] = 28.869;
            tablaChiCuadrado95[18] = 30.144;
            tablaChiCuadrado95[19] = 31.410;
            tablaChiCuadrado95[20] = 32.671;
            tablaChiCuadrado95[21] = 33.924;
            tablaChiCuadrado95[22] = 35.172;
            tablaChiCuadrado95[23] = 36.415;
            tablaChiCuadrado95[24] = 37.652;
            tablaChiCuadrado95[25] = 38.885;
            tablaChiCuadrado95[26] = 40.113;
            tablaChiCuadrado95[27] = 41.337;
            tablaChiCuadrado95[28] = 42.557;
            tablaChiCuadrado95[29] = 43.773;
            tablaChiCuadrado95[39] = 53.7;
            tablaChiCuadrado95[49] = 66.8;
            tablaChiCuadrado95[59] = 79.5;
            tablaChiCuadrado95[69] = 104.2;
            tablaChiCuadrado95[79] = 116.3;
            tablaChiCuadrado95[89] = 128.3;
            tablaChiCuadrado95[99] = 140.2;

            return tablaChiCuadrado95[v];
        }
    }
}
