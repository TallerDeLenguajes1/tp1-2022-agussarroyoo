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
    private int antiguedad;
    private int edad;
    private double sueldoB;
    private double salario;

    

    private int calcularAntiguedad() {
        return //calcular hoy-ingreso;
    }
    private int calcularEdad() {
        return //calcular hoy-fecha de nac
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





}
