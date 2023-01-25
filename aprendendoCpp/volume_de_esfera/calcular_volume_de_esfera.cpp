#include <iostream>
#include <math.h>

int main()
{
    int raio;
    float pi=3.14159, volume;
    
    printf("Entre com o raio: ");
    scanf("%d", &raio);
    volume = 4/3.0 * (pi * pow(raio, 3));
    printf("Volume = %.3f", volume);
    
    return 0;
}