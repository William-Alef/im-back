#include <iostream>

int main()
{
    float nota1, nota2, nota3, media;
    
    printf("Entre com a primeira nota: ");
    scanf("%f", &nota1);
    printf("Entre com a segunda nota: ");
    scanf("%f", &nota2);
    printf("Entre com a terceira nota: ");
    scanf("%f", &nota3);
    
    media = (nota1+nota2+nota3)/3.0;
    printf("A média do aluno é %.1f",media);
    
    return 0;
}