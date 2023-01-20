#include <iostream>

int main()
{
    float distancia, combustivelGasto, total;
    
    printf("Entre com a distância percorrida: ");
    scanf("%f", &distancia);
    printf("Entre com a quantidade de gasolina gasta: ");
    scanf("%f", &combustivelGasto);
    printf("%.3f KM/L.", total = (distancia/combustivelGasto));
    return 0;
}
