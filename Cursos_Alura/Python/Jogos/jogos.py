import forca
import adivinhacao

def escolhe_jogo():
    print('\nOlá, jogador')
    print('Escolha o jogo da vez:\n')
    print('(1)Advinhação ou (2)Jogo da forca')
    jogo = int(input('Entre com o número equivalente ao jogo desejado: '))

    if (jogo == 1):
        print('Jogando Advinhação')
        adivinhacao.jogar()
    elif (jogo == 2):
        print('Jogando Forca')
        forca.jogar()
        
if(__name__ == '__main__'):
    escolhe_jogo()
    