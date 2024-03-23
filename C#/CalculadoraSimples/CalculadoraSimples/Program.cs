internal class Program
{
    private static void Main(string[] args)
    {
      
        Menu();
    }

    static void Menu(){
        Console.Clear();
        Console.WriteLine("Selecione uma opção");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("----------------------");
        Console.WriteLine("Qual calculo deseja realizar ?");
        short res = short.Parse(Console.ReadLine());

        switch(res){
            case 1: Soma();break;
            case 2: Subtracao();break;
            case 3: Multiplicacao();break;
            case 4: Divisao();break;
            default: Menu();break;
        }
    

    }


    static void Soma(){

        Console.Clear();
        Console.WriteLine("Digite o primeiro número");
        short  pNumero = short.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segunda número");
        short sNumero = short.Parse(Console.ReadLine());

        Console.WriteLine("Resultado da Soma : "+(pNumero + sNumero));
        Console.ReadKey();
        Menu();
    
    }

    static void Subtracao(){
        Console.Clear();
        Console.WriteLine("Digite o primeiro número");
        short pNumero = short.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segunda número");
        short sNumero = short.Parse(Console.ReadLine());

        Console.WriteLine("Resultado da Subtração : "+(pNumero - sNumero));
        Console.ReadKey();
        Menu();
   }
   static void Multiplicacao(){
        Console.Clear();
        Console.WriteLine("Digite o primeiro número");
        short pNumero = short.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segunda número");
        short sNumero = short.Parse(Console.ReadLine());

        Console.WriteLine("Resultado da Multiplicação :"+(pNumero * sNumero));
        Console.ReadKey();
        Menu();
   }

   static void Divisao(){
        Console.Clear();
        Console.WriteLine("Digite o primeiro número");
        short pNumero = short.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segunda número");
        short sNumero = short.Parse(Console.ReadLine());

        Console.WriteLine("Resultado da Divisão : "+(pNumero / sNumero));
        Console.ReadKey();
        Menu();
   }

}