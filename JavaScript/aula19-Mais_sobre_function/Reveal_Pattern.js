//A ideia do module pattern é colocar tudo dentro de um objeto para porteger o escopo global.
//Já o revel pattern é bem parecido com ele porem é utilizado funçoes 
//exemplo:

//module pattern
/*
var beluga = {
    nuumber: {
        value:0,
        add: function(n){
            this.value += n;
        },
        log: function(){
            console.log(this.value);
        }
    }
}
*/

//revel pattern
var beluga2 = (function(){
    var n = 0;

    function isNumber(_n){
        return typeof _n ==='number';
    }

    function _add(_n){
        if(isNumber(_n)){
            n += _n;
        }
    }

    function _log(){
        console.log(n);
    }

    return {
        add: _add,
        log: _log
    }
})()
