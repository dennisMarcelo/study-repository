//A ideia aqui é executar funções de forma encadeada, isto é uma atrás da outra
//Exemplo utilizando um objeto (nesse contexto não muito indicado fazer isso):
/*
var obj = {
    value: 1,
    add: function(n){
        this.value +=n;
        return this
    },
    log: function(){
        console.log(this.value);
        return this;
    }
}
obj.add(4).add(5).add(5).log().add(20).log()
*/

function Add(n){
    this.value = n || 0;
    this.add = function(n){
       this.value += n;
       return this;
    }
    this.log = function(){
        console.log(this.value);
        return this;                //A ideia do encademento é fazer com que o objeto retorne ele mesmo
    }
}

var teste = new Add(0);
teste.add(10).add(20).log()
debugger