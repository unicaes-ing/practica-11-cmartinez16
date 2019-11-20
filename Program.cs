using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Practica_11
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Escriba los datos del cliente: ");
                Console.WriteLine();
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Telefono: ");
                int cel = Convert.ToInt32(Console.ReadLine());
                Console.Write("Fecha de Nacimiento: ");
                string fecha = Console.ReadLine();
                Console.Write("Sueldo: ");
                double sueldo = Convert.ToDouble(Console.ReadLine());
                FileStream stream = new FileStream("empleado.dat",
                FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(nombre);
                binario.Write(cel);
                binario.Write(fecha);
                binario.Write(sueldo);
                stream.Close();
                binario.Close();
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un problema con el archivo binario.");
            }

            try
            {
                FileStream stream = new FileStream("empleados.dat",
                FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(stream);
                string nombre = binario.ReadString();
                int cel = binario.ReadInt32();
                string fecha = binario.ReadString();
                double sueldo = binario.ReadDouble();
                stream.Close();
                binario.Close();
                Console.Clear();
                Console.WriteLine("--------Información del empleado--------");
                Console.WriteLine();
                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Telefono: {0}", cel);
                Console.WriteLine("Fecha de nacimiento: {0}", fecha);
                Console.WriteLine("Sueldo: {0}", sueldo);
                Console.WriteLine("Presione <enter> para salir.");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un problema con el archivo binario.");
            }
        }
    }
    }