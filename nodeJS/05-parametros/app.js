const express = require('express')
const app = express()

app.get('/ola/:nome/:cargo', function(req, res){
    res.send("<h1>Hello, you welcome "+req.params.nome+"!</p>"+"<h4>seu cargo é "+req.params.cargo+"</p>");
})



app.listen(8081, function(){
    console.log('live server!');
})