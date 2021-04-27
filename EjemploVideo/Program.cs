using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, edad = 0;
            char rpta;
            //Ariel agrego Dni
            String nombre = "", apellido = "", sexo = "" , dni="" ;
            do
            {
                Menu();
                do
                {
                    Console.WriteLine("Ingrese una opción: ");
                    op = int.Parse(Console.ReadLine());
                } while (op <= 0 || op >= 4);
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nomnbre: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su apellido: ");
                        apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese su sexo: ");
                        sexo = Console.ReadLine();
                        Console.WriteLine("Ingrese su Dni: ");
                        dni = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Ingrese su edad: ");
                            edad = int.Parse(Console.ReadLine());
                        } while (edad <= 17 || edad >= 100);
                        break;
                    case 2:
                        if (nombre == "") 
                        {
                            Console.WriteLine("No hay datos para mostrar. ");
                        }else
                        MostrarDatos(nombre, apellido, sexo, edad,dni); break;
                    case 3: return; 
                }
                Console.WriteLine("Desea ingresar una nueva opción?: ");
                rpta = char.Parse(Console.ReadLine());
            } while (rpta == 's');
   
        }

        private static void Menu()
        {
            Console.WriteLine("---------Menú---------");
            Console.WriteLine("1. Registrar datos");
            Console.WriteLine("2. Ver datos");
            Console.WriteLine("3. Salir");
        }

        private static void MostrarDatos(string nombre, string apellido, string sexo, int edad,string dni)
        {
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su apellido es: " + apellido);
            Console.WriteLine("Su sexo es: " + sexo);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su Dni es : " + dni);
        }

    }

}
