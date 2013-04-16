namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(75, 33);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(195, 20);
            this.numero1.TabIndex = 1;
            this.numero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2";
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(75, 74);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(194, 20);
            this.numero2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(75, 123);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(194, 20);
            this.resultado.TabIndex = 5;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(19, 210);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(93, 34);
            this.suma.TabIndex = 6;
            this.suma.Text = "Suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(118, 211);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(93, 34);
            this.resta.TabIndex = 7;
            this.resta.Text = "Resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(217, 212);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(93, 34);
            this.multiplicacion.TabIndex = 8;
            this.multiplicacion.Text = "Multiplicacion";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.button3_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(318, 212);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(93, 34);
            this.division.TabIndex = 9;
            this.division.Text = "Division";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.button4_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 266);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.label1);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button division;
    }
}

