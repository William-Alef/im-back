#include <iostream>
#include <math.h>
using namespace std;

int main(){

    double hotdog = 4.00, xsalada = 4.50, xbacon = 5.00, torrada = 2.00, refrigerante = 1.50, conta;
    int pedido, quantidade;
    
    printf("Codigo   Item   Preço\n1     Cachorro Quente     R$4,00\n2     X-Salada            R$4,50\n3     X-Bacon             R$5,00\n4     Torrada simples     R$2,00\n5     Refrigerante        R$1,50\n\nEntre com o código desejado: ");
    scanf("%d", &pedido);
    printf("Quantidade desejada: ");
    scanf("%d", &quantidade);
    
    if (pedido == 1){
        conta = quantidade * hotdog;
        printf("\n\n%dx Cahorro Quente.\nTotal: %.2lf", quantidade, conta);
    }
    else if(pedido == 2){
        conta = quantidade * xsalada;
        printf("\n\n%dx X-Salada.\nTotal: %.2lf", quantidade, conta);
    }
    else if(pedido == 3){
        conta = quantidade * xbacon;
        printf("\n\n%dx X-Bacon.\nTotal: %.2lf", quantidade, conta);
    }
    else if(pedido == 4){
        if(quantidade > 1){
            conta = quantidade * torrada;
            printf("\n\n%dx Torradas simples\nTotal: %.2lf", quantidade, conta);
        }
        else{
            conta = quantidade * torrada;
            printf("\n\n1x Torrada simples\nTotal: %.2lf", conta);
        }
    }
    else if(pedido == 5){
        if(quantidade > 1){
            conta = quantidade * refrigerante;
            printf("\n\n%dx refrigerantes\nTotal: %.2lf", quantidade, conta); 
        }
        else{
            conta = quantidade * refrigerante;
            printf("\n\n1x refrigerante\nTotal: %.2lf", conta);
        }
    }
}

