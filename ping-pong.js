//Funcoes para mostrar e movimentar a bolinha
function setup() {
  createCanvas(600, 400);
}
function mostrarBolinha(){
  circle(xBolinha, yBolinha, diametroBolinha)
}
function movimentoBolinha(){
  xBolinha += xBolinhaSpeed;
  yBolinha += yBolinhaSpeed;
}
function colisaoBolinhaComBordas(){
  if (xBolinha + raioBolinha > width || xBolinha - raioBolinha < 0){
      xBolinhaSpeed *= -1;
  }
  if (yBolinha + raioBolinha > height || yBolinha - raioBolinha < 0){
      yBolinhaSpeed *= -1;
  }
}
function colisaoBolinhaRaquete(){
  if (xBolinha - raioBolinha < xRaqueteJogador + diametroRaqueteJogador && yBolinha - raioBolinha < yRaqueteJogador + alturaRaqueteJogador && yBolinha + raioBolinha > yRaqueteJogador){
    xBolinhaSpeed *= -1;
  }
}
//Importando uma colisao e aplicando do codigo
function colisaoBolinhaRaqueteBiblioteca(){
  colidiu = collideRectCircle(xRaqueteJogador, yRaqueteJogador, diametroRaqueteJogador, alturaRaqueteJogador, xBolinha, yBolinha, raioBolinha);
  
  if (colidiu){
    xBolinhaSpeed *= -1;
  }
}

//Funcoes para mostrar e movimentar as raquetes
function mostraRaquete(x, y){
  rect(x, y, diametroRaqueteJogador, alturaRaqueteJogador)
}
function movimentoRaqueteJogador(){
  if (keyIsDown(UP_ARROW)){
    yRaqueteJogador += -5;
}
  if (keyIsDown(DOWN_ARROW)){
    yRaqueteJogador +=5;
  }
}
function mostraRaqueteInimiga(){
  rect(xRaqueteInimiga, yRaqueteInimiga, diametroRaqueteI, alturaRaqueteInimiga)
}

//Variaveis da bolinha
let xBolinha = 300;
let yBolinha = 200;
let xBolinhaSpeed = 5;
let yBolinhaSpeed = 5;
let diametroBolinha = 20;
let raioBolinha = diametroBolinha / 2;

//Variaveis raquete aliada
let xRaqueteJogador = 3;
let yRaqueteJogador = 150;
let diametroRaqueteJogador = 7;
let alturaRaqueteJogador = 88;

//Variaveis raquete inimiga
let xRaqueteInimiga = 590;
let yRaqueteInimiga = 150;
let diametroRaqueteI = 7;
let alturaRaqueteInimiga = 88;

let hit = false;

//Chama mostrar bolinha, raquetes e background + testes de colisao com as bordas
function draw() {
  background(100);
  mostrarBolinha();
  movimentoBolinha();
  colisaoBolinhaComBordas();
  //colisaoBolinhaRaquete();
  colisaoBolinhaRaqueteBiblioteca();
  mostraRaquete(xRaqueteJogador, yRaqueteJogador);
  mostraRaquete(xRaqueteInimiga, yRaqueteInimiga);
  movimentoRaqueteJogador();  
}
