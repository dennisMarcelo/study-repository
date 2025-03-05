const express = require("express");
const app = express();
const handlebars = require("express-handlebars");
const bodyparser = require("body-parser")
const PostsModel = require("./models/Post");
const Post = require("./models/Post");

//config template engine
app.engine("handlebars", handlebars({defaultLayout:"main"}));
app.set("view engine", "handlebars")

//config body-parser
app.use(bodyparser.urlencoded({extended:false}));
app.use(bodyparser.json());




//rotas 
app.get('/', function(req, res){
    PostsModel.findAll({order: [["id", "DESC"]]}).then(function(posts){
        res.render("home", {posts: posts})  
    }).catch(function(erro){
        console.log("erro: "+erro)
    })
})

app.get('/cad', function(req, res){
    res.render("formulario.handlebars")
})

app.post('/postado', function(req, res){
    PostsModel.create({
        titulo: req.body.titulo,
        conteudo: req.body.conteudo
    }).then(function(){
        res.redirect("/")
    }).catch(function(err){
        res.send(`Erro na postagem. <br> Erro: ${err}`)
    })
})

app.get('/deletar/:id', function(req, res){
    Post.destroy({where: {"id": req.params.id}}).then(function(){
        res.send("Postagem deletada com sucesso!")
    }).catch(function(){
        res.send("Postagem não existe!")
    })
})




app.listen(8081,function(){
    console.log("LIVE SERVER!!!")
})
