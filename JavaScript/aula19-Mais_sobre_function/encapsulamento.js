//técnica útilizada para esconder a partes de uma clase.
//exemplo: 

function ContaCorrente(codigo) {
    this.codigo = codigo; // atributo publico
    var saldo = 0.0; // atributo privado

    // metodos publicos
    this.deposita = function(valor){
         saldo += valor;
         imprime("Depositou R$ " + valor);
    };
    this.mostraSaldo = function(){
         imprime("Saldo: " + saldo);
    };

    // metodos privados
    function imprime(msg) {
         console.log(msg);
    }
}

var c = new ContaCorrente(1234);
console.log(c.codigo);

c.deposita(1000);
c.mostraSaldo();