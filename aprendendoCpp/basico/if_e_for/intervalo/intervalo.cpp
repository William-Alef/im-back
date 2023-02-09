#include <iostream>

int main()
{
    double valor;

    printf("Entre com o valor: ");
    scanf("%lf", &valor);
    if (valor > 0 && valor <= 25){
        printf("intervalo [0,25]");
    }
    else if(valor > 25 && valor <= 50){
        printf("Intervalo [25,50]");
    }
    else if(valor > 50 && valor <= 75){
        printf("Intervalo [50,75]");
    }
    else if(valor > 75 && valor <= 100){
        printf("Intervalo [75,100]");
    }
    else if(valor < 0 || valor > 100){
        printf("Fora do intervalo!");
    }
    return 0;
}