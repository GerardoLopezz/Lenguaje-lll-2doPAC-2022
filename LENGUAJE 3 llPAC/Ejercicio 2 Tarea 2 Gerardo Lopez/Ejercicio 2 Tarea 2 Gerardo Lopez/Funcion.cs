using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_Tarea_2_Gerardo_Lopez
{
    public partial class Funcion : Form
    {
        public Funcion()
        {
            InitializeComponent();
        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
            string numero1 = numerotxt.Text;

            if (string.IsNullOrEmpty(numero1))
            {
                MessageBox.Show("Debe ingresar un numero");
                numerotxt.Focus();
                Calculartxt.Clear();
                return;
            }

                int numero = Convert.ToInt32(numerotxt.Text);
           

           if (numero % 2 ==0)
           {
               Calculartxt.Text = "El numero es par";
           }
           else
           {
               Calculartxt.Text = "El numero es impar";
           }
        }
    }
}
