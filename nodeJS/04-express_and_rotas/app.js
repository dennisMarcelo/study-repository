const express = require('express');
//É criado uma cópia do express, para dentro da variável app
const app = express();

//aqui é definido uma resposta para quando acessado a rota '/'
app.get('/', function(req, res){
    res.send('welcome to my page');
});

app.get('/about', function(req, res){
    res.send('my page about')
});

app.get('/blog', function(req, res){
    res.send('welcome to my blog')
})





//esse listem tem que ir sempre no final do código
app.listen(8081, function(){
    console.log('live server!');
});