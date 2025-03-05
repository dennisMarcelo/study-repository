//aula abstrair métodos de acesso ao DOM
//O bind aqui é nescessario porque ele recupera o contexto de this
var blg = (function(){
    var beluga = {};
    beluga.$ = document.querySelector.bind(document);
    beluga.$$ = document.querySelectorAll.bind(document)
    
    return beluga
})()