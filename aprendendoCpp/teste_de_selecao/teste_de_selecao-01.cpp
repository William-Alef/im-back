#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    int a, b, c, d;
    printf("Entre com o primeiro valor: ");
    scanf("%d", &a);
    
    printf("Entre com o segundo valor: ");
    scanf("%d", &b);
    
    printf("Entre com o terceiro valor: ");
    scanf("%d", &c);
    
    printf("Entre com o quarto valor: ");
    scanf("%d", &d);
    
    if (b > c && d > a && c+d > a+b && c > 0 && d > 0 && a % 2 == 0){
        printf("Valores aceitos");
    }else{
        printf("Valores não aceitos");
    }
}