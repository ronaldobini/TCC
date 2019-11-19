$.ajax({
  url: 'http://correiosapi.apphb.com/cep/76873274',
  dataType: 'jsonp',
  crossDomain: true,
  contentType: "application/json",
  statusCode: {
    200: function(data) { console.log(data); } // Ok
    ,400: function(msg) { console.log(msg);  } // Bad Request
    ,404: function(msg) { console.log("CEP não encontrado!!"); } // Not Found
  }
});​
