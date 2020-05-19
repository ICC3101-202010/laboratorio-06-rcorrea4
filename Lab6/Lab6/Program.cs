using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Desea cargar los datos de la empresa desde un archivo? 1.Si -- 2.No");
            string opt = null;
            while (opt!="1" && opt != "2")
            {
                opt = Console.ReadLine();
                if (opt == "1")
                {
                    try
                    {
                        Console.WriteLine("Cargando los datos desde el archivo");
                        Empresa.desserializarEmpresa();
                        
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        Console.WriteLine("El archivo no existe");
                        Console.WriteLine("Ingrese los datos manualmente");
                        opt = "2";
                    }
                    
                }
                if (opt == "2")
                {
                    Console.WriteLine("Ingrese nombre de la empresa");
                    string nameE = Console.ReadLine();
                    Console.WriteLine("Ingrese rut de la empresa");
                    string rutE = Console.ReadLine();
                    Empresa empresa1 = new Empresa(nameE, rutE);
                    Division division = new Division("division");
                    Persona persona1 = new Persona("Juan","Perez","12345","Jefe");
                    division.Personal.Add(persona1);
                    empresa1.Divisiones.Add(division);
                    Departamento departamento = new Departamento("departamento de transito" );
                    Persona persona2 = new Persona("John", "Travolta","1234", "Asesor financiero");
                    Persona persona3 = new Persona("a", "b", "1234", "Asesor financiero");
                    division.EncargadoDivision = persona1;
                    departamento.EncargadoDivision = persona2;
                    
                    departamento.Personal.Add(persona3);
                    departamento.Personal.Add(persona2);
                    empresa1.Divisiones.Add(departamento);
                    empresa1.serializarEmpresa();
                }
                else if(opt !="1"&&opt!="2")
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
                

            }
        }
    }
}
