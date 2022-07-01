using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Perro
    {
        //Atributos
        private string nombre;
        private string raza;
        private decimal altura;

        //Propiedades
        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; } 
        }
        public string Raza { 
            get { return raza; } 
            set { raza = value; } 
        }
        public decimal Altura {
            get { return altura; } 
            set { altura = value; } 
        }

        //Otra  manera de crear propiedades
        //public string Nombre { get; set; }
        //public string Raza { get; set; }
        //public decimal Altura { get; set; }

        //Constructor
        public Perro ()
        {
        }

        public Perro (string _nombre, string _raza, decimal _altura)
        {
            nombre = _nombre;
            raza = _raza;
            altura = _altura;
        }

        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        //Metodos
        public decimal DevuelveAltura()
        {
            return Altura;
        }

        public string Comer(string comida)
        {
            return Nombre + " comerá " + comida;
        }


    }
}
