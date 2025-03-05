//Função callback é quando uma função é passada a outra como parametro, e então é invocada dentro da funão externa para completar algum tipo de rotina.
//exemplo:

function greeting(name) {
  alert('Hello ' + name);
}

function processUserInput(callback) {
  var name = prompt('Please enter your name.');
  callback(name);
}

processUserInput(greeting);