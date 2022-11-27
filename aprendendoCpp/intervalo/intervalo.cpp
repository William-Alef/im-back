#include <iostream>
#include <math.h>
using namespace std;

int main(){

    double valor;
    
    printf("Entre com o valor: ");
    scanf("%lf", &valor);
    
    if(valor >= 0 && valor <= 25){
        printf("Intervalo [0, 25]");
    }
    if(valor > 25 && valor <= 50){
        printf("Intervalo [25, 50]");
    }
    if(valor > 50 && valor <= 75){
        printf("Intervalo [50, 75]");
    }
    if(valor > 75 && valor < 100){
        printf("Intervalo [75, 100]");
    }else{
        printf("Fora do escopo.");
    }
}