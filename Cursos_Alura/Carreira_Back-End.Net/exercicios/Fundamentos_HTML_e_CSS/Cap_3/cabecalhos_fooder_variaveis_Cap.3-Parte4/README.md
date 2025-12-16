# Requisitos do exercício:

## 1. Estilizando o cabeçalho com CSS

Imagine que você trabalha com desenvolvimento front-end em um projeto de website. O seu desafio é estilizar o cabeçalho da página de acordo com as especificações fornecidas. Utilize o arquivo `style.css` para aplicar as propriedades CSS no cabeçalho.

## 2. Ajustando o espaçamento do conteúdo

Agora, como quem trabalha com desenvolvimento, seu próximo desafio é ajustar o espaçamento do conteúdo da página para que se alinhe corretamente com o cabeçalho.

## 3. Criando e navegando para a página "Sobre mim"

Você está trabalhando em um projeto de site pessoal e precisa adicionar uma página "Sobre mim". Para isso:

1.  Crie um novo arquivo HTML, chamado `about.html`.
2.  Configure um link no menu de navegação do seu site principal (`index.html`) para redirecionar para esta nova página.
3.  Ajuste o cabeçalho da página `about.html` para que o título da aba seja "**Sobre mim**".
4.  Adicione um `<h1>` com o texto "**Sobre mim**" no corpo da nova página.

Certifique-se de que a navegação entre a página principal e a página "Sobre mim" esteja funcionando corretamente.

## 4. Ajustando a estilização após reorganização de arquivos

Você percebeu que, após mover o arquivo `styles.css` para uma nova pasta chamada `"styles"`, a estilização do seu site foi perdida. Para corrigir isso:

1.  Atualize o caminho do arquivo CSS no seu arquivo `index.html`.
2.  No arquivo `styles.css`, remova o sublinhado dos links no cabeçalho do site.

Após estas correções, verifique se a estilização foi aplicada corretamente e se os links do cabeçalho não estão mais sublinhados.

## 5. Estruturando a página "Sobre mim" com cabeçalho e rodapé

Nesta atividade, você irá estruturar a página "Sobre mim" do seu projeto, reutilizando o cabeçalho e o rodapé da página inicial (`index.html`).

1.  Copie o `<header>` e o `<footer>` do `index.html` e cole-os no arquivo `about.html`.
2.  Adicione uma seção `<main>` vazia entre o `<header>` e o `<footer>`.

Por fim, verifique se a estrutura copiada está funcionando corretamente no navegador, com os links de navegação e o texto do rodapé aparecendo.

## 6. Importando e corrigindo o caminho do arquivo CSS na página "Sobre mim"

O objetivo desta atividade é importar o arquivo de estilos `styles.css` na página "Sobre mim" e corrigir o caminho do arquivo para refletir a estrutura de pastas atual.

1.  No arquivo `about.html`, adicione a tag `<link>` para importar o `styles.css`.
2.  Lembre-se de que o arquivo CSS foi movido para uma pasta chamada `"styles"`, então o caminho do `href` na tag `<link>` precisa ser atualizado para **`./styles/styles.css`**.
