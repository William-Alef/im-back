# Requisitos do exercício

## 1. Adaptando o corpo do texto para unidades relativas

Nesta atividade, você irá adaptar o corpo do texto do seu projeto para responder melhor às configurações do navegador e às preferências de acessibilidade do usuário.  

Abra o arquivo `style.css` e localize elementos de texto, como parágrafos (`<p>`) ou subtítulos (`<h2>`), que estejam utilizando a propriedade `font-size` definida em pixels (`px`).  

Altere essas unidades para `rem`, considerando que o valor padrão de `1rem` equivale a `16px`.  
Por exemplo, se um parágrafo estiver com `font-size: 18px`, converta para `1.125rem` (18 ÷ 16 = 1.125).  

Após realizar as alterações, salve o arquivo e teste o comportamento do texto alterando o tamanho da fonte nas configurações de aparência do navegador.

---

## 2. Convertendo pixels para rem em CSS

Nesta atividade, você irá melhorar a responsividade do texto do site convertendo todas as unidades de `font-size` de pixels para `rem`.  

Abra o arquivo `styles.css` no VS Code e utilize o atalho **Ctrl + F** para localizar todas as ocorrências de `font-size`. Para cada valor encontrado em pixels, faça a conversão para `rem`, lembrando que `1rem` equivale a `16px`.   

Repita esse processo até que todas as definições de tamanho de fonte do projeto estejam utilizando unidades relativas.

---

## 3. Melhorando a responsividade de um site

Após realizar a conversão dos tamanhos de fonte para `rem`, o próximo passo é testar a responsividade do site.  

Abra a página de portfólio no navegador e altere as configurações de tamanho de fonte disponíveis (Muito grande, Grande, Médio, Pequeno e Muito pequeno).  

Observe atentamente como os textos do site se adaptam a cada mudança. Verifique se há problemas de layout, como textos quebrando de forma inadequada, sobreposição de elementos ou dificuldades de leitura.  

Faça anotações sobre qualquer comportamento inesperado, pois isso ajudará a identificar se as alterações realizadas realmente melhoraram a experiência do usuário.

---

## 4. Ajustando o CSS para diferentes tamanhos de fonte

Nesta atividade final, você irá ajustar o CSS para corrigir os problemas identificados durante os testes de responsividade.  

Caso perceba que algumas seções não se adaptam bem a tamanhos de fonte muito grandes ou muito pequenos, será necessário ajustar propriedades do CSS para manter a legibilidade e o equilíbrio visual do site.  

Abra o arquivo `styles.css` e faça as alterações necessárias, que podem incluir ajustes em `margin`, `padding`, `line-height` ou até mesmo no `font-size` de seções específicas.  

Após realizar os ajustes, salve o arquivo e teste novamente o site em diferentes tamanhos de fonte para garantir que o layout permaneça consistente, acessível e visualmente agradável.
