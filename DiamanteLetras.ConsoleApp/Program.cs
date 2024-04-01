namespace DiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            Console.WriteLine("Informe uma Letra");
            char n = Convert.ToChar(Console.ReadLine().ToUpper());

            if (n % 2 == 0)
            {
                Console.WriteLine("O caractere informado não pode gerar uma pirâmide");
                return;
            }

            int metade = n/2;

            for (int i = 0; i < metade; i++)
            {
                for (int j = 0; j < metade - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                a++;
            }

            for (int i = metade; i >= 0; i--)
            {
                for (int j = 0; j < metade - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < metade * i + 1; j++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
                n--;
            }
        }
    }
}
