#include <conio.h>
#include <stdio.h>
#include <string.h>

void LePositivo (int a)
{
   int i, cont=0;
   int n[5];

   do
   {
    printf ("Digite um valor: ");
    scanf("%d", &a);
        while (a<0)
        {
            printf("Digite um numero positivo: ");
            scanf("%d", &a);
        }

        for (i=0; i<5;i++)
        {
            printf("SOMATORIO DE %d ate 1 eh %d\n", n ,Somatorio(n[i]);
        }

    cont++;
    }while(cont<5);
}


int Somatorio(int a){

    if(a == 1)
    {
        return (1);
    }
    else
    {
        return (a + Somatorio(a-1));
    }
}


main ()
{
    int num;

    LePositivo(num);

}
