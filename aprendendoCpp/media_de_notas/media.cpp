#include <iostream>
#include <math.h>
using namespace std;

int main(){

    double nota1, nota2, nota3, nota4, media, exame;
    
    printf("Entre com a primeira nota: ");
    scanf("%lf", &nota1);
    printf("Entre com a segunda nota: ");
    scanf("%lf", &nota2);
    printf("Entre com a terceira nota: ");
    scanf("%lf", &nota3);
    printf("Entre com a quarta nota: ");
    scanf("%lf", &nota4);
    
    media = (nota1 + nota2 + nota3 + nota4) / 4;
    
    if(media >= 7.0){
        printf("\nMedia: %.01lf\n",  media);
        printf("Aluno aprovado.");
    }
    else if(media < 5.0){
        printf("\nMedia: %.01lf\n",  media);
        printf("Aluno reprovado.");
    }
    else if(media > 4.9 && media < 7.0){
        printf("\nMedia: %.01lf\n",  media);
        printf("Aluno em exame.");
    }
}