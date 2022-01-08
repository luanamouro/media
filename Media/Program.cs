using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n1, n2, n3, media,freq,dadas,assistidas;
            Console.WriteLine("Digite sua primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de aulas dadas:");
            dadas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de aulas assistidas:");
            assistidas = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            freq = (assistidas / dadas) * 100;

            if (media <= 4 || freq < 75 / 100)
            {

                Console.WriteLine("Reprovado! Media: {0}, Frequência: {1}", media.ToString("0.0"), freq.ToString("0.0"));
            }
            else if (media < 7 || freq < 75 / 100)
            {
                Console.WriteLine("Fazer prova final! Media: {0}, Frequência: {1}",
                    media.ToString("0.0"), freq.ToString("0.0"));


            }

            else 
            {
                Console.WriteLine("Aprovado! Media: {0}, Frequência: {1}", media.ToString("0.0"), freq.ToString("0.0"));
            }

        }
    }
}
