//importa o modulo http, presente no node, lembre-se que ele é bem fraquinho.
var http = require('http')

//abri um servidor
//use o listem para abrir uma porta
//entao utilize uma uma função de callback
http.createServer(function(req,res){
    res.end('hello word!')
}).listen(8081)

console.log('LIVE SERVER')

//no navegador se digita o a portar
//localhost:8081