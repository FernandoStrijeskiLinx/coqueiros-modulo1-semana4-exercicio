using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S04
{
    /// <summary>
    /// CLasse statica para criação do menu
    /// </summary>
    public static class Menu
    {
        public static List<Bebida> ListaBebidas { get; set; }
        private static string? opcao;

        static Menu()
        {
            ListaBebidas = new List<Bebida>();
        }

        /// <summary>
        /// Display inicial
        /// </summary>
        public static void DisplayInicial()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao GoDrink! O que você deseja fazer?");
            Console.WriteLine("1 - Inserir Bebida");
            Console.WriteLine("2 - Alterar Bebida");
            Console.WriteLine("3 - Excluir Bebida");
            Console.WriteLine("4 - Listar todas as bebidas");
            Console.WriteLine("5 - Listar todos os sucos");
            Console.WriteLine("6 - Listar todos os refrigerantes");
            Console.WriteLine("7 - Sair");
        }

        /// <summary>
        /// Opção para reiniciar o projeto
        /// </summary>
        /// <returns></returns>
        public static bool ReiniciarDisplay()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Deseja continuar utilizando o GoDrink? ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1 - Sim.");
            Console.WriteLine("2 - Não.");
            Console.WriteLine("\n");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Menu.DisplayInicial();
                return true;
            }
            else           
                return false;            
        }

        /// <summary>
        /// Digitar primeiro valor
        /// </summary>
        /// <returns></returns>
        public static void InserirBebida()
        {
            try
            {       
                int tipo = 0;
                bool vidro = false;
                string tipoDeCaixa = "";

                do {
                    Console.Write("Informe o tipo da bebida: (1-Refrigerante ou 2-Suco)\n");
                    opcao = Console.ReadLine();
                } while(!TipoBebidaValido(opcao)); 
                tipo = int.Parse(opcao);

                Console.Write("Informe o nome da bebida:\n");
                var nome = Console.ReadLine();

                Console.Write("Informe a quantidade de ml da bebida:\n");
                decimal miliLitro = decimal.Parse(Console.ReadLine());
                
                Console.Write("Informe o valor de compra da bebida:\n");
                decimal valorCompra = decimal.Parse(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        do {
                            Console.Write("A garrafa é de vidro? (Informe S-Sim ou N-Não)\n");
                            opcao = Console.ReadLine();
                        } while(!(opcao.ToUpper() == "S" || opcao.ToUpper() == "N"));                 
                        
                        if(opcao=="S")
                            vidro = true;

                        Refrigerante refrigerante = new Refrigerante(1, miliLitro, valorCompra, vidro);
                        Repositorio.AdicionarRefrigerante(refrigerante);
                    break;

                    case 2:
                        Console.Write("Informe o tipo de caixa:\n");
                        tipoDeCaixa = Console.ReadLine();

                        Suco suco = new Suco(1, miliLitro, valorCompra, tipoDeCaixa);
                        Repositorio.AdicionarSuco(suco);
                    break;
                }

                Console.WriteLine("Bebida cadastrada com sucesso! Aguarde 5 segundos para a tela carregar o display inicial");
                Thread.Sleep(5000);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Falha no preenchimentos dos dados ao inserir a bebida! Aguarde 5 segundos para a tela carregar o display inicial");
                Thread.Sleep(5000);
            }
        }

        /// <summary>
        /// Opção selecionada
        /// </summary>
        /// <returns></returns>
        public static int SelecionarOpcao()
        {
            do {
                Console.WriteLine("Selecione uma opção do menu: ");
                opcao = Console.ReadLine();
            } while(!ItemMenuValido(opcao));
            
            return Convert.ToInt32(opcao);
        }

        private static bool ItemMenuValido(string? readLine){
            try
            {
                if(readLine == null)
                    return false;
                    
                var resultado = int.Parse(readLine); 
                
                if(resultado < 0 || resultado > 7){
                    Console.WriteLine("A opção informada não existe! Vamos tentar novamente.");
                    return false;
                }

                return true;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Opção inválida! Você deve preencher somente números.");
                return false;
            }
        }

        private static bool TipoBebidaValido(string? readLine){
            try
            {
                if(readLine == null)
                    return false;
                    
                var resultado = int.Parse(readLine); 
                
                if(resultado != 1 && resultado != 2){
                    Console.WriteLine("A opção informada não existe! Vamos tentar novamente.");
                    return false;
                }

                return true;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Opção inválida! Você deve preencher somente números.");
                return false;
            }
        }
    }
}