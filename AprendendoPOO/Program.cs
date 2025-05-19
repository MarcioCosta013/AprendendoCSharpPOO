using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AprendendoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caneta c1 = new Caneta();
            c1.modelo = "BIC Cristal";
            c1.cor = "Azul";
            c1.ponta = 0.5f;
            c1.carga = 80;
            c1.tampada = true;

            c1.status();

            c1.destampar();

            c1.status();
        }
    }
}
