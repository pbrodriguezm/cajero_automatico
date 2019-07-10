using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajeros
{
    class Persona
    {
        private String nombre;
        private String apellidos;
        private String dni;
        private List<Cuenta> cuentas;
        //CONTROL +R LUEGPO SUELTAN LA R Y APRETAN LA E Y SIGUEN PRESIONANDO CONTROL
        public Persona(string nombre, string apellidos, string dni)
        {
            cuentas = new List<Cuenta>();
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
        }
        //estos son los geters y seters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        internal List<Cuenta> Cuentas { get => cuentas; set => cuentas = value; }
    }
}
