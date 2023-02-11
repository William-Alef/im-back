#include <iostream>

int main()
{
    double eixoX, eixoY;
    
    printf("Entre com o eixo X: ");
    scanf("%lf", &eixoX);
    
    printf("Entre com o eixo Y: ");
    scanf("%lf", &eixoY);
    
    if(eixoX == 0 && eixoY == 0){
        printf("Origem");
    }
    else if(eixoX >= 0.1 && eixoY >= 0.1){
        printf("Q1");
    }
    else if(eixoX >= 1 && eixoY <= -1){
        printf("Q4");
    }
    else if(eixoX <= -1 && eixoY <= -1){
        printf("Q3");
    }
    else if(eixoX <= -1 && eixoY >= 0){
        printf("Q2");
    }
    
    return 0;
}