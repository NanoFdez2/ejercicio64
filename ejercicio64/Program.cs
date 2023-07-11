// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Definir temperatura Como Real;
//definir fah Como Real;
//Definir temp0a10, temp11a20, tempMas20 Como Real;
//Definir contador Como real;
//Definir maxTemp, minTemp Como Real;
//Definir sumaTemps Como Real;
//Definir promedio Como Real;

double temperatura;
double fah;
double temp0a10 = 0, temp11a20 = 0, tempmas20 = 0;
double contador = 0;
double maxtemp = 0, mintemp = 300;
double promedio = 0;
double diamin = 0, diamax = 0;
double sumatemps = 0;
do
{
    Console.WriteLine("Ingrese una temperatura:");
    temperatura = double.Parse(Console.ReadLine());
    fah = 1.8 * temperatura + 32;
    Console.WriteLine($"{temperatura}° Celsius son {fah}° Farenheit.");
    contador++;
    sumatemps =+ temperatura;
    if (temperatura >= 0 && temperatura <= 10)
    {
        temp0a10++;
    }
    if (temperatura >= 11 && temperatura <= 20)
    {
        temp11a20++;
    }
    if (temperatura > 20)
    {
        tempmas20++;
    }
    if (temperatura < mintemp)
    {
        mintemp = temperatura;
        diamin = contador;
    }
    if (temperatura > maxtemp)
    {
        maxtemp = temperatura;
        diamax = contador;
    }
} while (contador < 10);
promedio = sumatemps / contador;

//Escribir "Hay un total de: ", temp0a10, " temperaturas entre 0 y 10 grados celsius.";
//Escribir "Hay un total de: ", temp11a20, " temperaturas entre 11 y 20 grados celsius.";
//Escribir "Hay un total de: ", tempMas20, " temperaturas mayores a 20 grados celsius.";
//Escribir "La temperatura máxima fue de: ", maxTemp, "° Celsius y fue en el día ", diaMax;
//Escribir "La temperatura mínima fue de: ", minTemp, "° Celsius y fue en el día ", diaMin;
//Escribir "El promedio de temperatura fue de: ", promedio, "° celsius.";

Console.WriteLine($"Hay un total de {temp0a10} temperaturas entre 0 y 10 grados Celsius.");
Console.WriteLine($"Hay un total de {temp11a20} temperaturas entre 11 y 20 grados Celsius.");
Console.WriteLine($"Hay un total de {tempmas20} temperaturas mayores a 20 grados Celsius.");
Console.WriteLine($"La temperatura máxima fue de {maxtemp}° Celsius y fue en el día {diamax}.");
Console.WriteLine($"La temperatura mínima fue de {mintemp}° Celsius y fue en el día {diamin}.");
Console.WriteLine($"El promedio de temperatura es {promedio}° Celsius.");
Console.WriteLine("Carlitos entrega la nena");