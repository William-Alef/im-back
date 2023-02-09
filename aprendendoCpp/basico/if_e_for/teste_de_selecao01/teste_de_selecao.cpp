#include <iostream>
#include <cmath>
int main()
{
    int a, b, c, d;
    
    printf("Entre com o valor de A: ");
    scanf("%d", &a);
    
    printf("Entre com o valor de B: ");
    scanf("%d", &b);
    
    printf("Entre com o valor de C: ");
    scanf("%d", &c);
    
    printf("Entre com o valor de D: ");
    scanf("%d", &d);
    
    if(c && d >= 0 && b > c && d > a && c+d > a+b && a % 2 == 0){
        printf("\nValores aceitos");
    }else{
        printf("\nValores não aceitos");
    }

    return 0;
}