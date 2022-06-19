function setup() {
  createCanvas(500, 400);
}

function draw() {
  background(estrada);
  image(ator, xAtor, yAtor, 35, 35);
  image(car1, xCarros[0], yCarros[0], 50, 40);
  image(car2, xCarros[1], yCarros[1], 50, 40);
  image(car3, xCarros[2], yCarros[2], 50, 40);
  movimentoCarro();
  movimentoAtor();
  loopCarro();
}