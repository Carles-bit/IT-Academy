function Fase1() {
    var textOut = "";
    var nom = ["C", "a", "r", "l", "e", "s"];
        
    for (i = 0; i < nom.length ; i++) {
        textOut += nom[i];
    }

    document.getElementById("outFase1").innerHTML = textOut;
}


function Fase2() {
    var textOut = "";
    var nom = ['C', 'a', 'r', 'l', 'e', 's', 'E', '1'];
    var numero = false;

    for (var i = 0; i < nom.length; i++) {
        switch (nom[i].toLowerCase()) {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                textOut += nom[i] + ": VOCAL <BR>";
                break;
            default:
                textOut += nom[i] + ": CONSONAT <BR>";
                break;
        }

        if (isNaN(nom[i]) == false) numero = true;
    }

    if (numero) {
        textOut += "<BR>Els noms de persones no contenen n&uacute;meros!";
    }

    document.getElementById("outFase2").innerHTML = textOut;
}

function Fase3() {
    var textOut = "";
    var nom = ['C', 'a', 'r', 'l', 'e', 's', 'E', '1'];
    var nomLower = ' ';
    var lletraCount = new Map();

   

    for (var i = 0; i < nom.length; i++) {

        nomLower = nom[i].toLowerCase();
        if (lletraCount.get(nomLower)==undefined)
        {
            lletraCount.set(nomLower,1);
        }
        else {
            lletraCount.set(nomLower,lletraCount.get(nomLower)+1);
        }
    }
    
    lletraCount.forEach(function (valor, clave, miMapa) {
        textOut += "<BR>Lletra " + clave+" apareix "+valor+" vegada/es"
    })
    
    document.getElementById("outFase3").innerHTML = textOut;
}

function Fase4() {
    var textOut = "";
    var name = ['C', 'a', 'r', 'l', 'e', 's'];
    var surname = ['G', 'a', 's', 'c', 'ó'];

    name.push(" ");
    var fullName = name.concat(surname);

    for (var i = 0; i < fullName.length; i++) {
        //ejemplo canvio de caracteres especiales
        //Seria mejor hacer con switch-case ...
        if (fullName[i] == 'ó') {
            textOut += '&oacute;'
        } else  textOut += fullName[i];
    }
    
    document.getElementById("outFase4").innerHTML = textOut;
}


