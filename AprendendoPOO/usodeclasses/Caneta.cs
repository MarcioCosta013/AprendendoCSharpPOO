using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoPOO
{
    internal class Caneta
    {
        public string cor;
        public string modelo;
        public float ponta;
        public int carga;
        public bool tampada;

        public void status() 
        {
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Cor: " + this.cor); 
            Console.WriteLine("Ponta: " + this.ponta);
            Console.WriteLine("Carga: " + this.carga);
            Console.WriteLine("Tampada: " + this.tampada);
        }

        public void rabiscar()
        { 
            if(this.tampada == true)
            {
                Console.WriteLine("Erro! Não posso rabiscar.");
            }
            else
            {
                Console.WriteLine("Estou rabiscando...");
            }
        }

        public void tampar()
        {
            this.tampada = true;
        }

        public void destampar()
        {
            this.tampada = false;
        }
    }
}
