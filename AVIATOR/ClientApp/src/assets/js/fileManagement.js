

//scmod.innerHTML = xmlString;


var FileManagement = function () {

  var xhr = new XMLHttpRequest();

  xhr.open('GET', 'https://cryptoart20210310221023.azurewebsites.net/xml/reformschool.xml', true);

  xhr.timeout = 2000; // time in milliseconds

  xhr.onloadend = function () {
    // Request finished. Do processing here.
    if (this.responseXML != null) {
      var pe = new ParseEngine();
      setTimeout(pe.process(this.responseXML.documentElement), 0);
    }
  };

  xhr.ontimeout = function (e) {
    console.log("what");
    // XMLHttpRequest timed out. Do something here.
  };

  xhr.send(null);

}
