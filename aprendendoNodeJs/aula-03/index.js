//importando a bibioteca express
const express = require("express");
const app = express();


//Informando que o formato será json
app.use(express.json());

//Iniciando com um usuário
const users = [
    {
        name: 'William',
        senha: 'Abc@123'
    }
]

//Endpoint para listar os usuários
app.get('/usuarios', function (request, response){
    response.json(users);
});

//Endpoint para criar novos usuários
app.post('/usuarios', function (request, response){
    console.log(request.body);

    const newUser = request.body
    users.push(newUser);

    response.status(201).json(newUser);
});

app.listen(3001, () => console.log("Servidor rodando!"));