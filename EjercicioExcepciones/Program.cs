// See https://aka.ms/new-console-template for more information
using EjercicioExcepciones;

Console.WriteLine("Hello, World!");


double num1, num2, suma, resta, divicion, multiplicacion;

try {

    Console.WriteLine("Ingrese un numero: ");
    num1 = PedirNumero();

    Console.WriteLine("Ingrese un numero: ");
    num2 = PedirNumero();   


    Operaciones operaciones = new Operaciones();

    suma = operaciones.Suma(num1, num2);
    resta = operaciones.Resta(num1, num2);  
    multiplicacion = operaciones.Multipicacion(num1, num2);  






}catch (Exception) { }    


static double PedirNumero() { 

   string input = Console.ReadLine();

    if (!double.TryParse(input, out double numero)) {

        throw new FormatException();
    }

    return numero;
}