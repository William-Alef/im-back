//Variaveis e funcoes vinculadas ao ator
let xAtor = 85;
let yAtor = 366;
let colisao = false;
let pontosJogador = 0;

function adicionarPontos(){
  textAlign(CENTER);
  textSize(25);
  fill(color(225, 240, 60));
  text(pontosJogador, width / 5, 28);
}
function marcaponto(){
  if (yAtor < 15){
    pontosJogador +=1;
    voltaJogador();
    musicaPonto.play();
  }
}
function pontosPositivos(){
  return pontosJogador > 0;
}
function voltaJogador(){
  if (yAtor < 15){
    yAtor = 366;
  }
}
function mostraAtor(){
  image(ator, xAtor, yAtor, 35, 35);
}
function podeMover(){
  return yAtor < 366;
}
function movimentoAtor(){
  if (keyIsDown(UP_ARROW)){
    yAtor -= 2;
  }
  if (keyIsDown(DOWN_ARROW)){
    if (podeMover()){
      yAtor += 2;
    }
  }
}
function colidiu(){
  yAtor = 366;
  musicaHit.play();
  musicaBuzina.play();
}
function verificaColisao(){
  for (let i = 0; i < imagemCarros.length; i = i++){
    colisao = collideRectCircle(xCarros[i], yCarros[i], 50, 40, xAtor, yAtor, 30)
    if (colisao){
      colidiu();
      musicaPerdePonto.play();
      if (pontosPositivos()){
        pontosJogador -= 1;
      }
    }
  }
}