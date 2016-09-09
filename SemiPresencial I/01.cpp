#include <stdio.h>
#include <conio.h>
#include <string.h>

void absoluto (int x[10])
{
    int i;
    for (i=0; i<10; i++)
    {
        if (x[i]<0){
            x[i]=-(x[i]);
        }
        printf("\nVetor[%d]: %d", i, x[i]);

    }
}



main (){
    int vet[10], i;

    for (i=0; i<10; i++)
        {
        printf("\nVetor [%d]:", i);
        scanf ("%d", &vet[i]);
        }

    absoluto(vet);

}
