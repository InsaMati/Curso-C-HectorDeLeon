using System.IO;

// Lectura de Archivo

try {
    string content = File.ReadAllText(@"C:\Users\matia\OneDrive\Escritorio\Hola\Pato.txt");
    Console.WriteLine(content);


    //string content2 = File.ReadAllText(@"C:\Users\matia\OneDrive\Escritorio\Hola\Pato2.txt");
    //Console.WriteLine(content2);

    throw new Exception("Ocurrio algo Raro");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("El archivo no existe.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Cerrar Archivo");
}

Console.WriteLine("Aca se sigue ejecutando");