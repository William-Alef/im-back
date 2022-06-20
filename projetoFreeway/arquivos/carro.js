//Variaveis dos carros
let xCarros = [500, 600, 600];  
let yCarros = [40, 96, 150];
let carSpeed = [3, 2, 2.5];

function passouDaTela(xCarros){
    return xCarros < -40;
}

function mostraCarros(){
    for (let i = 0; i < imagemCarros.length; i = i + 1){
        image(imagemCarros[i], xCarros[i], yCarros[i], 50, 40);
    } 
}

function movimentoCarro(){
    for (let i = 0; i < imagemCarros.length; i = i + 1){
        xCarros[i] -= carSpeed[i];
    }
}
//loop para que os carros retornem para a posicao inicial
function loopCarro(){
    for (let i = 0; i < imagemCarros.length; i = i + 1){
        if (passouDaTela(xCarros[i])){
            xCarros[i] = 550;
        }
    }
}   