//Ao contrario do call e o apply o bind não executa a função
//O primeiro argumento recebe o this e o demais recebe o valor a ser retornado.
//Ele acaba tendo dois papéis:
//+Mudar o valor de this;
//+alterar o numero de parâmetros de uma função(currying).
//exemplo:

function sayThis(n1, n2){
    console.log(this*n1*n2);
}

var thisIs2 = sayThis.bind(2);
var thisIs2N1Is3 = sayThis.bind(2,3);
var thisIs2N1is3N2is3 = sayThis.bind(2,3,3)
thisIs2(3,3);
thisIs2N1Is3(3);
thisIs2N1is3N2is3();
