using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajeros
{
    class Front
    {
        public String ImprimirMenu()
        {
            Console.WriteLine("===== Bienvenidos a mi Cajero ======");
            Console.Write("|||||| Ingrese Nro de DNI: ");
            return Console.ReadLine();
        }


        public void ImprimirOpciones(Persona elegido)
        {
            Console.WriteLine("===== HOLA "+elegido.Nombre+" seleccione una opcion ======");
            Console.WriteLine("1.- retiro ");
            Console.WriteLine("2.- deposito ");
            String opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese monto a retirar: ");
                    double monto = double.Parse(Console.ReadLine());
                    elegido.Cuentas[0].Saldo = elegido.Cuentas[0].Saldo - monto;
                    Console.WriteLine("Retiro exitoso!, SU saldo actual es: "+ elegido.Cuentas[0].Saldo);
                    break;
                case "2":
                    Console.Write("Ingrese monto a depositar: ");
                    double deposito = double.Parse(Console.ReadLine());
                    elegido.Cuentas[0].Saldo = elegido.Cuentas[0].Saldo + deposito;
                    Console.WriteLine("Deposito exitoso!, SU saldo actual es: " + elegido.Cuentas[0].Saldo);
                    break;
            }
            

            
        }
    }
}
