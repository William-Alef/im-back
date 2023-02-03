#include <iostream>

int main()
{
    float baseA, baseB, altura, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;
    
    printf("Entre com base A: ");
    scanf("%f", &baseA);
    printf("Entre com base B: ");
    scanf("%f", &baseB);
    printf("Entre com a altura: ");
    scanf("%f", &altura);
    
    triangulo = (baseA * altura)/2;
    circulo = pi * (altura * altura);
    trapezio = ((baseA + baseB) * altura)/2;
    quadrado = baseB * baseB;
    retangulo = baseA * altura;
    
    printf("\nTriângulo: %.3f\n", triangulo);
    printf("Circulo: %.3f\n", circulo);
    printf("Trapezio: %.3f\n", trapezio);
    printf("Quadrado: %.3f\n", quadrado);
    printf("Retângulo: %.3f", retangulo);

    return 0;
}