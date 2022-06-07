//feito em P5.JS.org
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
    if (xBolinha + raio > width || xBolinha - raio < 0){
        xBolinhaSpeed *= -1;
    }
    if (yBolinha + raio > height || yBolinha - raio < 0){
        yBolinhaSpeed *= -1;
    }
  }
  function mostraRaqueteJogador(){
    rect(xRaqueteJogador, yRaqueteJogador, diametroRaqueteJogador, alturaRaqueteJogador)
  }
  function mostraRaqueteInimiga(){
    rect(xRaqueteInimiga, yRaqueteInimiga, diametroRaqueteI, alturaRaqueteInimiga)
  }
  function movimentoRaqueteJogador(){
    if (keyIsDown(UP_ARROW)){
      yRaqueteJogador += -5;
  }
    if (keyIsDown(DOWN_ARROW)){
      yRaqueteJogador +=5;
    }
  }
  
  //Variaveis da bolinha
  let xBolinha = 300;
  let yBolinha = 200;
  let xBolinhaSpeed = 6;
  let yBolinhaSpeed = 6;
  let diametroBolinha = 20;
  let raio = diametroBolinha / 2;
  
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
  
  //Chama mostrar bolinha, raquetes e background + testes de colisao com as bordas
  function draw() {
    background(100);
    mostrarBolinha();
    movimentoBolinha();
    colisaoBolinhaComBordas();
    mostraRaqueteJogador();
    mostraRaqueteInimiga();
    movimentoRaqueteJogador();  
  }
  