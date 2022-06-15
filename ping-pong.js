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
  /*function colisaoBolinhaRaquete(){
    if (xBolinha - raioBolinha < xRaqueteJogador + diametroRaqueteJogador && yBolinha - raioBolinha < yRaqueteJogador + alturaRaqueteJogador && yBolinha + raioBolinha > yRaqueteJogador){
      xBolinhaSpeed *= -1;
    }
  }*/

  //Importando uma colisao e aplicando do codigo
  function colisaoBolinhaRaqueteBiblioteca(x, y){
    colidiu = collideRectCircle(x, y, diametroRaqueteJogador, alturaRaqueteJogador, xBolinha, yBolinha, raioBolinha);
    
    if (colidiu){
      xBolinhaSpeed *= -1;
    }
  }

  //Funcoes para mostrar e movimentar as raquetes
  function mostraRaquete(x, y){
    rect(x, y, diametroRaqueteJogador, alturaRaqueteJogador)
  }
  function mostraRaqueteInimiga(){
    rect(xRaqueteInimiga, yRaqueteInimiga, diametroRaqueteI, alturaRaqueteInimiga)
  }
  function movimentoRaqueteJogador(){
    if (keyIsDown(UP_ARROW)){
      yRaqueteJogador += -5;
  }
    if (keyIsDown(DOWN_ARROW)){
      yRaqueteJogador += 5;
    }
  }
  function movimentoRaqueteInimiga(){
    raqueteInimigaSpeed = yBolinha - yRaqueteInimiga - diametroRaqueteI / 2 -30;
    yRaqueteInimiga += raqueteInimigaSpeed;
  }

  //Funcoes para mostrar o placar e computar pontos
  function placar(){
    stroke(255);
    textAlign(CENTER)
    textSize(16);
    fill(color(148, 0, 211));
    rect(256, 10, 40, 20);
    fill(255);
    text(pontosJogador, 276, 26);
    fill(color(148, 0, 211));
    rect(303, 10, 40, 20);
    fill(255);
    text(pontosInimigo, 323, 26);
  }
  function computaPontos(){
    if (xBolinha > 593){
      pontosJogador += 1;
    }
    if (xBolinha < 10){
      pontosInimigo +=1;
    }
  }

  //Variaveis da bolinha
  let xBolinha = 300;
  let yBolinha = 200;
  let xBolinhaSpeed = 5;
  let yBolinhaSpeed = 5;
  let diametroBolinha = 18;
  let raioBolinha = diametroBolinha / 2;

  //Variaveis raquete aliada
  let xRaqueteJogador = 3;
  let yRaqueteJogador = 150;
  let diametroRaqueteJogador = 5;
  let alturaRaqueteJogador = 88;

  //Variaveis raquete inimiga
  let xRaqueteInimiga = 590;
  let yRaqueteInimiga = 150;
  let diametroRaqueteI = 5;
  let alturaRaqueteInimiga = 88;
  let raqueteInimigaSpeed;

  //Variaveis do placar
  let pontosJogador = 0;
  let pontosInimigo = 0;

  let hit = false;

  //Chama mostrar bolinha, raquetes e background + testes de colisao com as bordas
  function draw() {
    background(100);
    mostrarBolinha();
    movimentoBolinha();
    colisaoBolinhaComBordas();
    //colisaoBolinhaRaquete();
    colisaoBolinhaRaqueteBiblioteca(xRaqueteJogador, yRaqueteJogador);
    colisaoBolinhaRaqueteBiblioteca(xRaqueteInimiga, yRaqueteInimiga);
    mostraRaquete(xRaqueteJogador, yRaqueteJogador);
    mostraRaquete(xRaqueteInimiga, yRaqueteInimiga);
    movimentoRaqueteJogador();
    movimentoRaqueteInimiga();
    placar();  
    computaPontos();
  }