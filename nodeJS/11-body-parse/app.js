const express = require("express");
const app = express();
const handlebars = require("express-handlebars");
const bodyParser = require("body-parser");

//config bodyparser
app.use(bodyParser.urlencoded({exrended: false}));
app.use(bodyParser.json())

//config template engine
app.engine("handlebars", handlebars({defaultLayout:"main"}));
app.set("view engine", "handlebars")

//rotas 
app.get('/cad', function(req, res){
    res.render("formulario.handlebars")
})

//os dados vão ser recibido através do metódo post. existem varias rotas.
app.post('/postado', function(req, res){
    res.send(`Titulo: ${req.body.titulo} <br> Conteudo: ${req.body.conteudo}`)
})



app.listen(8081,function(){
    console.log("LIVE SERVER!!!")
})
