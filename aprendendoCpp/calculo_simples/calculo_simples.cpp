#include <iostream>

int main()
{
    int cod1, cod2, quant1, quant2;
    float soma;
    
    printf("Entre com o primeiro codigo: ");
    scanf("%d", &cod1);
    printf("Entre com a quantidade: ");
    scanf("%d", &quant1);
    printf("Entre com o segundo codigo: ");
    scanf("%d", &cod2);
    printf("Entre com a quantidade: ");
    scanf("%d", &quant2);
    
    soma = (quant1 * 5.30) + (quant2 * 5.10);
    printf("\nValor a pagar: R$ %.2f", soma);
    
    return 0;
}
