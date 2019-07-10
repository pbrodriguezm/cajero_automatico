using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajeros
{
    class Program
    {
        static  List<Persona> personas;
        String nombrecajero;
        static void Main(string[] args)
        {
            personas = new List<Persona>();
            Front menu = new Front();
            String dni= menu.ImprimirMenu();
            Persona elegido = LeerArchivo(dni);
            menu.ImprimirOpciones(elegido);
            EscribirArchivo(elegido);

            Console.ReadKey();
        }

        private static void EscribirArchivo(Persona elegido)
        {

     
            //LEER EL ARCHIVO
            List<String> lineastxt=new List<string>();
            String line;
            String dni = elegido.Dni;
            StreamReader file = new StreamReader(@"D:\bd.txt");

            while ((line = file.ReadLine()) != null)
            {
                String[] datos = line.Split(','); // DIVIDE 
                if (datos[0] == dni)
                {
                    lineastxt.Add(datos[0] + "," + datos[1] + ", " + datos[2] + "," + datos[3] + "," + elegido.Cuentas[0].Saldo + "," + datos[5]);
                   
                }
                else
                {
                    lineastxt.Add(line);
                }
            }
            file.Close();
            //Escribir  archivo
            StreamWriter fichero; //Clase que representa un fichero
            fichero = File.CreateText(@"D:\bd.txt"); //Creamos un fichero
            foreach(string tmp in lineastxt){
                fichero.WriteLine(tmp);
            }
            fichero.Close();
        }

        private static Persona LeerArchivo(String dni)
        {
            Persona elElegido=null;
            String line;
            StreamReader file =new StreamReader(@"D:\bd.txt");
            while ((line = file.ReadLine()) != null)
            {
                String[] datos = line.Split(','); // DIVIDE 
                if (datos[0] == dni)
                {
                    elElegido = new Persona(datos[1], datos[2] + " " + datos[3], datos[0]);
                                                    //NOMBRE , APELLIDOS               , DNI
                    Cuenta laCuenta = new Cuenta(Double.Parse(datos[4]), datos[3], datos[5][0]);
                                                    //SALDO=doble,            CUENTA ,  MONEDA=char
                    elElegido.Cuentas.Add(laCuenta);
                    personas.Add(elElegido);
                    Console.WriteLine(line);
                }
            }

            file.Close();
            return elElegido;
        }
    }
}
