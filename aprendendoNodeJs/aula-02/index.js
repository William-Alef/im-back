import express from "express"

const app = express();

app.use(express.json());

let contas = [];

app.get("/usuario", (request,response) => {
    return response.json(contas);
});

app.listen(3000);

app.post("/usuario", (request, response) => {
    let {usuario, senha} = request.body

    contas.push({usuario, senha});
    return response.json({usuario, senha})
}) 


//Nome, sobrenome, senha e confirmação de senha.
//Linkar Github e linkedin