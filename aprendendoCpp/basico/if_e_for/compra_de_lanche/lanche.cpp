#include <iostream>

int main()
{
    double escolha, quantidade, conta;
    
    printf("Entre com o codigo: ");
    scanf("%lf", &escolha);
    
    printf("Quantidade: ");
    scanf("%lf", &quantidade);
    
    if(escolha == 1){
        conta += 4.00;
    }
    else if(escolha == 2){
        conta += 4.50;
    }
    else if(escolha == 3){
        conta += 5.00;
    }
    else if(escolha == 4){
        conta += 2.00;
    }
    else if(escolha == 5){
        conta += 1.50;
    }
    
    printf("Total a pagar: R$ %.2lf", quantidade * conta);
    
    
    
    return 0;
}
