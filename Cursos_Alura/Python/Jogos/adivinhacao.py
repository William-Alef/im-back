from functools import total_ordering
from random import Random, random
import random;

def jogar():
    print("*********************************")
    print("Bem vindo ao Jogo de Adivinhação!")
    print("*********************************\n")

    numero_secreto = random.randrange(1, 101)
    chances = 0;
    pontos = 1000;

    print('Dificuldades:')
    print('(1)Fácil - (2)Médio - (3)Difícil')
    nivel = int(input('Escoha a dificuldade: '))
    print('')

    if(nivel == 1):
        chances = 20
    elif(nivel == 2):
        chances = 10
    else:
        chances = 5
    '''
    #Utilizando o laço While
    chances = 3;
    while(chances >= 1):
        print('Número de tentativas: {} de {}'.format(chances,'3'))
        chute = int(input("Entre com um número: "))
        acertou = chute == numero_secreto;
        maior = chute > numero_secreto;
        menor = chute < numero_secreto;
        
        if (acertou):
            print("Você acertou!")
            break;
        else:
            print("Você errou!") 
            
            if(maior):
                print('O seu chute foi maior que o número sorteado!')   
            elif(menor):
                print('O seu chute foi menor que o numero sorteado!')
            chances = chances - 1;
            print('')
    print('Fim do jogo')'''

    #Utilizando o laço For
    for rodada in range(0, chances):
        print(f'Número de tentativas: {rodada + 1} de {chances}')
        chute = int(input("Entre com um número de 0 a 100: "))
        print('')
        acertou = chute == numero_secreto;
        maior = chute > numero_secreto;
        menor = chute < numero_secreto;
        
        if (chute < 1 or chute > 100):
            print('Você deve entrar com um número entre 0 e 100!\n')
            continue;
            
        if (acertou):
            print(f'Você acertou e finalizou com {pontos}!')
            break;
        else:
            print("Você errou!\n") 
            if(maior):
                print('O seu chute foi maior que o número sorteado!')  
                if (rodada == chances):
                    print(f'O número secreto era {numero_secreto} e você terminou com {pontos} pontos!')
                print('') 
            elif(menor):
                print('O seu chute foi menor que o numero sorteado!')
                if (rodada == chances):
                    print(f'O número secreto era {numero_secreto} e você terminou com {pontos} pontos!\n')
            pontos = abs(pontos - chute)
    
    print('Fim do jogo')

if(__name__ == '__main__'):    
    jogar()