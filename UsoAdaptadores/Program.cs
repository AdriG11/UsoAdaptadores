//Ejemplo de escritura y lectura de datosen un rchivo de texto

string texto = "Ejemplo de texto.";
File.WriteAllText("ejemplo.txt",texto);

//Leer los datos
string texto2 = File.ReadAllText("ejemplo.txt");
Console.WriteLine($"Texto leído desde el archivo: {texto2}");

//Escribir datos en un archivo binario
int[] numeros = { 1, 2, 3, 4, 5 };
using (BinaryWriter br = new BinaryWriter(File.Open("numeros.bin", FileMode.Create)))
        foreach(int numero in numeros)
             br.Write(numero);

//Leer datos de un archivo binario
int[] numerosLeidos;
using(BinaryReader reader = new BinaryReader(File.Open("numeros.bin", FileMode.Open)))
{
    numerosLeidos = new int[5];
    for(int i = 0; i < numerosLeidos.Length; i++)
        numerosLeidos[i] = reader.ReadInt32();
}
Console.WriteLine("Numeros leidos desde un archivo binario");
foreach(int numero in numerosLeidos)
    Console.WriteLine(numero);
