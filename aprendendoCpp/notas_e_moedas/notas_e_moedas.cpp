#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    double guardaresto, valor, m1, m50, m25, m10, m05, m01, n100, n50, n20, n10, n5, n2;
    printf("Entre com o valor: ");
    scanf("%lf", &valor);
    
    //declarando notas
    n100 = valor/100;
    guardaresto = fmod(valor, 100);

    n50 = guardaresto/50;
    guardaresto = fmod(guardaresto, 50);
    
    n20 = guardaresto/20;
    guardaresto = fmod(guardaresto, 20);
    
    n10 = guardaresto/10;
    guardaresto = fmod(guardaresto, 10);
    
    n5 = guardaresto/5;
    guardaresto = fmod(guardaresto, 5);
    
    n10 = guardaresto/2;
    guardaresto = fmod(guardaresto, 2);
    
    //declarando moedas
    m1 = guardaresto/1;
    guardaresto = fmod(guardaresto, 1);
    
    m50 = guardaresto/0.5;
    guardaresto = fmod(guardaresto, 0.5);
    
    m25 = guardaresto/0.25;
    guardaresto = fmod(guardaresto, 0.25);

    m10 = guardaresto/0.10;
    guardaresto = fmod(guardaresto, 0.10);
    
    m05 = guardaresto/0.05;
    guardaresto = fmod(guardaresto, 0.05);  
    
    m01 = guardaresto/0.01;
    guardaresto = fmod(guardaresto, 0.01);    
    
    printf("Notas:\n%d nota(s) de 100.00\n%d nota(s) de R$ 50.00\n%d nota(s) de R$ 20.00\n%d nota(s) de R$ 10,00\n%d nota(s) de R$ 5,00\n%d nota(s) de R$ 2,00\n\nMoedas:\n%d moeda(s) de R$ 1,00\n%d moeda(s) de R$ 0,50\n%d moeda(s) de R$ 0,25\n%d moeda(s) de R$ 0,10\n%d moeda(s) de R$ 0,05\n%d moeda(s) de R$ 0,01", int(n100), int(n50), int(n20), int(n10), int(n5), int(n2), int(m1), int(m50), int(m25), int(m10), int(m05), int(m01));
    

}
