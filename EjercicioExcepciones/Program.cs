
using EjercicioExcepciones;

double num1, num2, suma, resta, divicion, multiplicacion;

try
{

    Console.WriteLine("Ingrese un numero: ");
    num1 = PedirNumero();

    Console.WriteLine("Ingrese un numero: ");
    num2 = PedirNumero();


    Operaciones operaciones = new Operaciones();

    suma = operaciones.Suma(num1, num2);
    resta = operaciones.Resta(num1, num2);
    multiplicacion = operaciones.Multipicacion(num1, num2);
    divicion = operaciones.Divicion(num1, num2);






}
catch (FormatException)
{
    Console.WriteLine("El dato no es valido, ingrese un numero");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre 0");
}
catch (Exception ex) { 

    Console.WriteLine($"Error {ex.Message}");   
}





static double PedirNumero() { 

   string input = Console.ReadLine();

    if (!double.TryParse(input, out double numero)) {

        throw new FormatException();
    }

    return numero;
}