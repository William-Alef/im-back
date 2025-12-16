# Requisitos do exercício:

## 1. Adicionando um subtítulo à página

Imagine que você está desenvolvendo uma página web para compartilhar em suas redes sociais. Você precisa adicionar um subtítulo "**Acesse minhas redes:**" acima dos links para Instagram e Github.

1.  Edite o arquivo `index.html`.
2.  Inclua o subtítulo usando a tag `<h2>`.
3.  Coloque o `<h2>` **dentro da `<div>`** que já contém os links.

## 2. Alterando a disposição dos elementos com Flexbox (Vertical)

Agora que o subtítulo foi adicionado, ele está alinhado à esquerda dos botões (disposição horizontal). Sua missão é alterar a disposição dos elementos (subtítulo e botões) para uma disposição **vertical**.

1.  Edite o arquivo `style.css`.
2.  Modifique a propriedade `flex-direction` para **`column`** dentro da classe `.apresentacao__links`.

Isso mudará a direção do Flexbox, alinhando os elementos verticalmente.


## 3. Ajustando o alinhamento e o espaçamento dos elementos

Após modificar a direção do Flexbox, você observa que os elementos (texto e botões) estão muito próximos uns dos outros e alinhados à esquerda. Para melhorar a estética, você precisa:

1.  **Centralizar** esses elementos verticalmente: adicione a propriedade `align-items: center` à classe `.apresentacao__links` no `style.css`.
2.  **Adicionar espaçamento** entre eles: insira a propriedade `gap` com o valor de **`32px`** à mesma classe.

## 4. Criando uma classe para o subtítulo

Você decidiu que o subtítulo "**Acesse minhas redes:**" precisa de uma estilização específica. Para isso, você vai criar uma classe CSS para ele.

1.  No arquivo `index.html`, encontre a tag `<h2>` que contém o subtítulo.
2.  Adicione a classe chamada **`apresentacao__links__subtitulo`** à tag `<h2>`.

Sua tarefa é inserir essa classe na tag `<h2>` de forma correta.

## 5. Estilizando o subtítulo

Agora que você criou uma classe para o subtítulo, é hora de estilizá-lo. No arquivo `style.css`, adicione a classe `.apresentacao__links__subtitulo` e configure as propriedades:

* **Fonte:** `'Krona One'` (com aspas).
* **Peso da fonte (`font-weight`):** `400`.
* **Tamanho da fonte (`font-size`):** `24px`.
* **Fonte de fallback:** `sans-serif` (sem aspas).

Sua tarefa é escrever o código CSS para aplicar essas configurações ao subtítulo.

## 6. Modificando o estilo dos botões

Os botões da sua página precisam de um novo visual. No arquivo `style.css`, encontre a classe `.apresentacao__links__link` e faça as seguintes alterações:

* Remova o fundo ciano.
* Mude a cor do texto para branco (`#F6F6F6
