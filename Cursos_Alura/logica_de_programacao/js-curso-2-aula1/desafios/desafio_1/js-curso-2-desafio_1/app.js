let titulo = document.querySelector('h1');
titulo.innerHTML = 'Hora do Desafio';

function concoleAcionado(){
    console.log('O Botão console acionado!');
}

function alertaAcionado(){
    alert('Eu amo JS!');
}

let cidadeInformada = ''
function alertaPrompt(){
    cidadeInformada = prompt('Digite o nome de uma cidade do Brasil: ');
    alert(`Estive em ${cidadeInformada} e lembrei de você!`);
}

let primeiroNumero = 0;
let segundoNumero = 0;
let soma = parseInt(0);
function somaSimples(){
    primeiroNumero = parseInt(prompt('Entre com o primeiro número: '));
    segundoNumero = parseInt(prompt('Entre com o segundo número: '));
    soma = primeiroNumero + segundoNumero;
    alert(`A soma dos números ${primeiroNumero} + ${segundoNumero} é ${soma} `); 
}