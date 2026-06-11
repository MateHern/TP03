namespace Tp03Ahorcado.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;

    public PalabrasAhorcado()
    {
        palabras = new List<string>();

        palabras.Add("PABLIDIS");
        palabras.Add("VELOCIRAPTOR");
        palabras.Add("TRICERATOPS");
        palabras.Add("DIPLODOCUS");
        palabras.Add("TIRANOSAURIOREX");
        palabras.Add("GAVIOTAS");
        palabras.Add("COCODRILO");
        palabras.Add("CASTORES");
        palabras.Add("ALMOHADA");
        palabras.Add("PTERODACTILO");
    }

    public string ObtenerPalabra()
    {
        Random random = new Random();

        int indiceAleatorio = random.Next(palabras.Count);

        string palabraAleatoria = palabras[indiceAleatorio];

        return palabraAleatoria;
    }
}