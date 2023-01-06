namespace _01_ComandosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            //Operadores lógicos e (&&) ou (||)
            //comando if - Se (teste Verdadeiro)

            if(idade >= 18 && altura >= 1.60) {
                Console.WriteLine("Pode entrar na piscina!");
            }
            else
            {
                Console.WriteLine("Você não pode entrar na piscina!");
            }

            Console.ReadKey();
        }
    }
}