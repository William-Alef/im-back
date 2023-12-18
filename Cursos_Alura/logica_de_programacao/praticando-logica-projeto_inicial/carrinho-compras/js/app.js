
//Feito por mim

let carrinho = 0;
let valorDoProduto = 0;
let textoTotal = document.getElementById('valor-total');


function adicionar(){
    let produtoSelecionado = document.getElementById('produto').value;
    let quantidadeDeProdutos = document.getElementById('quantidade').value;

    if(produtoSelecionado == 'Fone de ouvido - R$100'){
        valorDoProduto = 100;
    }
    else if(produtoSelecionado == 'Celular - R$1400'){
        valorDoProduto = 1400;
    }
    else if('Oculus VR - R$5000'){
        valorDoProduto = 5000;
    }

    carrinho += quantidadeDeProdutos * valorDoProduto;
    textoTotal.textContent = `R$${carrinho}`;
    
}

function limpar(){
    carrinho = 0;
    textoTotal.textContent = `R$${carrinho}`;
}


//Seguindo o conteúdo da plataforma
/*
document.getElementById('lista-produtos').textContent = '';
document.getElementById('valor-total').textContent = 'R$0';

function adicionar(){
    let produto = document.getElementById('produto').value;
    let nomeDoProduto = produto.split('-')[0];
    let valorPorProduto = produto.split('R$')[1];
    let quantidade = document.getElementById('quantidade').value;
    let preco = quantidade * valorPorProduto;
    let listaCarrinho = document.getElementById('lista-produtos');
    listaCarrinho.innerHTML = listaCarrinho.innerHTML + `<section class="carrinho__produtos__produto">
    <span class="texto-azul">${quantidade}x</span> ${nomeDoProduto}<span class="texto-azul">R$${preco}</span>
    </section>`;
    totalGeral = totalGeral + preco;
    let campoTotal = document.getElementById('valor-total'); 
    campoTotal.textContent = `R$ ${totalGeral}`; 
    document.getElementById('quantidade').value = 0;
}

function limpar(){
    totalGeral = 0;
    document.getElementById('lista-produtos').textContent = '';
    document.getElementById('valor-total').textContent = 'R$0';
}
*/