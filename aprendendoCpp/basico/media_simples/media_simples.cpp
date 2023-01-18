int main()
{
    float nota1, nota2, media;
    
    printf("Entre com a primeira nota: ");
    scanf("%f", &nota1);
    printf("Entre com a segunda nota: ");
    scanf("%f", &nota2);
    
    media = (nota1+nota2)/2;
    printf("A média do aluno é %f",media);
    
    return 0;
}
