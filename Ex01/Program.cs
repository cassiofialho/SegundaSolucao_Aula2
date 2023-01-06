namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quero cadastrar 2 alunos e suas duas notas
            //Quero calcular a média destas notas
            //Se a média for maior que 6 é aprovado senão reprovado

            int i = 1;

            Console.Write("Quantos alunos você quer cadastrar? ");

            int numeroAlunos = int.Parse(Console.ReadLine());

            while(i <= numeroAlunos)
            {
                Console.Write($"Digite o nome do aluno {i}: ");
                string nome = Console.ReadLine();

                Console.Write($"Digite a primeira nota do aluno {i}: ");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write($"Digite a segunda nota do aluno {i}: ");
                double nota2 = double.Parse(Console.ReadLine());

                double media = (nota1 + nota2) / 2;

                if(media >= 6) {
                    Console.WriteLine($"O aluno {nome} foi aprovado com a média {media}");
                }
                else
                {
                    Console.WriteLine($"O aluno {nome} foi reprovado com a média {media}");
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                i++;
            }

            Console.ReadKey();
        }
    }
}