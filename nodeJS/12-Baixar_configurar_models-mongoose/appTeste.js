const mongoose = require("mongoose")

//configurar mongoose
mongoose.Promise = global.Promise;
mongoose.set('useUnifiedTopology', true) ////Isso é novo no mongo pesquisa ai. 
mongoose.connect("mongodb://localhost/teste2",{
    //useMongoClient:true, isso já não é mais necessario na versão 5
    useNewUrlParser: true, //Isso é novo no mongo pesquisa ai.
})
.then(()=>{
    console.log("conectado com sucesso")
})
.catch((err)=>{
    console.log("Erro ao se conectar. Erro Description:"+err)
})

//model - usuario
const UserSchema = mongoose.Schema({
    name:{
        type: String,
        require:true
    },

    lastName:{
        type: String,
        require: true
    },
    email:{
        type: String,
        require: true
    },
    age:{
        type: Number,
        require:true
    },
    countrie:{
        type: String,
        require: true
    }
})
mongoose.model('userModel', UserSchema)  //devia ter colocado user no userModel. é ele que vai aparecer lá no banco.

//colletion
const user = mongoose.model('userModel')
new user({
    name: "thomas",
    lastName: "shelby",
    email: "shelby66@hotmail.com",
    age: 32,
    countrie: "Inglaterra"
}).save()
.then(()=>{
    console.log("Usuario cadastrado com sucesso!")
})
.catch((err)=>{
    console.log(`erro inesperado. erro: ${err}`)
})