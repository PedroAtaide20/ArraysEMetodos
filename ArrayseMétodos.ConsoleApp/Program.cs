using System;

namespace ArrayseMétodos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];
            int media = 0;
            int media1 = 0;
            int numeroMenor;
            int maiorNumero = 0;
            string numeroRemoverStr;




            for (int i = 0; i < numero.Length; i++)
            {
                GuardarNumerosDigitados(numero, i);
                media = FazerMedia(numero, ref media1, i);
            }
            SepararNumerosNegativos(numero);
            Console.WriteLine();// pula uma linha da passada p n fica tudo junto
            MostarTodosOsNumerosDigitados(numero);
            Console.WriteLine(); // pular linha para n ficar tudo junto            
            DeixarEmOrdemCrescenteEFazerOsTextos(numero, media);
            MenorValor(numero, out numeroMenor);
            MaiorValor(numero, ref maiorNumero);
            numeroRemoverStr = REmoverNumero(ref numero);

            Console.ReadKey();

            static void GuardarNumerosDigitados(int[] numero, int i)
            {
                Console.WriteLine("Digite os numeros");// digitar numeros
                numero[i] = Convert.ToInt32(Console.ReadLine());// transformar numeros em it, pq tavam em string
                Console.Clear();// cpnsole clear p fica bonitnho
            }

            static int FazerMedia(int[] numero, ref int media1, int i)
            {
                int media;
                media1 += numero[i];// media1 = somar todos os numeros que escrevi
                media = media1 / 10;// media dividir todos os numeros por 10 para pegar a media total
                return media;
            }

            static void SepararNumerosNegativos(int[] numero)
            {
                Console.Write("Os numeros negativos são: ");// pre-escrever texto que vai aparecer junto c varias variaveis
                foreach (int i in numero)// vai pegar todos os numeros digitados, vendo um por um
                {
                    if (i < 0)// os que forem menores que 0 vão virar o (i)
                    {
                        Console.Write(i);// aprece junto c o texto pre escrito acima
                    }
                }
            }

            static void MostarTodosOsNumerosDigitados(int[] numero)
            {
                Console.Write("Os numeros digitados foram: ");// pré escrever texto que vai aparecer junto c varias variaveis
                foreach (int i in numero)// vai pegar todos os numeros digitados, vendo um por um
                {
                    Console.Write(i + ",");// vai escrever todos os numeros, separados com virgulas
                }
            }

            static int MenorValor(int[] numero, out int numeroMenor)
            {
                numeroMenor = 0;
                numeroMenor = numero[0];
                Console.WriteLine($"O menor numero é: {numeroMenor}");
                return numeroMenor;

            }
            static int MaiorValor(int[] numero, ref int maiorNumero)
            {
                maiorNumero = 0;
                maiorNumero = numero[9];
                Console.WriteLine($"O maior numero é: {maiorNumero}");
                return maiorNumero;


            }

            static void DeixarEmOrdemCrescenteEFazerOsTextos(int[] numero, int media)
            {
                Array.Sort(numero);// comando para deixar os numeros digitados em ordem crescendo, sendo o [0] menor e o [9] o maior



                Console.WriteLine($"A Média dos 10 numeros é: {media}\n" +
                    $", Os maiores numeros são: {numero[9]}, {numero[8]}, {numero[7]}");


            }

            static string REmoverNumero(ref int[] numero)
            {
                string numeroRemoverStr;
                Console.WriteLine("Qual numero deseja retirar?");
                numeroRemoverStr = Console.ReadLine();
                int numeroRemover = Convert.ToInt32(numeroRemoverStr);

                numero = numero.Where(e => e != numeroRemover).ToArray();
                Console.WriteLine(String.Join(",", numero));
                return numeroRemoverStr;
            }
    }
}
}
