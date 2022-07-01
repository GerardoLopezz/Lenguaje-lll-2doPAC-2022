namespace Ejercicio_asincronica_Clase_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero2txt = new System.Windows.Forms.TextBox();
            this.Sumarbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Numero1txt
            // 
            this.Numero1txt.Location = new System.Drawing.Point(221, 195);
            this.Numero1txt.Name = "Numero1txt";
            this.Numero1txt.Size = new System.Drawing.Size(164, 20);
            this.Numero1txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero 2";
            // 
            // Numero2txt
            // 
            this.Numero2txt.Location = new System.Drawing.Point(221, 243);
            this.Numero2txt.Name = "Numero2txt";
            this.Numero2txt.Size = new System.Drawing.Size(164, 20);
            this.Numero2txt.TabIndex = 4;
            // 
            // Sumarbutton2
            // 
            this.Sumarbutton2.Location = new System.Drawing.Point(419, 213);
            this.Sumarbutton2.Name = "Sumarbutton2";
            this.Sumarbutton2.Size = new System.Drawing.Size(90, 34);
            this.Sumarbutton2.TabIndex = 6;
            this.Sumarbutton2.Text = "Sumar";
            this.Sumarbutton2.UseVisualStyleBackColor = true;
            this.Sumarbutton2.Click += new System.EventHandler(this.Sumarbutton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 372);
            this.Controls.Add(this.Sumarbutton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Numero2txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero1txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Numero2txt;
        private System.Windows.Forms.Button Sumarbutton2;
    }
}

