namespace Ejercicio_2_Tarea_2_Gerardo_Lopez
{
    partial class Funcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.numerotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculartxt = new System.Windows.Forms.TextBox();
            this.Calcularbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAR O IMPAR";
            // 
            // numerotxt
            // 
            this.numerotxt.Location = new System.Drawing.Point(157, 64);
            this.numerotxt.Name = "numerotxt";
            this.numerotxt.Size = new System.Drawing.Size(100, 20);
            this.numerotxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese un numero";
            // 
            // Calculartxt
            // 
            this.Calculartxt.Location = new System.Drawing.Point(98, 119);
            this.Calculartxt.Name = "Calculartxt";
            this.Calculartxt.Size = new System.Drawing.Size(100, 20);
            this.Calculartxt.TabIndex = 3;
            // 
            // Calcularbutton1
            // 
            this.Calcularbutton1.Location = new System.Drawing.Point(109, 176);
            this.Calcularbutton1.Name = "Calcularbutton1";
            this.Calcularbutton1.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton1.TabIndex = 5;
            this.Calcularbutton1.Text = "CALCULAR";
            this.Calcularbutton1.UseVisualStyleBackColor = true;
            this.Calcularbutton1.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // Funcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 252);
            this.Controls.Add(this.Calcularbutton1);
            this.Controls.Add(this.Calculartxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numerotxt);
            this.Controls.Add(this.label1);
            this.Name = "Funcion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numerotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Calculartxt;
        private System.Windows.Forms.Button Calcularbutton1;
    }
}

