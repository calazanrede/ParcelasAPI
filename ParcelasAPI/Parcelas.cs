using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelasAPI
{
    public class Parcelas
    {
       public static double debito; 
       public static int quantidadeParcelas;
       public static double correcao;
        public double Correcao
        {
            get { return correcao; }
            set { correcao = value; }
        }
        public double Debito
        {
            get { return debito; }
            set { debito = value; }
        }
        public int QuantidadeParcelas
        {
            get { return quantidadeParcelas; }
            set { quantidadeParcelas = value; }
        }

    }
}
