const express = require("express");

const server = express();

//Rotas
server.get('/abacate', (request,response) => {
    return response.send('Esse é o seu abacate');
});

server.get('/morango', (request,response) => {
  
    console.log(request.query.feira);
    return response.send(request.query.feira);

});

server.listen(3000);
