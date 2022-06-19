//Variaveis dos carros
let xCarros = [500, 600, 600];  
let yCarros = [40, 96, 150];
let carSpeed = [3, 2, 2.5];

function movimentoCarro(){
  xCarros[0] -= carSpeed[0];
  xCarros[1] -= carSpeed[1];
  xCarros[2] -= carSpeed[2];
}
//loop para que os carros retornem para a posicao inicial
function loopCarro(){
    if (xCarros[0] < -40){
        xCarros[0] = 550;
    }
    if (xCarros[1] < -40){
        xCarros[1] = 550;
    }
    if (xCarros[2] < -40){
        xCarros[2] = 550;
    }
}   