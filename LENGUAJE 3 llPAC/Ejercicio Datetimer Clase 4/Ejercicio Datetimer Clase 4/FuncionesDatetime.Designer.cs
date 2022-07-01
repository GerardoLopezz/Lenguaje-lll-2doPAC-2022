namespace Ejercicio_Datetimer_Clase_4
{
    partial class FuncionesDatetime
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
            this.Mostrarbutton1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Mostrarbutton1
            // 
            this.Mostrarbutton1.Location = new System.Drawing.Point(156, 24);
            this.Mostrarbutton1.Name = "Mostrarbutton1";
            this.Mostrarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton1.TabIndex = 0;
            this.Mostrarbutton1.Text = "Mostrar";
            this.Mostrarbutton1.UseVisualStyleBackColor = true;
            this.Mostrarbutton1.Click += new System.EventHandler(this.Mostrarbutton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // FuncionesDatetime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 249);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Mostrarbutton1);
            this.Name = "FuncionesDatetime";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mostrarbutton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

