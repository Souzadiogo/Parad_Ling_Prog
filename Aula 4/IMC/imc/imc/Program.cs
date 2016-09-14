using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    public class Pessoa
    {
        String nome;
        String sexo;
        float peso = 0;
        float altura = 0;
        int idade = 0;
  


        public static void imc()
        {
            Pessoa p = new Pessoa();
            

            Console.WriteLine("Digite sua idade:");
            p.idade = int.Parse(Console.ReadLine());
            do
            {
                if (p.idade < 18)
                {
                    Console.WriteLine("Você não tem idade para medir seu IMC:");
                    Console.WriteLine("Digite sua idade:");
                    p.idade = int.Parse(Console.ReadLine());
                }
            } while (p.idade < 18);
            Console.WriteLine("Digite seu nome: ");
            p.nome = Console.ReadLine();
            Console.WriteLine("Digite seu sexo: M- MASCULINO --- F-FEMININO ");
            p.sexo = Console.ReadLine();
            Console.WriteLine("Digite seu peso:");
            p.peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura:");
            p.altura = float.Parse(Console.ReadLine());

            

            if (CalcImc(p.peso, p.altura) < 18.5)
            {
                Console.WriteLine("Abaixo do peso ideal:");
            }
            else if (CalcImc(p.peso, p.altura) >= 18.5 & CalcImc(p.peso, p.altura) < 25)
            {
                Console.WriteLine("No peso ideal:");
            }
            else if(CalcImc(p.peso, p.altura) >= 25 & CalcImc(p.peso, p.altura) < 30)
            {
                Console.WriteLine("Acima do peso:");
            }
            else
            {
                Console.WriteLine("Você esta com obesidade");
            }


        }

        static float CalcImc(float peso, float altura)
        {

            float calc;
            float imc;
            calc = (altura * altura);
            imc = calc / peso;

            return imc;


            
        }

         static void Main(string[] args)
        {
         
            imc();
            
            Console.ReadKey();



        }
    }
}
