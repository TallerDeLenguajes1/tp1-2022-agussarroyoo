// See https://aka.ms/new-console-template for more information

// Problema 2:
// Realizar una aplicación de consola que cargue 2 números y haga la división entre ellos.




try
{
    System.Console.WriteLine("Ingrese el primer numero");
    int num1 = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Ingrese el segundo numero");
    int num2 = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("{0} / {1} = {2}", num1,num2,num1/num2);
}
catch (DivideByZeroException)
{
    
    System.Console.WriteLine("El divisor es cero");
}
catch (FormatException)
{
    
    System.Console.WriteLine("rror en el formato. Debe ingresar un numero");
}
catch (Exception)
{
    
    System.Console.WriteLine("Error en el programa.");
}




