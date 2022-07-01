using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
            float Nota1;
            float Nota2;
            float Nota3;
            float Nota4;

            Nota1 = Convert.ToInt32(Nota1txt.Text);
            Nota2 = Convert.ToInt32(Nota2txt.Text);
            Nota3 = Convert.ToInt32(Nota3txt.Text);
            Nota4 = Convert.ToInt32(Nota4txt.Text);

            MessageBox.Show("El promedio del estudiantes es: " + Promedio(Convert.ToInt32(Nota1txt.Text), Convert.ToInt32(Nota2txt.Text), Convert.ToInt32(Nota3txt.Text), Convert.ToInt32(Nota4txt.Text)));
        }

        //Funcion
        private float Promedio(float a, float b, float c, float d)
        {
            return (a + b + c + d) / 4;
        }

    }
}
