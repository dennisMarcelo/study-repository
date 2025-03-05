const Sequelize = require("sequelize");
const sequelize = new Sequelize("teste", "root", "PPK24.bat", {
    host: "localhost", //onde esta o banco
    dialect: "mysql" //tipo de banco
});
/*

//cria um model Postagem -----------------------------------------------------------------------------
    const Postagem  = sequelize.define("postagens",{
        titulo: {
            type: Sequelize.STRING //tem um limite de caractere
        },
        conteudo: {
            type: Sequelize.TEXT //não tem limite de caractere
        }
    })

//crea a tabela postagem no mysql
    Postagem.sync({force: true});

//adcionar conteudo a tabela Postagem    
    Postagem.create({
        titulo: "Hello word",
        conteudo: "Essa é um teste para saber como funciona o sequelize. aqui eu utilizo o método create para adcionar conteudo a minha tabela."
    });
    

//cria um model Usuario ---------------------------------------------------------------------------------
    const Usuario = sequelize.define("usuarios",{
        nome:{
            type: Sequelize.STRING
        },
        sobrenome:{
            type: Sequelize.STRING
        },
        idade:{
            type: Sequelize.INTEGER
        },
        email:{
            type: Sequelize.STRING
        }
    });

//crea a tabela usuario no mysql
    Usuario.sync({force: true});

//adicionar conteudo a tabela Usuario    
    Usuario.create({
        nome: "Dennis",
        sobrenome: "Marcelo dos santos",
        idade: 21,
        email: "dennis36@hotmail.com"
    })
    
*/