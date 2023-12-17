alert('Boas vindas ao jogo do número secreto!');

let numeroMaximo = 5000;
let numeroSecreto = parseInt(Math.random() * numeroMaximo) + 1;
let chute;
let tentativas = 0;


while(chute != numeroSecreto) {
    chute = prompt(`Digite um número entre 1 e ${numeroMaximo}`);

    if(chute == numeroSecreto){
        break;
    }else{
        alert('Você errou');
        if(chute > numeroSecreto){
            alert(`O número ${chute} é maior que o número secreto!`);
        }
        else{
            alert(`O número ${chute} é menor que o número secreto!`);
        }
        tentativas ++;
    } 

}

let palavraNoPlural = tentativas > 1 ? 'tentativas' : 'tentativa';

alert(`Você acertou com ${tentativas} ${palavraNoPlural}! O número secreto é ${numeroSecreto}!`);
