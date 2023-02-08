#include <iostream>

int main()
{
    int valor1, valor2, valor3, valor4, diferenca;
    
    printf("Entre com o primeiro valor: ");
    scanf("%d", &valor1);
    printf("Entre com o segundo valor: ");
    scanf("%d", &valor2);
    printf("Entre com o terceiro valor: ");
    scanf("%d", &valor3);
    printf("Entre com o quarto valor: ");
    scanf("%d", &valor4);   
    
    diferenca = (valor1*valor2) - (valor3 * valor4);
    printf("\nA diferença entre os valores é %d", diferenca);

    return 0;
}
