// See https://aka.ms/new-console-template for more information

// Problema 1:
// Realizar una aplicación de consola que cargue de un número entero por teclado e
// imprimir su cuadrado.

System.Console.WriteLine("Ingrese un numero para elevarlo al cuadrado xd");

try
{
    int num;  
    num = Int32.Parse(Console.ReadLine());

    System.Console.WriteLine("El cuadrado del numero ingresado es " + num*num);

}
catch (FormatException)
{
    System.Console.WriteLine("no ingreso un numero");
   
}
catch(Exception) {
    System.Console.WriteLine("Hubo un error, consulte con su desarrollador.");
}

// Problema 2:
// Realizar una aplicación de consola que cargue 2 números y haga la división entre ellos.

try
{
    System.Console.WriteLine("Ingrese el dividendo");
    int a = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Ingrese el divisor");
    int b = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("El resultado de la division es " + a/b);
}
catch (DivideByZeroException)
{
    System.Console.WriteLine("No está contemplada la division por cero");
}
catch(FormatException) 
{
    System.Console.WriteLine("Debe ingresar un numero");
}
catch(Exception) 
{
    System.Console.WriteLine("Hubo un error.");
}


// Problema 3:
// Cree una aplicación que ingrese kilómetros conducidos y litros usados, y calcule
// kilómetros por litro..

try
{
    System.Console.WriteLine("Ingrese los km");
    double km = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Ingrese los litros");
    double lts = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Los km conducidos por litro usado fueron " + km/lts);
    //armar excepcion de si litro es 0 o si km/lts son negativos


}
catch (DivideByZeroException)
{
    System.Console.WriteLine("");
}