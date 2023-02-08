#include <iostream>

int main()
{
    int numFuncionario;
    float horasTrab, valPorHora, salario;
    
    printf("Entre com o número do funcionário: ");
    scanf("%d", &numFuncionario);
    printf("Entre o valor por hora: ");
    scanf("%f", &valPorHora);
    printf("Entre com as horas trabalhadas: ");
    scanf("%f", &horasTrab);

    salario = (horasTrab * valPorHora);
    printf("\nNúmero do funcionário: %d \nSalário: R$ %.2f", numFuncionario, salario);

    return 0;
}