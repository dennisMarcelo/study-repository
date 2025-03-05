  const Sequelize = require('sequelize');
  const sequelize = new Sequelize('teste', 'root', 'PPK24.bat',{
    host: "localhost",
    dialect: "mysql"
  });


  sequelize.authenticate().then(function(){
    console.log("node conectado com sucesso ao mysql.");
  }).catch(function(err){
    console.log("erro ao se conectar ao mysql.");
    console.log("decrição do erro: "+ err);
  });