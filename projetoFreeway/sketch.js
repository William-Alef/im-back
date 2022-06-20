function setup() {
  createCanvas(500, 400);
}

function draw() {
  background(estrada);
  mostraCarros();
  mostraAtor();
  movimentoCarro();
  movimentoAtor();
  loopCarro();
}