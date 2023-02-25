using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S04
{
    public class Suco : Bebida
    {
        public string TipoDeCaixa { get; set; }

        public Suco(int id, decimal miliLitro, decimal valorCompra, string tipoDeCaixa) : base(id, miliLitro, valorCompra)
        {          
            this.TipoDeCaixa = tipoDeCaixa;
        }

        public void ImprimirDados(){
            Console.WriteLine($"O produto id {this.Id} é um suco é do tipo {this.TipoDeCaixa} com quantidade de MiliLitros {this.MiliLitro}");            
        }
    }
}