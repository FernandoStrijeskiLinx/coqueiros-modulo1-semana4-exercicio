using M1S04;

int opcaoEscolhida = 0;
bool showMenu = true;

while (showMenu)
{
    Menu.DisplayInicial();
    opcaoEscolhida = Menu.SelecionarOpcao();
    
    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("Você escolheu 'Inserir Bebida'! Precisamos coletar algumas informações:");            
            Menu.InserirBebida();
            showMenu = Menu.ReiniciarDisplay();
            break;

        case 2:
            Console.WriteLine("Você escolheu 'Alterar Bebida'! Precisamos coletar algumas informações:");
            
            showMenu = Menu.ReiniciarDisplay();
            break;

        case 3:
            Console.WriteLine("Você escolheu 'Excluir Bebida'! Informe o Id da bebida:");

            
            showMenu = Menu.ReiniciarDisplay();
            break;

        case 4:
            Console.WriteLine("Você escolheu 'Listar todas as bebidas'!");

            showMenu = Menu.ReiniciarDisplay();
            break;

        case 5:
            Console.WriteLine("Você escolheu 'Listar todas os sucos'!");

            showMenu = Menu.ReiniciarDisplay();
            break;

        case 6:
            Console.WriteLine("Você escolheu 'Listar todas os refrigerantes'!");
            showMenu = Menu.ReiniciarDisplay();
            break;
        case 7:
            Console.Write("Até logo!");
            showMenu = false;
            break;

        default:
            Console.WriteLine("Dados com erros, aguarde 2 segundos para a tela carregar o display inicial");
            Thread.Sleep(2000);
            Menu.DisplayInicial();
            break;
    }    
}