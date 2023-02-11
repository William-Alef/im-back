#include <iostream>

int main()
{
    double nota1, nota2, nota3, nota4, media, exame;

    printf("Entre com a primeira nota: ");
    scanf("%lf", &nota1);
    
    printf("Entre com a segunda nota: ");
    scanf("%lf", &nota2);
    
    printf("Entre com a terceira nota: ");
    scanf("%lf", &nota3);
    
    printf("Entre com a quarta nota: ");
    scanf("%lf", &nota4);
    media = (nota4 + nota3 + nota2 + nota1)/4;

    if(media >= 7){
        printf("Media: %.1lf", media);
        printf("\nAluno aprovado.");
    }
    else if(media > 5.0 && media < 6.9){
        printf("\nMedia: %.1lf", media);
        printf("\nAluno em exame.");
        printf("\n\nEntre com a nota do exame: ");
        scanf("%lf", &exame);
        
        exame += media/2;
        
        if(exame >= 5){
            printf("\nAluno aprovado.");
            printf("\nMedia final: %.1lf", exame);
        }else{
            printf("\nAlno reprovado.");
            printf("\nMedia final: %.1lf", exame);
        }
    }
    else{
        printf("\nAluno reprovado.");
    }
    
    return 0;
}