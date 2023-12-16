function tiraZika(){
    console.log('Olá, mundo! Já tirei a zika!');
}

function cumprimentar(){
    nome = prompt('Qual o seu nome? ');
    console.log(`Olá, ${nome}!`);
}

function dobraNumero(){
    numero = prompt('Entre com o número que deseja dobrar');
    alert(`O dobro do número ${numero} é ${2*numero}`);
}

function media(){
    primeiroNumero = parseInt(prompt('Entre com o primeiro número'));
    segundoNumero = parseInt(prompt('Entre com o segundo número'));
    terceiroNumero = parseInt(prompt('Entre com o terceiro número'));

    media = (primeiroNumero + segundoNumero + terceiroNumero) / 3;
    alert(`A média entre os números ${primeiroNumero}, ${segundoNumero} e ${terceiroNumero} é ${media}`);
}

function maiorNumero(){
    primeiroNumero = parseInt(prompt('Entre com o primeiro número'));
    segundoNumero = parseInt(prompt('Entre com o segundo número'));

    if(primeiroNumero > segundoNumero){
        alert(`O número ${primeiroNumero} é o maior!`);
    }else if(primeiroNumero < segundoNumero){
        alert(`O número ${segundoNumero} é o maior!`);
    }else{
        alert(`Os números são iguais!`);  
    }
}

function multiplicador(){
    numero = parseInt(prompt('Entre com um número'));
    alert(`O número ${numero} é ${numero*numero}`);
}