#include <conio.h>
#include <stdio.h>
#include <string.h>

static int MaiorNumero (int a, int b)
{
    if (a>b)
        {
            return a;
        }
    else if (b>a)
        {
            return b;
        }
    else
        {
            return -1;
        }
}



main ()
{
    int cont=0;
    int num1=0;
    int num2=0;

    do
    {
        printf ("Digite um valor: ");
        scanf("%d", &num1);
            while (num1<0)
                {
                    printf("Digite um numero positivo: ");
                    scanf("%d", &num1);
                }
        printf ("Digite outro valor: ");
        scanf("%d", &num2);
            while (num1<0)
                {
                    printf("Digite um numero positivo: ");
                    scanf("%d", &num2);
                }
        MaiorNumero(num1, num2);
        printf("----------------------\n");

        cont++;

    }while (cont<5);


}
