//varoavel dos arquivos
let estrada;
let car1;
let car2;
let car3;
let ator;
let yAtor = 366;
let xCarro = 500;

function setup() {
  createCanvas(500, 400);
}
function preload(){
  estrada = loadImage('atores/estrada.png');
  ator = loadImage('atores/ator.png');
  car1 = loadImage('atores/car_1.png');
  car2 = loadImage('atores/car_2.png');
  car3 = loadImage('atores/car_3.png');
}
function movimentoCarro(){
  xCarro -= 2;
}
function movimentoAtor(){
  if (keyIsDown(UP_ARROW)){
    yAtor -= 2;
  }
  if (keyIsDown(DOWN_ARROW)){
    yAtor += 2;
  }
}

function draw() {
  background(estrada);
  image(ator, 100, yAtor, 35, 35);
  image(car1, xCarro, 40, 50, 40);
  image(car2, xCarro, 100, 50, 40);
  image(car3, xCarro, 100, 50, 40);
  movimentoCarro();
  movimentoAtor();
}