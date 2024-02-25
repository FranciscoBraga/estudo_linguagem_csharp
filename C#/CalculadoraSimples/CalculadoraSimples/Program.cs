internal class Program
{
    private static void Main(string[] args)
    {
        Console.ReadKey();
        Menu();
    }

    static void Menu(){
        Console.WriteLine("Selecione uma opção");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");
    

    }
}