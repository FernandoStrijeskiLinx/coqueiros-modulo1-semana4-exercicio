using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S04
{
    public static class Repositorio
    {
        public static List<Bebida> Bebidas { get; set; } = new List<Bebida>();
        public static List<Suco> Sucos { get; set; } = new List<Suco>();
        public static List<Refrigerante> Refrigerantes { get; set; } = new List<Refrigerante>();


        public static void AdicionarSuco(Suco suco){
            Sucos.Add(suco);
        }

        public static void AdicionarRefrigerante(Refrigerante refrigerante){
            Refrigerantes.Add(refrigerante);
        }

        public static void AdicionarBebida(Bebida bebida){
            Bebidas.Add(bebida);
        }
        
        public static void ExcluirBebida(int id){
            try
            {
                Bebida? bebida = Bebidas.Find(x => x.Id == id);
                if(bebida != null){
                    Bebidas.Remove(bebida);
                }    
            }
            catch (System.Exception)
            {                
                throw;
            }            
        }
        
        public static void ListarTodasBebidas(){
            try
            {
                Console.WriteLine($"Listando as bebidas:");
                foreach (Bebida bebida in Bebidas)
                {
                    Console.WriteLine($"{bebida.Id.ToString()} - {bebida.NomeBebida} - Quantidade ml: {bebida.MiliLitro.ToString("N2")}");
                }
            }
            catch (System.Exception)
            {                
                throw;
            } 
        }
    }
}