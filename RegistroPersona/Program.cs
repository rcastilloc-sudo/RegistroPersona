/*Registrar datos de una persona
 nombres, apellidos, sexo, edad
*/

struct Persona
{
    public string nombre;
    public string apellido;
    public Boolean sexo;
    public int edad;
}

class Program()
{
    static Persona[] personas = new Persona[10];

    public static void Agregar(String nom, String ape, int eda, Boolean sex, int posicion)
    {
        Persona per = new Persona();
        per.nombre = nom;
        per.apellido = ape;
        per.edad = eda;
        per.sexo = sex;
        personas[posicion] = per;
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro guardado.");
        Console.ResetColor();
    }

    public static void PedirDatos(int pos)
    {
     string nombre;
     string apellido;
     bool sexo;
     int edad;

        Console.WriteLine("Dime tu nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Dime tu apellido: ");
        apellido = Console.ReadLine();
        Console.WriteLine("Dime tu sexo [True: Hombre - False: Mujer]: ");
        sexo = Boolean.Parse(Console.ReadLine());
        Console.WriteLine("Dime tu edad: ");
        edad = int.Parse(Console.ReadLine());

        Agregar(nombre, apellido, edad, sexo, 0);
    }

    public static void Main()
    {

    }
}
