using LibreriaCoche;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente cliente;
        Cuenta cuenta;
        MovimientoCuenta movimientoCuenta;


        private void CrearCuentabutton1_Click(object sender, EventArgs e)
        {
            cliente = new Cliente(Identidadtxt.Text, NombreClientetxt.Text);

            cuenta = new Cuenta(NumeroCuentatxt.Text, cliente, DateTime.Now, 0);

            Saldotxt.Text = cuenta.Saldo.ToString("N");

        }

        private void AgregarMoviemientobutton2_Click(object sender, EventArgs e)
        {
            if (MontoMovimientotxt.Text == "")
            {
                errorProvider1.SetError(MontoMovimientotxt, "Digite un monto");
                MontoMovimientotxt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TipoMovimientocomboBox1.Text))
            {
                errorProvider1.SetError(TipoMovimientocomboBox1, "Seleccione un Tipo Movimiento");
                return;
            }

            if (TipoMovimientocomboBox1.Text == "Deposito")
            {
                cuenta.Depositar(Convert.ToDecimal(MontoMovimientotxt.Text));

                movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now,
                                                         Convert.ToDecimal(MontoMovimientotxt.Text),
                                                         TipoMovimientocomboBox1.Text);

                MovimientoslistBox1.Items.Add(
                                             "Deposito a la cuenta N. " + cuenta.NumeroCuenta +
                                             " por la cantidad de L. " + movimientoCuenta.Monto + 
                                             " con fecha: " + movimientoCuenta.Fecha
                    );

                Saldotxt.Text = cuenta.Saldo.ToString("N");
            }
            else if(TipoMovimientocomboBox1.Text == "Retiro")
            {
                bool pudoRetirar = cuenta.Ratirar(Convert.ToDecimal(MontoMovimientotxt.Text));

                if (pudoRetirar)
                {
                    movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, 
                                                            Convert.ToDecimal(MontoMovimientotxt.Text),
                                                            TipoMovimientocomboBox1.Text);

                    MovimientoslistBox1.Items.Add(
                                             "Retiro a la cuenta N. " + cuenta.NumeroCuenta +
                                             " por la cantidad de L. " + movimientoCuenta.Monto +
                                             " con fecha: " + movimientoCuenta.Fecha);

                    Saldotxt.Text = cuenta.Saldo.ToString("N");

                }
                else
                {
                    MessageBox.Show("La cuenta N. " + cuenta.NumeroCuenta + "no tiene saldo disponible para transaccionar");
                }
            }
        }
    }
}
