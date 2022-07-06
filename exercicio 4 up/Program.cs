namespace exercicio_4_up
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio4
            int cont;
            int num;
            Console.WriteLine(" digite o numero um para ver a sequencia até o cinquenta:");
            num = int.Parse(Console.ReadLine());
            for (cont = 1; cont <= 50; cont++)
            {
                Console.WriteLine((num + cont));
            }
            Console.ReadKey();
        }
    }
}