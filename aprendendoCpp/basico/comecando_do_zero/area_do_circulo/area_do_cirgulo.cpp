#include <iostream>

int main()
{
    float area, n, raio;
    n = 3.14159;

    printf("Entre com o raio: ");
    scanf("%f", &raio);
    area = n * (raio*raio);
    
    printf("A área do círculo é %f",area);
    
    return 0;
}