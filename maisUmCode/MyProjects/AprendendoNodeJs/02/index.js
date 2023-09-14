/*
1 Obter um usuario
2 Obter um numero de telefone a partir de seu ID
3 obter o endereco do usuario pelo id
*/

function obterUsuario(){
    setTimeout(function(){
        return{
            id: 1,
            nome: 'Aladin',
            dataNascimento: new Date()
        }
    }, 1000)
}
function obterTelefone(idUsuario){
    setTimeout(() => {
        return {
            telefone: '119002',
            ddd: 11
        }
    }, 2000);
}
function obterEndereco(idUsuario){

}

const usuario = obterUsuario();
const telefone = obterTelefone(usuario.id)

console.log('usuario', usuario)
console.log('telefone', telefone)