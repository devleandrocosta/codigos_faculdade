function caucular(){
    var num1=parseFloat(document.getElementById("num1").value);
    var num2=parseFloat(document.getElementById("num2").value);
    var operador=document.getElementById("operador").value;
    var resul=0;

    if(operador == "+"){
        resul = num1+num2;
    }
    else if(operador == "-"){
        resul = num1-num2;
    }
    else if(operador == "/"){
        resul = num1/num2;
    }
    else if(operador == "*"){
        resul = num1*num2;
    }
    else{
        alert("OPERAÇAO INVALIDA");
    }
    document.getElementById("resul").value=resultado;

}