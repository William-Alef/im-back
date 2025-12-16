# Requisitos do exercício:

## 1. Adicionando conteúdo à página "Sobre mim"

Nesta atividade, você adicionará o conteúdo principal na página "Sobre mim" do seu projeto. Primeiro, no arquivo `about.html`, localize o `<main>` vazio e crie uma `<section>` para armazenar o conteúdo da página. Dentro desta `<section>`, adicione um `<h1>` com o texto "**Sobre mim**" e dois parágrafos (`<p>`), utilizando o atalho `p*2` seguido de "Enter" para criar ambos. Em seguida, volte ao Figma para copiar o texto de "**Lorem ipsum**" e cole-o nos parágrafos correspondentes. Por fim, adicione uma imagem ao lado dos parágrafos, copiando o código da imagem da página inicial e colando-o no `about.html`.

## 2. Aplicando estilos à página "Sobre mim"

Após adicionar o conteúdo principal, você deverá aplicar estilos à página "Sobre mim". Primeiro, atribua classes apropriadas aos elementos dentro do `<main>`:

* Adicione a classe `"apresentacao"` ao `<main>`.
* Adicione a classe `"apresentacao__conteudo"` à `<section>`.
* Adicione a classe `"apresentacao__conteudo__titulo"` ao `<h1>`.
* Adicione a classe `"apresentacao__conteudo__texto"` aos parágrafos.

Utilize a técnica de seleção múltipla (segurando "**Alt**" e clicando) para adicionar a mesma classe a ambos os parágrafos simultaneamente. Após adicionar as classes, salve o arquivo e visualize no navegador para conferir o alinhamento e a estilização dos elementos.

## 3. Definindo variáveis de cores no CSS

Nesta atividade, você vai definir variáveis globais no CSS para as cores principais do seu projeto. Abra o arquivo `style.css` no VS Code e adicione a pseudoclasse `:root` no início do arquivo, acima de todos os blocos de código. Dentro do `:root`, defina três variáveis:

* `--cor-primaria` para a cor preta (`#000000`).
* `--cor-secundaria` para o branco (`#F6F6F6`).
* `--cor-terciaria` para o azul ciano (`#22D4FD`).

Este processo permite que você altere facilmente as cores principais do projeto alterando apenas essas variáveis.

## 4. Aplicando as variáveis de cores no projeto

Depois de definir as variáveis de cores, o próximo passo é aplicá-las em todo o projeto. Procure no arquivo `style.css` onde as cores originais foram usadas (utilize "**Ctrl + F**" para pesquisar pelas cores hexadecimais). Substitua todas as ocorrências das cores hexadecimais pelas variáveis correspondentes que você definiu. Por exemplo, substitua todas as ocorrências de `#000000` por `var(--cor-primaria)`. Isso garantirá que, se as cores principais precisarem ser alteradas no futuro, você só terá que alterá-las uma vez nas variáveis globais, simplificando a manutenção do código.

## 5. Aplicando variáveis CSS para cores e fontes

Nesta atividade, você irá revisar e aplicar as variáveis CSS criadas para gerenciar as cores e fontes do seu projeto. Inicie abrindo o arquivo `style.css` e substitua os valores hexadecimais das cores e das fontes pelas variáveis CSS correspondentes. Por exemplo, onde você encontra a cor `#22D4FD`, substitua por `var(--cor-terciaria)`. Faça isso para todas as instâncias onde as cores primária, secundária, terciária e *hover* são utilizadas, bem como para as fontes primária e secundária.

## 6. Testando a flexibilidade das variáveis CSS com uma nova paleta de cores

Nesta atividade, você testará a flexibilidade das variáveis CSS alterando a paleta de cores do projeto. Acesse o site **Color Hunt** e escolha uma nova paleta de cores. Copie os valores hexadecimais das cores escolhidas e substitua-os nas variáveis CSS dentro do `:root` no arquivo `style.css`. Por exemplo, altere o valor de `--cor-primaria` para o novo valor de cor escolhido. Após alterar todas as cores, salve o arquivo e visualize o projeto no navegador para ver as mudanças. Esta atividade demonstrará como as variáveis CSS podem facilitar a manutenção e alteração do design de um projeto.
