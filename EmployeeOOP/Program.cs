// See https://aka.ms/new-console-template for more information
using EmployeeOOP.Classes;

try
{
    // Declaracion de variables
    int day, month, year;

	Console.WriteLine("OOP APLICATION");
	Console.WriteLine("--------------");

    // Ingreso de datos
	Console.Write("Ingresar el día: ");
	day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicializacion de la clase Date
    Date dateObject = new Date(day,month,year);
    Console.WriteLine("\n");//Salto de linea
	Console.WriteLine(dateObject.ToString());
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}


