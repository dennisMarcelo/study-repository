const axios = require('axios');

/* Faz uma requisição do tipo GET */
axios
  .get('http://localhost:8080/ping/')
  .then((response) => {
    console.log(response.data);
    console.log(response.status);
  })
  .catch((error) => {
    console.log(error);
  });