namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MovimientoslistBox1 = new System.Windows.Forms.ListBox();
            this.CrearCuentabutton1 = new System.Windows.Forms.Button();
            this.AgregarMoviemientobutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Identidadtxt = new System.Windows.Forms.TextBox();
            this.NombreClientetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroCuentatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Saldotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MontoMovimientotxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TipoMovimientocomboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreClientetxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Identidadtxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Saldotxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NumeroCuentatxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TipoMovimientocomboBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.MontoMovimientotxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimiento";
            // 
            // MovimientoslistBox1
            // 
            this.MovimientoslistBox1.FormattingEnabled = true;
            this.MovimientoslistBox1.Location = new System.Drawing.Point(12, 243);
            this.MovimientoslistBox1.Name = "MovimientoslistBox1";
            this.MovimientoslistBox1.Size = new System.Drawing.Size(498, 199);
            this.MovimientoslistBox1.TabIndex = 3;
            // 
            // CrearCuentabutton1
            // 
            this.CrearCuentabutton1.Location = new System.Drawing.Point(563, 243);
            this.CrearCuentabutton1.Name = "CrearCuentabutton1";
            this.CrearCuentabutton1.Size = new System.Drawing.Size(127, 47);
            this.CrearCuentabutton1.TabIndex = 4;
            this.CrearCuentabutton1.Text = "Crear Cuenta";
            this.CrearCuentabutton1.UseVisualStyleBackColor = true;
            this.CrearCuentabutton1.Click += new System.EventHandler(this.CrearCuentabutton1_Click);
            // 
            // AgregarMoviemientobutton2
            // 
            this.AgregarMoviemientobutton2.Location = new System.Drawing.Point(563, 317);
            this.AgregarMoviemientobutton2.Name = "AgregarMoviemientobutton2";
            this.AgregarMoviemientobutton2.Size = new System.Drawing.Size(127, 47);
            this.AgregarMoviemientobutton2.TabIndex = 5;
            this.AgregarMoviemientobutton2.Text = "Agregar Moviemiento";
            this.AgregarMoviemientobutton2.UseVisualStyleBackColor = true;
            this.AgregarMoviemientobutton2.Click += new System.EventHandler(this.AgregarMoviemientobutton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad";
            // 
            // Identidadtxt
            // 
            this.Identidadtxt.Location = new System.Drawing.Point(73, 17);
            this.Identidadtxt.Name = "Identidadtxt";
            this.Identidadtxt.Size = new System.Drawing.Size(137, 20);
            this.Identidadtxt.TabIndex = 1;
            // 
            // NombreClientetxt
            // 
            this.NombreClientetxt.Location = new System.Drawing.Point(73, 53);
            this.NombreClientetxt.Name = "NombreClientetxt";
            this.NombreClientetxt.Size = new System.Drawing.Size(137, 20);
            this.NombreClientetxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // NumeroCuentatxt
            // 
            this.NumeroCuentatxt.Location = new System.Drawing.Point(93, 18);
            this.NumeroCuentatxt.Name = "NumeroCuentatxt";
            this.NumeroCuentatxt.Size = new System.Drawing.Size(137, 20);
            this.NumeroCuentatxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Cuenta";
            // 
            // Saldotxt
            // 
            this.Saldotxt.Enabled = false;
            this.Saldotxt.Location = new System.Drawing.Point(93, 53);
            this.Saldotxt.Name = "Saldotxt";
            this.Saldotxt.ReadOnly = true;
            this.Saldotxt.Size = new System.Drawing.Size(137, 20);
            this.Saldotxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto";
            // 
            // MontoMovimientotxt
            // 
            this.MontoMovimientotxt.Location = new System.Drawing.Point(73, 33);
            this.MontoMovimientotxt.Name = "MontoMovimientotxt";
            this.MontoMovimientotxt.Size = new System.Drawing.Size(137, 20);
            this.MontoMovimientotxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo Movimiento";
            // 
            // TipoMovimientocomboBox1
            // 
            this.TipoMovimientocomboBox1.FormattingEnabled = true;
            this.TipoMovimientocomboBox1.Items.AddRange(new object[] {
            "Deposito",
            "Retiro"});
            this.TipoMovimientocomboBox1.Location = new System.Drawing.Point(452, 32);
            this.TipoMovimientocomboBox1.Name = "TipoMovimientocomboBox1";
            this.TipoMovimientocomboBox1.Size = new System.Drawing.Size(137, 21);
            this.TipoMovimientocomboBox1.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.AgregarMoviemientobutton2);
            this.Controls.Add(this.CrearCuentabutton1);
            this.Controls.Add(this.MovimientoslistBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreClientetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Identidadtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Saldotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumeroCuentatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TipoMovimientocomboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MontoMovimientotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox MovimientoslistBox1;
        private System.Windows.Forms.Button CrearCuentabutton1;
        private System.Windows.Forms.Button AgregarMoviemientobutton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

