import express from "express"
const app = express();
app.use(express.json());

let contas = [];
let depoimentos = [];

//Contas
app.get("/usuario", (request,response) => {
    return response.json(contas);
});

app.post("/usuario", (request, response) => {
    let {usuario, senha} = request.body

    contas.push({usuario, senha});
    return response.json({usuario, senha});
}) 

//Depoimentos

app.get("/depoimentos", (request,response) => {
    return response.json(depoimentos);
});

app.post("/depoimentos", (request, response) => {
    let {nome, depoimento} = request.body

    depoimentos.push({nome, depoimento});
    return response.json({nome, depoimento});
}); 


app.listen(3000);
//Nome, sobrenome, senha e confirmação de senha.
//Linkar Github e linkedin