/*Criando a lista, percorrendo e verificando se o resto da divisão por 2 é 0, então se o resultado for True, 
ou seja, se for par será informado ao usuário. Iniciando com o Foreach*/
using System.ComponentModel;
using System.Data.Common;

List<int>listaDeInteiros = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
};

foreach (int numero in listaDeInteiros)
{
    if(numero %2 == 0)
    {   
        Console.Write($"\nLista percorrida pelo Foreach{numero}");
    };
}

//Percorrendo a lista com For.

for(int i=0; i < listaDeInteiros.Count; i++)
{
    if(listaDeInteiros[i] %2 == 0){
        Console.Write($"\n\nLista percorrida pelo For{listaDeInteiros[i]}");
    };
};