namespace Ejercicio_3_Tarea_Gerardo_López
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Calcularbutton1 = new System.Windows.Forms.Button();
            this.Antiguedadtxt = new System.Windows.Forms.TextBox();
            this.AumentoSalariotxt = new System.Windows.Forms.TextBox();
            this.NuevoSalariotxt = new System.Windows.Forms.TextBox();
            this.PromedioVentastxt = new System.Windows.Forms.TextBox();
            this.SalarioActualtxt = new System.Windows.Forms.TextBox();
            this.Edadtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona tu fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salario Actual :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese el promedio de ventas :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Años de antiguedad en la empresa :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Aumento de salario :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nuevo salario :";
            // 
            // Calcularbutton1
            // 
            this.Calcularbutton1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton1.Location = new System.Drawing.Point(130, 377);
            this.Calcularbutton1.Name = "Calcularbutton1";
            this.Calcularbutton1.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton1.TabIndex = 8;
            this.Calcularbutton1.Text = "CALCULAR";
            this.Calcularbutton1.UseVisualStyleBackColor = true;
            this.Calcularbutton1.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // Antiguedadtxt
            // 
            this.Antiguedadtxt.Location = new System.Drawing.Point(238, 234);
            this.Antiguedadtxt.Name = "Antiguedadtxt";
            this.Antiguedadtxt.Size = new System.Drawing.Size(100, 20);
            this.Antiguedadtxt.TabIndex = 9;
            this.Antiguedadtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Antiguedadtxt_KeyPress);
            // 
            // AumentoSalariotxt
            // 
            this.AumentoSalariotxt.Location = new System.Drawing.Point(238, 286);
            this.AumentoSalariotxt.Name = "AumentoSalariotxt";
            this.AumentoSalariotxt.Size = new System.Drawing.Size(100, 20);
            this.AumentoSalariotxt.TabIndex = 10;
            // 
            // NuevoSalariotxt
            // 
            this.NuevoSalariotxt.Location = new System.Drawing.Point(238, 336);
            this.NuevoSalariotxt.Name = "NuevoSalariotxt";
            this.NuevoSalariotxt.Size = new System.Drawing.Size(100, 20);
            this.NuevoSalariotxt.TabIndex = 11;
            // 
            // PromedioVentastxt
            // 
            this.PromedioVentastxt.Location = new System.Drawing.Point(238, 184);
            this.PromedioVentastxt.Name = "PromedioVentastxt";
            this.PromedioVentastxt.Size = new System.Drawing.Size(100, 20);
            this.PromedioVentastxt.TabIndex = 12;
            this.PromedioVentastxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PromedioVentastxt_KeyPress);
            // 
            // SalarioActualtxt
            // 
            this.SalarioActualtxt.Location = new System.Drawing.Point(238, 139);
            this.SalarioActualtxt.Name = "SalarioActualtxt";
            this.SalarioActualtxt.Size = new System.Drawing.Size(100, 20);
            this.SalarioActualtxt.TabIndex = 13;
            this.SalarioActualtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalarioActualtxt_KeyPress);
            // 
            // Edadtxt
            // 
            this.Edadtxt.Location = new System.Drawing.Point(238, 95);
            this.Edadtxt.Name = "Edadtxt";
            this.Edadtxt.Size = new System.Drawing.Size(100, 20);
            this.Edadtxt.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 418);
            this.Controls.Add(this.Edadtxt);
            this.Controls.Add(this.SalarioActualtxt);
            this.Controls.Add(this.PromedioVentastxt);
            this.Controls.Add(this.NuevoSalariotxt);
            this.Controls.Add(this.AumentoSalariotxt);
            this.Controls.Add(this.Antiguedadtxt);
            this.Controls.Add(this.Calcularbutton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Calcularbutton1;
        private System.Windows.Forms.TextBox Antiguedadtxt;
        private System.Windows.Forms.TextBox AumentoSalariotxt;
        private System.Windows.Forms.TextBox NuevoSalariotxt;
        private System.Windows.Forms.TextBox PromedioVentastxt;
        private System.Windows.Forms.TextBox SalarioActualtxt;
        private System.Windows.Forms.TextBox Edadtxt;
    }
}

