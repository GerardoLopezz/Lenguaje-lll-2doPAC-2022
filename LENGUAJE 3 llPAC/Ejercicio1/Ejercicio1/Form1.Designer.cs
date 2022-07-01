namespace Ejercicio1
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
            this.Nota1txt = new System.Windows.Forms.TextBox();
            this.Nota2txt = new System.Windows.Forms.TextBox();
            this.Nota3txt = new System.Windows.Forms.TextBox();
            this.Nota4txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calcularbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nota1txt
            // 
            this.Nota1txt.Location = new System.Drawing.Point(156, 62);
            this.Nota1txt.Name = "Nota1txt";
            this.Nota1txt.Size = new System.Drawing.Size(116, 20);
            this.Nota1txt.TabIndex = 0;
            // 
            // Nota2txt
            // 
            this.Nota2txt.Location = new System.Drawing.Point(156, 107);
            this.Nota2txt.Name = "Nota2txt";
            this.Nota2txt.Size = new System.Drawing.Size(116, 20);
            this.Nota2txt.TabIndex = 1;
            // 
            // Nota3txt
            // 
            this.Nota3txt.Location = new System.Drawing.Point(156, 151);
            this.Nota3txt.Name = "Nota3txt";
            this.Nota3txt.Size = new System.Drawing.Size(116, 20);
            this.Nota3txt.TabIndex = 2;
            // 
            // Nota4txt
            // 
            this.Nota4txt.Location = new System.Drawing.Point(156, 194);
            this.Nota4txt.Name = "Nota4txt";
            this.Nota4txt.Size = new System.Drawing.Size(116, 20);
            this.Nota4txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "CALCULO PROMEDIO FINAL";
            // 
            // Calcularbutton1
            // 
            this.Calcularbutton1.Location = new System.Drawing.Point(131, 246);
            this.Calcularbutton1.Name = "Calcularbutton1";
            this.Calcularbutton1.Size = new System.Drawing.Size(118, 23);
            this.Calcularbutton1.TabIndex = 9;
            this.Calcularbutton1.Text = "Calcular";
            this.Calcularbutton1.UseVisualStyleBackColor = true;
            this.Calcularbutton1.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 312);
            this.Controls.Add(this.Calcularbutton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nota4txt);
            this.Controls.Add(this.Nota3txt);
            this.Controls.Add(this.Nota2txt);
            this.Controls.Add(this.Nota1txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nota1txt;
        private System.Windows.Forms.TextBox Nota2txt;
        private System.Windows.Forms.TextBox Nota3txt;
        private System.Windows.Forms.TextBox Nota4txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calcularbutton1;
    }
}

