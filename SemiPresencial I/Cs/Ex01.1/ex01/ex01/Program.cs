using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsPrincipal
{
    public class ClsPrincipal
    {

        public static int anoNascimento;

        public static int CalculaIdade(int anoNascimento)
        {
            int idade = 0;
            int ano = 2015;
            idade = ano-anoNascimento; //Erro de semantica 2015-anoNascimento;


            return idade;
            //Erro semantica falta RETURN;
        }

        public static void VerificaMaiorMenor(int idade) //Erro de semantica, INT, FLOAT, DOUBLE...
        {
            if
                    (idade >= 18)//Erro de semantica, (idade>=18)
            { 
                Console.Write("\nMaior de idade\n");
            }
            else
            {
                Console.Write("\nMenor de idade\n");
            }
        }
        static void Main(String[] args)
        {
            int idade = 0;

            Console.Write("Entre com o ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());
            idade = anoNascimento;
            Console.Write(CalculaIdade(anoNascimento));//Sintaxe (;) Semantica precisa mostrar sout(CalculaIdade(anoNascimento));
            VerificaMaiorMenor(CalculaIdade(idade)); //Sintaxe (;) Semantica, passa valor inteiro para a funcao que retornar uma string
            Console.ReadKey();
        }
    }

}

