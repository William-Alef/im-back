function calculaImc(){
    var altura = parseFloat(prompt('Informe a sua altura: '));
    var peso = parseFloat(prompt('Informe o seu peso: '));
    var imc = peso / (altura*altura);

    alert(`Com ${altura} metros de altura e um peso de ${peso}Kg, o seu IMC é ${imc.toFixed(2)}!`);
}

function calcularFatorial(){
    var fatorial = parseFloat(prompt('Informe o número: '));
    var resultado = fatorial;

    for (var i=1; i < fatorial; i++) {
        resultado *= i;
    }
    alert(resultado);
}

function conversor(){
    var cotacao = 4.80;
    var valorEmReais = parseFloat(prompt('Informe o valor em reais: '));
    var valorConvertido = valorEmReais/cotacao;

    alert(`R$${valorEmReais} são $${valorConvertido.toFixed(2)}`);
}

//calcula a área e perimetro de uma sala retangular
function calculaPerimetro(){
    var base = parseFloat(prompt('Entre com a base: '));
    var altura = parseFloat(prompt('Enter com a altura: '));
    var area = base * altura;
    var perimetro = 2 * (base + altura);

    alert(`O perímetro da sala é ${perimetro} e a área é ${area}`);
}

//calcula a área e perimetro de uma sala circular
function calcularArea(){
    var raio = parseFloat(prompt('Entre com o rario do circulo: '));
    var pi = 3.14;
    var area = pi*(raio*raio); 
    var perimetro = 2 * (pi * raio);

    alert(`O perímetro do circulo é ${perimetro.toFixed(2)} e a área é ${area.toFixed(2)}`);
}

function taboada(){
    var numeroInformado = parseInt(prompt('Entre com o número desejado: '));
    for(i=1; i<=10; i++){
        taboada = numeroInformado * i;
        alert(`${numeroInformado} X ${i} = ${taboada}`);
    }
}
