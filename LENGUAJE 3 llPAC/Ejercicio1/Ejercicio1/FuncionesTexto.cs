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
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void Generarbutton1_Click(object sender, EventArgs e)
        {
            string cadena = Cadenatxt.Text;

            //if(cadena.Length ==0)
            //{
            //    MessageBox.Show("Debe ingresar una cadena");
            //    Cadenatxt.Focus();
            //    return;
            //}

            if(string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("Debe ingresar una cadena");
                Cadenatxt.Focus();
                return;
            }

            Longitudlabel.Text = cadena.Length.ToString();

            PrimerCaracterlabel.Text = cadena.Substring(0, 1);

            Ultimocaracterlabel.Text = cadena.Substring(cadena.Length - 1, 1) ;

            Mayusculaslabel.Text = cadena.ToUpper();

            Minusculaslabel.Text = cadena.ToLower();

            Reemplazarlabel.Text = cadena.Replace("g", "*");

        }

        private void Cadenatxt_TextChanged(object sender, EventArgs e)
        {
            Cadenatxt.Text = Cadenatxt.Text.Replace("Gerardo", "*******");
        }
    }
}
