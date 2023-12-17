let numerosSorteados = [];
let quantidadeDeNumerosGerados = 10;

function geradorNumeroAleatorio(){
    let numeroGerado = parseInt(Math.random() * quantidadeDeNumerosGerados + 1);
    if(numerosSorteados.includes(numeroGerado)){
        return geradorNumeroAleatorio();
    }else{
        if(numerosSorteados.length == quantidadeDeNumerosGerados){
            numerosSorteados = [];
        }
        numerosSorteados.push(numeroGerado);
        return numeroGerado;
    }
}
let numeroSecreto = geradorNumeroAleatorio();

function exibirTextoNaTela(tag, texto){
    let campo = document.querySelector(tag);
    campo.innerHTML = texto;
    responsiveVoice.speak(texto, 'Brazilian Portuguese Female', {rate: 1});
}

function limpaChute(){
    chute = document.querySelector('input');
    chute.value = '';
}

function mensagemInicial(){
    exibirTextoNaTela('h1', 'Jogo do número secreto');
    exibirTextoNaTela('p', 'Escolha um número entre 1 e 10');
}

mensagemInicial();
let tentativas = 1;
function verificarChute(){
    let chute = document.querySelector('input').value;
    let mudaLetra = tentativas > 1 ? 'tentativas' : 'tentativa';

    if(chute == numeroSecreto){
        exibirTextoNaTela('h1','Você acertou!');
        exibirTextoNaTela('p' , `Você encontrou o número secreto com ${tentativas} ${mudaLetra}!`);
        document.getElementById('reiniciar').removeAttribute('disabled');
    }else{
        tentativas++;
        limpaChute();
        if(chute > numeroSecreto){
            exibirTextoNaTela('h1', 'Ainda não é este número.');
            exibirTextoNaTela('p', 'O número secreto é menor que o seu chute!');
        }if(chute < numeroSecreto){
            exibirTextoNaTela('h1', 'Ainda não é este número.');
            exibirTextoNaTela('p', 'O número secreto é maior que o seu chute!');  
        }  
    }
}

function reinicarJogo(){
    numeroSecreto = geradorNumeroAleatorio();
    limpaChute();
    mensagemInicial();
    tentativas = 1;
    document.getElementById('reiniciar').setAttribute('disabled', true);   
}
