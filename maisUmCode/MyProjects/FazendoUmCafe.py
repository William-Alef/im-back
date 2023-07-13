# Este é um programa que ensina detalhadamente uma pessoa a fazer um café, demonstrando como o PC está fazendo o mesmo.
# Agradeço imensamente ao meu professor Fernandino por me inspirar a fazer este algoritimo.

import time
from random import randint

# variáveis / Objetos e ingredientes necessários para o preparo, acomodamento e tranferência de café
garrafa = None
cafe_na_garrafa = 0
quantidade_da_agua = 200
temperatura_da_agua = 20
filtro = None
suporte_filtro = None
po_de_cafe = 100 #100 gramas do pó de café
fogao = None
fogao_ligado = False
tipo_fogao = None
informou_fogao = False
chaleira = None
tipo_ignicao = None
ignicao = ['isqueiro', 'fósforo']
falhando_ignicao = None
servir_cafe = None
xicara = 0

#colocando a agua na chaleira
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

        while(falhando_ignicao != 1):
            falhando_ignicao = (randint(0, 3))
            print('Esqueiro falhou!\nTentando novamente...', 2*"\n")
        fogao_ligado = True
        print('Fogão ligado!')
    elif (tipo_ignicao == '2'):
        print(f'\nLigando o fogão com o {ignicao[1]}...\n')

        while(falhando_ignicao != 1):
            falhando_ignicao = (randint(0, 3))
            print(f'{ignicao[1]} falhou!\nTentando novamente...', 2*"\n")
        fogao_ligado = True
        print('Fogão ligado!')
else:
    while(falhando_ignicao != 1):
        falhando_ignicao = (randint(0, 3))
        print('\nO figão não ligou!\nTentando novamente...')
    fogao_ligado = True
    print('\nFogão ligado!')

# Colocando a chaleira no fogão
print('Colocando a chaleira na boca do fogão')
fogao = chaleira

# Preparando a garrada para receber o café
print('Adicionando o filtro de café dentro do suporte')
time.sleep(0.1)
suporte_filtro = filtro
print('Adicionando o pó de café no filtro')
time.sleep(0.1)
filtro = po_de_cafe
print('Adicionando o suporte de filtro em cima da garrafa de café')
time.sleep(0.1)
garrafa = suporte_filtro

# Aquecendo e verificando a temperatura da água para desligar o fogão e seguir com o processo
while(temperatura_da_agua <= 100):
    
    print(f'Temperatura da água: {temperatura_da_agua}')
    time.sleep(0.2)
    temperatura_da_agua += 5
print('\n\nA água ferveu!')

fogao_ligado = False
print('\nRemovendo a chaleira do fogão')
fogao = None

# Transferindo a água para passar o café
print('Colocando a água por cima do pó em movimentos circulares até encher o suporte e filtro. A água deve ficar dois dedos abaixo da boca do suporte...')
time.sleep(1)

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
print('\nToda a água que foi despejada já acabou!')

# Hora de remover o suporte e fechar a garrafa!
print('Removendo o suporte de cima da garrafa e fechando da garrafa')
del suporte_filtro
del filtro

servir_cafe = input('\nO café está pronto!!\nGsotaria de Servir agora?\n(S / N): ')
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