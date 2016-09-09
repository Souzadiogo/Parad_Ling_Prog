#include <stdio.h>
#include <conio.h>
#include <string.h>

static int absoluto (int n)
{
    int i;

        if (n<0)
        {
            n=-(n);

        printf("\nAbsoluto: %d", n);

        }
        else
        {
            printf("\nAbsoluto: %d", n);
        }
    return n;
}



main ()
{
    int v;

        for(int i=0; i<10;i++)
        {

        printf("\nValor absoluto:", absoluto(v));
        scanf ("%d", &v);

        }
}

