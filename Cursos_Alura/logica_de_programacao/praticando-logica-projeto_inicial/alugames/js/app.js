function alterarStatus(id){
    function adicionaClass(nome, conteudo){
        nome.classList.add(`${conteudo}`);
    }
    function removeClass(nome, conteudo){
        nome.classList.remove(`${conteudo}`);
    }

    let contadorDeAlugueis = 0;
    let gameClicado = document.getElementById(`game-${id}`);
    let imagem = gameClicado.querySelector('.dashboard__item__img');
    let botao = gameClicado.querySelector('.dashboard__item__button');

    if(!imagem.classList.contains(`dashboard__item__img--rented`)){
        adicionaClass(imagem, 'dashboard__item__img--rented');
        adicionaClass(botao, 'dashboard__item__button--return');
        botao.textContent = 'Devolver';
        contadorDeAlugueis+=1;
        alert('O jogo foi alugado com sucesso!');

    }else{
        removeClass(imagem, 'dashboard__item__img--rented');
        removeClass(botao, 'dashboard__item__button--return');
        botao.textContent = 'Alugar';
    }
}