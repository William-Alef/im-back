//Variaveis e funcoes vinculadas ao ator
let xAtor = 100;
let yAtor = 366;

function movimentoAtor(){
    if (keyIsDown(UP_ARROW)){
      yAtor -= 2;
    }
    if (keyIsDown(DOWN_ARROW)){
      yAtor += 2;
    }
  }