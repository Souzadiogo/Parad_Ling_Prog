using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
         static float multiplica(float x, float y)
        {
            float calc;

            calc = x * y;
            return (calc);
        }
        static float soma(float num1, float num2)
        {
            float resp;
            resp = num1 + num2;
            return (resp);
        }
        static float dividir (float num1, float num2)
        {
            return num1 / num2;
        }
        static float diminui(float num1, float num2)
        {
            return num1 - num2;
        }

        static void Main(string[] args)      
        {
                int op;
                float num1=0, num2=0, resp=0;

                do
                {

                    Console.Write("\nEscolha uma opcao de calculo: ");
                    Console.Write("\n1 - Multiplicacao \n2 - Soma\n3 - Divisao\n4 - Subtracao \n5 - Sair\n");
                    do
                    {
                        op = int.Parse(Console.ReadLine());
                        if ((op < 1) || (op > 5))
                            Console.Write("\nOpcao invalida!!");
                    } while ((op < 1) || (op > 5));

                    if (op != 5)
                    {
                        Console.Write("\nDigite um numero: ");
                        num1= float.Parse(Console.ReadLine());
                        Console.Write("\nDigite outro numero: ");
                        num2 = float.Parse(Console.ReadLine());
                    }
                    switch (op)
                    {
                        case 1:
                            resp = multiplica(num1, num2);
                            break;
                        case 2:
                            resp = soma(num1, num2);
                            break;
                        case 3:
                            resp = dividir(num2, num2);
                            break;
                        case 4:
                            resp = diminui(num1, num2);
                            break;
                    }

                    if (op == 5)
                        Console.Write("\nPrograma encerrado.....");
                        
                    else
                        Console.Write("\nResultado da operacao escolhida: " +resp);
                } while (op != 5);
                
       }
    }
 }
