#include <iostream>

int main()
{
    int valor1, valor2, produto;

    printf("Entre com o primeiro valor: ");
    scanf("%d", &valor1);
     printf("Entre com o segundo valor: ");
    scanf("%d", &valor2);
    
    produto = valor1*valor2;
    printf("O produto é %d",produto);
    
    return 0;
}