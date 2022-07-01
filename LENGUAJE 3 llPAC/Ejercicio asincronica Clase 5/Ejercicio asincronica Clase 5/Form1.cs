using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_asincronica_Clase_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "Proceso iniciado";
            //HornearPizza();
            HornearPizzaAsync();
            label1.Text = "Proceso terminado";
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private async  void Sumarbutton2_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(Numero1txt.Text);
            decimal numero2 = Convert.ToDecimal(Numero1txt.Text);

            decimal resultado = await SumarAsync(numero1, numero2);

            MessageBox.Show("La suma es: " + resultado.ToString());
        }

        private async Task<decimal> SumarAsync(decimal num1, decimal num2)
        {
            decimal suma = await Task.Run(() =>
            {
                return num1 + num2; 
            });
          
             return suma;   
  
        }
    }
}
