# Este é um programa que ensina detalhadamente uma pessoa a fazer um café, demonstrando como o PC está fazendo o mesmo.
# Agradeço imensamente ao meu professor Fernandino por me inspirar a fazer este algoritimo.

import time
from random import randint

# Variáveis / Objetos e ingredientes necessários para o preparo, acomodamento e tranferência de café
garrafa = None
cafe_na_garrafa = 0
quantidade_da_agua = 200
temperatura_da_agua = 20
filtro = None
suporte_filtro = None
po_de_cafe = 100 #100 gramas do pó de café
fogao = None
cafeteira = (False, None, 0, None, 0) #[0] Status de ligada ou desligada. [1] Compartimento para receber o filto. [2] Compartimento para acomodar a água. [3] Compartimento para as capsulas. [4] Compartimento para o café.
cafeteira_lista = list(cafeteira)
fogao_ligado = False
tipo_fogao = None
informou_fogao = False
chaleira = None
tipo_ignicao = None
ignicao = ['isqueiro', 'fósforo']
falhando_ignicao = None
servir_cafe = None
xicara = 0
modo_de_preparo = 0

# Criando funções para a reutilização durante o código
def falhando_ignicao(inicio_num, maximo_num):
    numero_randomico = randint(inicio_num, maximo_num)
    return(numero_randomico)

def preparando_garrafa(suporte_filtro, filtro, po_de_cafe, garrafa):
    print('Adicionando o filtro de café dentro do suporte')
    time.sleep(0.1)
    suporte_filtro = filtro
    print('Adicionando o pó de café no filtro')
    time.sleep(0.1)
    filtro = po_de_cafe
    print('Adicionando o suporte de filtro em cima da garrafa de café')
    time.sleep(0.1)
    garrafa = suporte_filtro

def ferver_agua(temperatura_da_agua):
    while(temperatura_da_agua <= 100):
        
        print(f'Temperatura da água: {temperatura_da_agua}')
        time.sleep(0.2)
        temperatura_da_agua += 5
    print('\n\nA água ferveu!')

def passar_cafe_cafeteira_manual(quantidade_da_agua, cafe_na_garrafa):
    while(quantidade_da_agua != 0):
        
        print('\nEsperando o café passar...')
        time.sleep(1)
        quantidade_da_agua -= 100
        cafe_na_garrafa += 100
        print('Toda a água que foi despejada já acabou!\n')
        
        if(quantidade_da_agua == 100):
            print('Adicionando mais água')
            time.sleep(1)

            quantidade_da_agua -= 100
            cafe_na_garrafa += 100

            print('Esperando o café passar...')
            time.sleep(1.7)

def passar_cafe_cafeteira_simples(cafeteira_lista):
    while(cafeteira_lista[2] != 0):
        
        print('\nEsperando o café passar...')
        time.sleep(1)
        cafeteira_lista[2]-= 240
        cafeteira_lista[4]+= 240
        print('Toda a água que foi despejada já acabou!\n')
        
        if(cafeteira_lista[2] <= 240):
            print('Adicionando mais água')
            time.sleep(1)

            quantidade_da_agua -= 240
            cafe_na_garrafa += 240

            print('Esperando o café passar...')
            time.sleep(1.7)
        
def servir_cafe_cafeteira_manual(servir_cafe, cafe_na_garrafa, xicara):
    while (servir_cafe.upper() == 'S' and cafe_na_garrafa != 0):
        print('\nColocando o café da garrafa na xicara...')
        time.sleep(0.5)
        cafe_na_garrafa -= 100
        xicara += 100

        while (servir_cafe.upper() == 'S' and cafe_na_garrafa != 0):
            servir_cafe = input('\nGostaria de servir outra xicara?\n(S / N): ')

            if(servir_cafe.upper() == 'S'):
                print('\nServindo outra rodada de café!')
                cafe_na_garrafa -= 100
                xicara += 100

                if (cafe_na_garrafa == 0):
                    print('\nO café acabou!')

            elif(servir_cafe.upper() == 'N'):
                print('\nSem problemas!')
        print('Fim do algoritimo')

def servir_cafe_cafeteira_simples(cafeteira_lista, xicara):
    while (servir_cafe.upper() == 'S' and cafeteira_lista[4] != 0):
        print('\nColocando o café da garrafa na xicara...')
        time.sleep(0.5)
        cafeteira_lista[4] -= 120
        xicara += 120

        while (servir_cafe.upper() == 'S' and cafeteira_lista[4] != 0):
            servir_cafe = input('\nGostaria de servir outra xicara?\n(S / N): ')

            if(servir_cafe.upper() == 'S'):
                print('\nServindo outra rodada de café!')
                cafeteira_lista[4] -= 120
                xicara += 120

                if (cafeteira_lista[4] == 0):
                    print('\nO café acabou!')

            elif(servir_cafe.upper() == 'N'):
                print('\nSem problemas!')
        print('Fim do algoritimo')

modo_de_preparo = int(input('Qual será o método para fazer o café:\n(1) Cafeteira elétrica simples\n(2) Cafeteira de capsula\n(3) Forma manual\n\nResposta:'))
if(modo_de_preparo == 1):
    
    print('\nPreparando a cafeteira para fazer o café...')
    time.sleep(0.4)

    print('Colocando o filtro na cafeteira...')
    time.sleep(0.4)
    cafeteira = filtro

    print('Colocando o pó de café no filtro...\n')
    time.sleep(0.4)
    filtro = po_de_cafe

    print('Colocando o filtro de café na cafeteira...')
    time.sleep(0.4)
    cafeteira_lista[1] = filtro

    print('Adicionando água no compartimento...')
    time.sleep(0.4)
    cafeteira_lista[2] = 440

    print("Ligando a cafeteira...")
    time.sleep(0.4)
    cafeteira_lista[0] = True

    # Aquecendo e verificando a temperatura da água para desligar o fogão e seguir com o processo
    ferver_agua(temperatura_da_agua)

    # Passando o café
    passar_cafe_cafeteira_simples(cafeteira_lista)

    # Servindo café
    servir_cafe_cafeteira_simples(cafeteira_lista, xicara)

elif (modo_de_preparo == 2):
    print('')

elif (modo_de_preparo == 3):

    #colocando a água na chaleira
    chaleira = temperatura_da_agua

    # Verificando qual o tipo do fogão e confirmando que o mesmo foi informado corretamente
    while(informou_fogao != True):

        tipo_fogao = input('Digite o número que indica qual o tipo do seu fogão:\n(1) Fogão gás\n(2) Fogão a elétrico\n\nSua resposta: ')
        if (tipo_fogao == '1' or tipo_fogao == '2'):
            informou_fogao = True
        else:
            print(5*'\n')
            print('Desculpe, esta não é uma opção válida!')  
    if (tipo_fogao == '1'):
        tipo_ignicao = input('Digite o número que indica qual o tipo do objeto para ligar o fogão:\n(1) Isqueiro\n(2) Fósforo\n\nSua resposta: ')
        
    # Criando um sistema que ligue o fogão, mas que tenha a probabilidade de falhar.
        if tipo_ignicao == '1':
            print(f'\nLigando o fogão com o {ignicao[0]}...\n')

            while(falhando_ignicao(0, 3) != 1):
                falhando_ignicao(0, 3)
                print('Esqueiro falhou!\nTentando novamente...', 2*"\n")
            fogao_ligado = True
            print('Fogão ligado!')
        elif (tipo_ignicao == '2'):
            print(f'\nLigando o fogão com o {ignicao[1]}...\n')

            while(falhando_ignicao(0, 3) != 1):
                falhando_ignicao(0, 3)
                print(f'{ignicao[1]} falhou!\nTentando novamente...', 2*"\n")
            fogao_ligado = True
            print('Fogão ligado!')
    else:
        while(falhando_ignicao(0, 3) != 1):
            falhando_ignicao(0, 3)
            print('\nO figão não ligou!\nTentando novamente...')
        fogao_ligado = True
        print('\nFogão ligado!')

    # Colocando a chaleira no fogão
    print('Colocando a chaleira na boca do fogão')
    fogao = chaleira

    # Preparando a garrada para receber o café
    preparando_garrafa(suporte_filtro, filtro, po_de_cafe, garrafa)

    # Aquecendo e verificando a temperatura da água para desligar o fogão e seguir com o processo
    ferver_agua(temperatura_da_agua)

    # Desligando o fogão
    fogao_ligado = False

    print('\nRemovendo a chaleira do fogão')
    fogao = None

    # Transferindo a água para passar o café
    print('Colocando a água por cima do pó em movimentos circulares até encher o suporte e filtro. A água deve ficar dois dedos abaixo da boca do suporte...')
    time.sleep(1)

    #Passando o café
    passar_cafe_cafeteira_manual(quantidade_da_agua, cafe_na_garrafa)

    # Hora de remover o suporte e fechar a garrafa!
    print('Removendo o suporte de cima da garrafa e fechando da garrafa')
    del suporte_filtro
    del filtro

    servir_cafe = input('\nO café está pronto!!\nGsotaria de Servir agora?\n(S / N): ')
    servir_cafe_cafeteira_manual(servir_cafe, cafe_na_garrafa, xicara)

print('Fim do algoritimo')