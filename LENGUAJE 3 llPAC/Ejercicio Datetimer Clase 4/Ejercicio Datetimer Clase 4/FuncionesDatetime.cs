using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Datetimer_Clase_4
{
    public partial class FuncionesDatetime : Form
    {
        public FuncionesDatetime()
        {
            InitializeComponent();
        }

        private void Mostrarbutton1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            //MessageBox.Show("Año:" + fecha.Year, "Formato de Fecha", MessageBoxButtons.OK,MessageBoxIcon.Information);
            //MessageBox.Show("Mes:" + fecha.Month,"Formato de Fecha", MessageBoxButtons.OK,MessageBoxIcon.Information);
            //MessageBox.Show("Dia:"   + fecha.Day,"Formato de Fecha",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //MessageBox.Show("Dia:" + fecha.DayOfWeek,"Formato de Fecha",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //MessageBox.Show("Día:" + fecha.DayOfYear, "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(fecha.Year + "-" +fecha.Month+"-"+fecha.Day,"Formato de Fecha",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //MessageBox.Show(fecha.AddDays(3).ToShortDateString(), "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(fecha.AddDays(3).ToLongDateString(), "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(fecha.AddDays(-10).ToShortDateString(), "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show(DevuelveLaEdadPersona(fecha).ToString(), "Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private int DevuelveLaEdadPersona(DateTime fechanacimiento)
        {
            DateTime _fechanacimiento = fechanacimiento;
            DateTime _fechaactual = DateTime.Now;

            int edad = 0;

            if (_fechanacimiento >= _fechaactual)
            {
                edad = 0;
            }
            else
            {
                edad = _fechaactual.Year - _fechanacimiento.Year;
                if(_fechanacimiento.Month > _fechaactual.Month)
                {
                    --edad;
                }
            }

            return edad;
        }
    }
}
