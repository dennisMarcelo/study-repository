//O call e o apply são muito parecidos, o que muda é a maneira de passar parâmetros 
//No 'call' o primeiro parametro passado é o que você acessa o this, o resto você passa como se fosse outra funão qualquer.
//No 'aplly' o primeiro parametro passado é o que você acessa o this, o te permite passar uma array.
//Eles são muito úteis para reaproveitamento de código.
//exemplo:
function feature(str, n){
    console.log(this.name+" skin: "+ this.color)
    console.log(str, n)
}

var person1 = {
    name:"Jõao Paulo",
    color:"black"
}
var person2={
    name:"Rita lee",
    color:"white"
}
//call
feature.call(person1)
feature.call(person2, "test call: ", 2)

console.log("--------------------------------------------")
//apply
feature.apply(person1)
feature.apply(person2, ["test apply:", 2])