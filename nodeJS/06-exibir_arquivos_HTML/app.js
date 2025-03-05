const express = require('express');
const app = express();

app.get("/", function(req, res){
    res.sendfile(`${__dirname}/index.html`)
})

app.get("/about",function(req, res){
    res.sendfile(`${__dirname}/about.html`)
})


app.listen(8081, function(){console.log('live server')})