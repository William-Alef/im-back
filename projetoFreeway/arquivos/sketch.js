function setup() {
  createCanvas(500, 400);
  musicaTrilha.loop();
}

function preload(){
  estrada = loadImage('atores/estrada.png');
  ator = loadImage('atores/ator.png');
  car1 = loadImage('atores/car_1.png');
  car2 = loadImage('atores/car_2.png');
  car3 = loadImage('atores/car_3.png');
  imagemCarros = [car1, car2, car3, car2, car1, car3];

  musicaTrilha = loadSound('sons/trilha.mp3');
  musicaHit = loadSound('sons/hit.mp3');
  musicaBuzina = loadSound('sons/buzina.mp3');
  musicaPonto = loadSound('sons/ponto.mp3');
  musicaPerdePonto = loadSound('sons/losePoint.mp3');
}

function draw() {
  background(estrada);
  mostraCarros();
  mostraAtor();
  movimentoCarro();
  movimentoAtor();
  loopCarro();
  verificaColisao();
  adicionarPontos();
}