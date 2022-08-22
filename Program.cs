// using System;//estou usando o name space system

// namespace Hello //espaço de nomes (tudo que est adeclarado no escopo do name space só é enchergado dentro do escopo do namespace)
// {
//     class Program //a variavel,a funçao tem que estar sempre dentro de uma classe não pode ter variavel solta(força a programação orientada a objetos) uma classe  todos os membros eu não posso acessar as variaveis a vontade a nao ser que esteja publica
//     {//variavel declarada dentro de uma classe é um ATRIBUTO
//         static void Main(string[] args)//todo programa precisa ter UMA função main para o projeto 
//         {//main chamado sem precisar instanciar por isso coloca o static
//          //o void sinaliza que não retorna nada 

//             Console.WriteLine("Hello World!");//imprimindo 
//                                               //funções declaradas dentro de uma classe é um METODO
//                                               //c# só tem metodos

//             //exercicio 1 da lista
//             double altura = 0;
//             double largura = 0;
//             while (true)
//             {
//                 try
//                 {

//                     Console.WriteLine("Exercicio 1");
//                     Console.WriteLine("Digite uma largura");
//                     largura = Convert.ToDouble(Console.ReadLine());
//                     break;

//                     //double area=CalculaArea(5.0,2.0);
//                     //Console.WriteLine(area);
//                     //string linha=Console.ReadLine();//ler ate a linha quebrar
//                 }
//                 catch (Exception erro)
//                 {

//                     Console.WriteLine("Altura Inválido");
//                     // Console.WriteLine(erro.Message);
//                 }
//             }
//             while (true)
//             {
//                 try
//                 {

//                     Console.WriteLine("Digite uma altura");
//                     altura = Convert.ToDouble(Console.ReadLine());//faz a conversão para o double 
//                     break;

//                 }
//                 catch (Exception erro)
//                 {

//                     Console.WriteLine("Largura Inválida");
//                     // Console.WriteLine(erro.Message);
//                 }



//             }
//                Console.WriteLine("A area é ");
//                 Console.WriteLine(CalculaArea(largura, altura));

//             static double CalculaArea(double largura, double altura)
//             {
//                 return largura * altura;

//             }

//         }



//     }
// }





// //convensoes 
// //camelCase primeira letra minuscula e o resto maiusculo(atribustos,palavras reservadas e tipos primitivos)
// //PascalCase todas as letras maiusculas(todo o resto)
// //Substantivos(coisas,variaveis)
// //Metodos(fazem coisa usa verbo(função))

using System;
namespace Hello
{
    class Program
    {

        static double CalculaMedia(double[] numeros)
        {


            double soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];



            }
            double media = soma / numeros.Length;
            return media;
        }
        static double CalculaMediana(double[] numeros)
        {

            Array.Sort(numeros);
            //pega o numero do meio 


            if (numeros.Length % 2 == 0)
            {
                //soma os numeros do meio e faz a media 
                int m = numeros.Length / 2;
                double m1 = numeros[m];
                double m2 = numeros[m + 1];
                double[] mediamed = { m1, m2 };
                return CalculaMedia(mediamed);






            }
            else
            {
                int metade = Convert.ToInt32((numeros.Length / 2) - 0.5);
                return numeros[metade];


            }
        }
        static double CalculaModa(double[] numeros)
        {
            double[] repeticoes = new double[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                repeticoes[i] = 0;
                for (int j = 0; j < numeros.Length; j++)

                {
                    if (numeros[i] == numeros[j])
                    {
                        repeticoes[i]++;

                    }
                }
            }
            int maior = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (repeticoes[i] > repeticoes[maior])
                {
                    maior = i;
                }
            }
            return numeros[maior];
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Digite a quantidade de números: ");
            int q = Convert.ToInt32(Console.ReadLine());
            double[] x = new double[q];
            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("Digite um número: ");

                x[i] = Convert.ToDouble(Console.ReadLine());



            }
            Console.WriteLine(("A MÉDIA É:"));
            Console.WriteLine(CalculaMedia(x));
            Console.WriteLine(("A MEDIANA É:"));
            Console.WriteLine(CalculaMediana(x));
            Console.WriteLine(("A MODA É:"));
            Console.WriteLine(CalculaModa(x));




            //  double[] numeros = { 0.2, 6 };
            // Console.WriteLine(CalculaMedia(numeros));



        }

    }
}




