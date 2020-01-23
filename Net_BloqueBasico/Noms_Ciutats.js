function Fase1() {
    var textOut = "";
    var ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6;

    textOut += "Ciutats introduides: <ul>";

    ciutat1 = prompt("Introdueix la Ciutat n\u00FAmero 1: ", "Barcelona");
    textOut += "<li>" + ciutat1 + "</li>";

    ciutat2 = prompt("Introdueix la Ciutat n\u00FAmero 2: ", "Madrid");
    textOut += "<li>" + ciutat2 + "</li>";
    
    ciutat3 = prompt("Introdueix la Ciutat n\u00FAmero 3: ", "Valencia");
    textOut += "<li>" + ciutat3 + "</li>";

    ciutat4 = prompt("Introdueix la Ciutat n\u00FAmero 4: ", "Malaga");
    textOut += "<li>" + ciutat4 + "</li>";

    ciutat5 = prompt("Introdueix la Ciutat n\u00FAmero 5: ", "Cadis");
    textOut += "<li>" + ciutat5 + "</li>";

    ciutat6 = prompt("Introdueix la Ciutat n\u00FAmero 6: ", "Santander");
    textOut += "<li>" + ciutat6 + "</li>";

    textOut += "</ul>";
    document.getElementById("outFase1").innerHTML = textOut;
}


function Fase2() {
    var textOut = "";

    var ciutat1 = "Barcelona";
    var ciutat2 = "Madrid";
    var ciutat3 = "Valencia";
    var ciutat4 = "Malaga";
    var ciutat5 = "Cadis";
    var ciutat6 = "Santander";

    var ciutats = [ ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 ];
    ciutats.sort();

    ciutats.forEach(function(value) {
        textOut = textOut + value + "<br>";
    });
       

    document.getElementById("outFase2").innerHTML = textOut;
}

function Fase3() {
    var textOut = "";

    var ciutat1 = "Barcelona";
    var ciutat2 = "Madrid";
    var ciutat3 = "Valencia";
    var ciutat4 = "Malaga";
    var ciutat5 = "Cadis";
    var ciutat6 = "Santander";

    var ciutats = [ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6];

    var ArrayCiutatsModificades = ciutats.map(function (value, index, array) {
        return value.replace(/a/gi, "4");
     });

    ArrayCiutatsModificades.sort();

    ArrayCiutatsModificades.forEach(function(value) {
        textOut = textOut + value + "<br>";
    });
    
    document.getElementById("outFase3").innerHTML = textOut;
}

function Fase4() {
    var textOut = "";

    var Barcelona = "Barcelona";
    var Madrid = "Madrid";
    var Valencia = "Valencia";
    var Malaga = "Malaga";
    var Cadis = "Cadis";
    var Santander = "Santander";
        
    var ciutat1 = new Array(Barcelona.length);
    var ciutat2 = new Array(Madrid.length);
    var ciutat3 = new Array(Valencia.length);
    var ciutat4 = new Array(Malaga.length);
    var ciutat5 = new Array(Cadis.length);
    var ciutat6 = new Array(Santander.length);

    for (var i = 0; i < ciutat1.length; i++)
    {
        ciutat1[i] = Barcelona[i];
    }
    textOut = textOut + Barcelona + " - ";
    ciutat1.reverse();
    ciutat1.forEach(function (value) {
        textOut = textOut + value;
    });
    textOut = textOut +  "<br>";
    
    for (var i = 0; i < ciutat2.length; i++) {
        ciutat2[i] = Madrid[i];
    }
    textOut = textOut + Madrid + " - ";
    ciutat2.reverse();
    ciutat2.forEach(function (value) {
        textOut = textOut + value;
    });
    textOut = textOut + "<br>";

    for (var i = 0; i < ciutat3.length; i++) {
        ciutat3[i] = Valencia[i];
    }
    textOut = textOut + Valencia + " - ";
    ciutat3.reverse();
    ciutat3.forEach(function (value) {
        textOut = textOut + value;
    });
    textOut = textOut + "<br>";

    for (var i = 0; i < ciutat4.length; i++) {
        ciutat4[i] = Malaga[i];
    }
    textOut = textOut + Malaga + " - ";
    ciutat4.reverse();
    ciutat4.forEach(function (value) {
        textOut = textOut + value;
    });
    textOut = textOut + "<br>";

    for (var i = 0; i < ciutat5.length; i++) {
        ciutat5[i] = Cadis[i];
    }
    textOut = textOut + Cadis + " - ";
    ciutat5.reverse();
    ciutat5.forEach(function (value) {
        textOut = textOut + value;
    });
    textOut = textOut + "<br>";

    for (var i = 0; i < ciutat6.length; i++) {
        ciutat6[i] = Santander[i];
    }
    textOut = textOut + Santander + " - ";
    ciutat6.reverse();
    ciutat6.forEach(function (value) {
        textOut = textOut + value;
    });
    textOut = textOut + "<br>";


    document.getElementById("outFase4").innerHTML = textOut;
}

