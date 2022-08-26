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
catch (FormatException a)
{
    System.Console.WriteLine("no ingreso un numero");
   
}
catch(Exception e) {
    System.Console.WriteLine("Hubo un error, consulte con su desarrollador.");
}



