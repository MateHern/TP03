const palabra = document.getElementById("PalabraSec").value;

const guion = document.getElementById("Guion");
const intentosTexto = document.getElementById("Intentos");
const resultado = document.getElementById("Resultado");

let palabraMostrada = "";
let intentos = 10;

for(let i = 0; i < palabra.length; i++)
{
    palabraMostrada = palabraMostrada + "-";
}

guion.innerHTML = palabraMostrada;

function Cambiar_()
{
    let letra = document.getElementById("Letra").value;

    letra = letra.toUpperCase();

    let nuevaPalabra = "";
    let encontro = false;

    for(let i = 0; i < palabra.length; i++)
    {
        if(palabra[i] == letra)
        {
            nuevaPalabra = nuevaPalabra + letra;
            encontro = true;
        }
        else
        {
            nuevaPalabra = nuevaPalabra + palabraMostrada[i];
        }
    }

    palabraMostrada = nuevaPalabra;

    guion.innerHTML = palabraMostrada;

    if(encontro == false)
    {
        intentos = intentos - 1;
        intentosTexto.innerHTML = intentos;
    }

    if(palabraMostrada == palabra)
    {
        resultado.innerHTML = "¡GANASTE!";
    }

    if(intentos == 0)
    {
        resultado.innerHTML = "PERDISTE";
    }

    document.getElementById("Letra").value = "";
}