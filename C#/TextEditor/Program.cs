internal class Program
{
    #nullable disable
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu(){
        Console.Clear();
        Console.WriteLine("Seleciona um valor correspondente");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Abrir Arquivo");
        Console.WriteLine("2 - Criar novo Arquivo");

        short option = short.Parse(Console.ReadLine());

        switch(option){
            case 0 :  System.Environment.Exit(0); break;
            case 1 :  abrirArquivo(); break;
            case 2 :  novoArquivo() ; break;
            default : Menu(); break;
        }

        static void abrirArquivo(){

        }

         static void novoArquivo(){

            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para Sair)");
            Console.WriteLine("--------------------------------------");
            string text = " ";

            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);

            
        }
        
    }
}