using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_Tarea_Gerardo_López
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
            string SalarioAc = SalarioActualtxt.Text;

            if (string.IsNullOrEmpty(SalarioAc))
            {
                MessageBox.Show("Por favor, ingrese su salario actual");
                SalarioActualtxt.Focus();
                return;
            }

            string PromedioV = PromedioVentastxt.Text;

            if (string.IsNullOrEmpty(PromedioV))
            {
                MessageBox.Show("Por favor, ingrese su promedio de ventas");
                PromedioVentastxt.Focus();
                return;
            }

            string AntiguedadE = Antiguedadtxt.Text;

            if (string.IsNullOrEmpty(AntiguedadE))
            {
                MessageBox.Show("Por favor, ingrese sus años de antiguedad en la empresa");
                Antiguedadtxt.Focus();
                return;
            }

            int Edad = Convert.ToInt32(Edadtxt.Text);
            int Salario = Convert.ToInt32(SalarioActualtxt.Text);
            int Promedio = Convert.ToInt32(PromedioVentastxt.Text);
            int Antiguedad = Convert.ToInt32(Antiguedadtxt.Text);
            int Aumento;

            if (Edad>=30 && Promedio> 10000 && Antiguedad>=10)
            {
                Aumento = Convert.ToInt32(Salario * 0.05);
                AumentoSalariotxt.Text = Convert.ToString(Aumento);
            }
            else
            {
                Aumento=Convert.ToInt32(Salario*0);
                AumentoSalariotxt.Text=Convert.ToString(Aumento);
            }
            int Nuevos;
            Nuevos = Salario + Aumento;
            NuevoSalariotxt.Text = Convert.ToString(Nuevos);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaNacimiento = dateTimePicker1.Value;

            int Edad = DateTime.Now.Year - FechaNacimiento.Year;
            
            if (FechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("Error, Ingrese fecha de nacimiento valida");
            }
            {
                Edadtxt.Text = Convert.ToString(Edad);
                if (FechaNacimiento.Month >= DateTime.Now.Month)
                {
                    --Edad;
                }
                Edadtxt.Text = Convert.ToString(Edad);
            }
            
        }

        private void SalarioActualtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PromedioVentastxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Antiguedadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
