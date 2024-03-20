// See https://aka.ms/new-console-template for more information
using ExamenProdigiaCLG;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");

//Dado un String arbitrario que puede contener caracteres alfanuméricos y el “espacio”, escribe un programa que determine la longitud de la última palabra. Las palabras son un grupo de caracteres separados por espacios. Ejm
//- String: “La hora exacta es inexacta”, Resultado: 8
//- String “”, Resultado: 0

//string palabra = "La hora exacta es inexacta";

//var palabraSplit = palabra.Split(' ');
//Console.WriteLine("Resultado: {0}", palabraSplit.LastOrDefault().Length);

//Dada una lista de palabras, escribe un programa para encontrar la palabra más larga en la lista hecha de otras palabras de la lista.
//Ejemplo:
//input: aguas, par, rayo, carro, paraguas, parquimetro, metro
//output: paraguas


List<string> palabras = new List<string>() { "aguas", "par", "rayo", "carro", "paraguas", "parquimetro", "metro", "parqui" };



List<PalabraDTO> palabrasCalculadas = new List<PalabraDTO>();

foreach (string pl in palabras)
{
    var palabraIngresar = new PalabraDTO();
    palabraIngresar.Palabra = pl;
    palabraIngresar.Longitud = pl.Length;
    palabrasCalculadas.Add(palabraIngresar);
};

var palabrasOrdenadas = palabrasCalculadas.OrderByDescending(x => x.Longitud);

var esLaPalabraMasLarga = false;
var palabraEncontrada = "";

//Console.WriteLine("Palabra larga: " + palabrasOrdenadas.FirstOrDefault().Palabra);

foreach (var pl in palabrasOrdenadas)
{
    Console.WriteLine("PL: " + pl.Palabra);
    var longPalabrasEncontradas = 0;
    foreach (var palabra in palabrasOrdenadas)
    {

        if (longPalabrasEncontradas == pl.Longitud)
        {
            esLaPalabraMasLarga = true;
            break;
        }
        else
        {
            if (pl.Palabra.Contains(palabra.Palabra) && pl.Palabra != palabra.Palabra)
            {
                longPalabrasEncontradas = longPalabrasEncontradas + palabra.Palabra.Length;
            };
        }

    }
    if (longPalabrasEncontradas == pl.Longitud) palabraEncontrada = pl.Palabra;
    if (esLaPalabraMasLarga)break;
}

Console.WriteLine(palabraEncontrada);