// See https://aka.ms/new-console-template for more information

struct Direccion {
        string calle;
        int nro;

    }

public class Empleado {
    private string nombre;
    private string apellido;
    private Direccion direc;
    private DateTime fechaIng;
    private DateTime fechaNac;
    private string datosProf;
    private double sueldoB;
    private double salario;
    
    public Empleado(string nombre, string ape, Direccion dire, DateTime fechaIng, DateTime fechaNac, string datosProf, int ant, double sueldoB) {
        this.nombre = nombre;
        this.apellido = ape;
        this.direc = dire;
        this.fechaIng = fechaIng;
        this.fechaNac = fechaNac;
        this.datosProf = datosProf;
        this.antiguedad = ant;
        this.sueldoB = sueldoB;
      
    }
    
    public listarData() {
        System.Console.WriteLine("Nombre: " + nombre);
        System.Console.WriteLine("Apellido: " + apellido);
        System.Console.WriteLine("Direcion: ");
        System.Console.WriteLine("Calle: " + Direc.calle);
        System.Console.WriteLine("NRO: " + Direc.nro);
        System.Console.WriteLine("Fecha de ingreso: " + FechaIng.Year);
        System.Console.WriteLine("Antiguedad: " + calcularAntiguedad());
        System.Console.WriteLine("Edad: " + calcularEdad());
        System.Console.WriteLine("Datos profesionales: " + datosProf);
        System.Console.WriteLine("Sueldo basico: " + sueldoB);
        System.Console.WriteLine("Salario: " + calcularSalario());
    }
    private int calcularAntiguedad() {
        return DateTime.Today.AddTicks(-fechaIng.Ticks).Year - 1;
    }
    private int calcularEdad() {
        return DateTime.Today.AddTicks(-fechaNac.Ticks).Year - 1;
    }

    private double calcularDesc() {
        return sueldoB * 0.15;
    }

    private double calcularAdicional() {
        if (antiguedad <= 20)
        {
            return sueldoB * 0.01 * antiguedad;
        } else {
            return sueldoB * 0.25;
        }
        
    }

    private double calcularSalario() {
        return sueldoB + calcularAdicional() - calcularDesc();
    }


    public string Nombre{
        get{
            return nombre;
        } set {
            nombre = value;
        }
    }
    public string Apellido{
        get{
            return apellido;
        } set {
            apellido = value;
        }
    }
    public Direccion Direc{
        get{
            return direc;
        } set {
            direc = value;
        }
    }
    public DateTime FechaIng{
        get{
            return fechaIng; 
        } set {
            fechaIng = value;
        }
    }
    public DateTime FechaNac{
        get{
            return fechaNac;
        } set {
            fechaNac = value;
        }
    }
    public string DatosProf{
        get{
            return datosProf;
        } set {
            datosProf = value;
        }
    }
    public int Antiguedad{
        get{
            return antiguedad;
        } set {
            antiguedad = value;
        }
    }
    public int Edad{
        get{
            return calcularEdad();
        } 
    }
    public double SueldoB{
        get{
            return sueldoB;
        } set {
            sueldoB = value;
        }
    }
    public double Salario{
        get{
            return calcularSalario();
        } 
    }


}
