namespace Ejercicio_1
{
    partial class FuncionesProcedimientos
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
            this.Valor1txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Valor2txt = new System.Windows.Forms.TextBox();
            this.Ejecutarbutton1 = new System.Windows.Forms.Button();
            this.Restarbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Valor1txt
            // 
            this.Valor1txt.Location = new System.Drawing.Point(107, 35);
            this.Valor1txt.Name = "Valor1txt";
            this.Valor1txt.Size = new System.Drawing.Size(155, 20);
            this.Valor1txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valro 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2";
            // 
            // Valor2txt
            // 
            this.Valor2txt.Location = new System.Drawing.Point(107, 64);
            this.Valor2txt.Name = "Valor2txt";
            this.Valor2txt.Size = new System.Drawing.Size(155, 20);
            this.Valor2txt.TabIndex = 3;
            // 
            // Ejecutarbutton1
            // 
            this.Ejecutarbutton1.Location = new System.Drawing.Point(107, 114);
            this.Ejecutarbutton1.Name = "Ejecutarbutton1";
            this.Ejecutarbutton1.Size = new System.Drawing.Size(104, 23);
            this.Ejecutarbutton1.TabIndex = 4;
            this.Ejecutarbutton1.Text = "Ejecutar";
            this.Ejecutarbutton1.UseVisualStyleBackColor = true;
            this.Ejecutarbutton1.Click += new System.EventHandler(this.Ejecutarbutton1_Click);
            // 
            // Restarbutton2
            // 
            this.Restarbutton2.Location = new System.Drawing.Point(107, 157);
            this.Restarbutton2.Name = "Restarbutton2";
            this.Restarbutton2.Size = new System.Drawing.Size(104, 23);
            this.Restarbutton2.TabIndex = 5;
            this.Restarbutton2.Text = "Restar";
            this.Restarbutton2.UseVisualStyleBackColor = true;
            this.Restarbutton2.Click += new System.EventHandler(this.Restarbutton2_Click);
            // 
            // FuncionesProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 225);
            this.Controls.Add(this.Restarbutton2);
            this.Controls.Add(this.Ejecutarbutton1);
            this.Controls.Add(this.Valor2txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valor1txt);
            this.Name = "FuncionesProcedimientos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor1txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Valor2txt;
        private System.Windows.Forms.Button Ejecutarbutton1;
        private System.Windows.Forms.Button Restarbutton2;
    }
}

