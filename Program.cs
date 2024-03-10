// See https://aka.ms/new-console-template for more information

//Conexión
using System.Data.SqlClient;

static string conexionstring = "server= localhost ; database= SISTEMA_VENTAS ; integrated security= true";

SqlConnection conexion = new SqlConnection(conexionstring);

//Botones

private void btn_Conectar_Click(object sender, EventArgs e)
{
    conexion.Open()
    MessageBox.Show("La conexion a la DB: " + conexion.Database + " ha sido exitosa");
}

private void btn_Desconectar_Click(object sender, EventArgs e)
{
    conexion.Close("Se ha desconectado correctamente");
}

Console.WriteLine("DATOS DE ESTUDIANTES");
Console.WriteLine();


string nombre,area_tecnica;
char genero;
int edad;
double estatura;
bool activo;

Console.Write("Nombre: ");
nombre = Console.ReadLine();

Console.Write("Carrera: ");
area_tecnica = Console.ReadLine();

Console.Write("Genero: ");


genero = Convert.ToChar(Console.ReadLine());

Console.Write("Edad: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Estatura: ");
estatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Estado: ");
activo = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine();
(//Imprimir datos en pantalla

Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Carrera: {area_tecnica}");
Console.WriteLine($"Genero: {genero}");
Console.WriteLine($"Edad: {edad}");
Console.WriteLine($"Estatura: {estatura}");
Console.WriteLine($"Estatura: {activo}");

Console.WriteLine();

Console.WriteLine($"Su nombre es {nombre} y tiene {edad} años");





