using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Perro
    {
        private string _nombre;
        private int _edad;

        public int Edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }
        

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public Perro(string nombre, int edad)
        {
            this._nombre = nombre;
            this._edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("Datos del perro:");
            sb.AppendLine("================");
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Edad: " + this.Edad);
            return sb.ToString();
        }

        public static int OrdenarPorNombreAscendente(Perro perroUno,Perro perroDos)
        {
            return string.Compare(perroUno.Nombre, perroDos.Nombre);
        }

        public static int OrdenarPorNombreDescendente(Perro perroUno, Perro perroDos)
        {
            return string.Compare(perroUno.Nombre, perroDos.Nombre);
        }

        public static int OrdenarPorEdad(Perro perroUno, Perro perroDos)
        {
            if (perroUno.Edad == perroDos.Edad)
                return 0;
            else
            {
                if (perroUno.Edad < perroDos.Edad)
                    return 1;
                else
                    return -1;
            }
            //return string.Compare(perroUno.Edad.ToString(), perroDos.Edad.ToString());
        }
    }
}
