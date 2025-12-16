# Requisitos do exercício

## 1. Ajustando o layout para telas menores

Você está trabalhando em um projeto de portfólio e percebeu que, ao diminuir o tamanho da tela, os elementos começam a se comportar de forma indesejada, como a imagem colada ao texto.  

Seu desafio é ajustar o layout da página para que, ao diminuir o tamanho da tela, haja um espaço adequado entre os elementos. Para isso, utilize a propriedade `gap` no CSS para criar um espaçamento entre o conteúdo e a imagem dentro da classe `.apresentacao`.  

---

## 2. Implementando media queries para mudança de layout

Quando a largura da tela atinge cerca de 1300px, você nota que a imagem na página do portfólio fica isolada no lado direito. Agora, o seu objetivo é alterar o layout para que, em telas menores que `1023px`, a imagem seja posicionada **acima do texto**, seguindo o design mobile no Figma.  

Para isso, implemente uma **media query** no CSS que altere a disposição dos elementos da classe `.apresentacao` para uma coluna (`flex-direction: column`) quando a tela for menor que `1023px`.  

---

## 3. Refinando o layout responsivo

Agora que você ajustou o layout para telas menores, percebeu que a ordem dos elementos na classe `.apresentacao` não está conforme o design do Figma, onde a imagem deveria aparecer **acima do texto**.  

Sua tarefa é alterar a ordem dos elementos dentro dessa classe quando a tela estiver abaixo de `1200px` de largura. Utilize a propriedade `flex-direction` no CSS, com o valor `column-reverse`, dentro de uma media query, para inverter a ordem dos elementos.  

---

## 4. Ajustando o cabeçalho para telas menores

Neste desafio, você precisa ajustar o cabeçalho da página do portfólio para dispositivos com telas menores. Atualmente, o cabeçalho (`header`) está muito para a esquerda e quebra em certos pontos.  

Altere o `padding` da classe `.cabecalho` no CSS para que o cabeçalho fique **mais centralizado** e com um espaço adequado na parte superior da tela, em conformidade com o design mobile no Figma.  


---

## 5. Centralizando itens do menu em telas menores

Agora que o padding do cabeçalho foi ajustado, seu próximo passo é **centralizar os itens do menu**, como "Home" e "Sobre mim", que estão dentro da classe `.cabecalho__menu`.  

Para centralizar os itens, utilize o **Flexbox** na classe `.cabecalho__menu`. Verifique se a propriedade `display: flex` já está aplicada e adicione `justify-content: center` para alinhar os itens no centro da tela.  


---

## 6. Refinando o design responsivo do cabeçalho

Por fim, verifique e refine o design do cabeçalho para telas menores.  

Faça os ajustes necessários no `padding` e nas propriedades do **Flexbox** para que o cabeçalho fique visualmente alinhado com o design no Figma. Teste diferentes valores de `padding` e ajuste a propriedade `justify-content` para obter o melhor resultado.  
