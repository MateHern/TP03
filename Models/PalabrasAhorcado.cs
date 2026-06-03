public class PalabrasAhorcado{

private List <string> palabras;

public PalabrasAhorcado(){
    palabras = new List<string>();
    palabras.Add("PABLIDIS");
    palabras.Add("VELOCIRAPTOR");    
    palabras.Add("TRICERATOPS");
    palabras.Add("DIPLODOCUS");
    palabras.Add("TIRANOSAURIOREX");
    palabras.Add("GABIOTAS");
    palabras.Add("COCODRILO");
    palabras.Add("CASTORES");
    palabras.Add("ALMOHADA");
    palabras.Add("TERODACTILO");
}
public string ObtenerPalabra(){
Random random = new Random();
int indiceAleatorio = random.Next(palabras.Count);
string PalabraAleatorio = palabras[indiceAleatorio];
return PalabraAleatorio;
}
}
