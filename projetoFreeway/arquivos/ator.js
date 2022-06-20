//Variaveis e funcoes vinculadas ao ator
let xAtor = 100;
let yAtor = 366;

function mostraAtor(){
  image(ator, xAtor, yAtor, 35, 35);
}

function movimentoAtor(){
    if (keyIsDown(UP_ARROW)){
      yAtor -= 2;
    }
    if (keyIsDown(DOWN_ARROW)){
      yAtor += 2;
    }
  }