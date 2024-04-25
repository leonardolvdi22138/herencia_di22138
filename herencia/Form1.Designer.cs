namespace herencia
{
    partial class calculadora
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
            this.valor1 = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1.ForeColor = System.Drawing.Color.Red;
            this.valor1.Location = new System.Drawing.Point(76, 55);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(76, 18);
            this.valor1.TabIndex = 0;
            this.valor1.Text = "VALOR 1";
            // 
            // valor2
            // 
            this.valor2.AutoSize = true;
            this.valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2.ForeColor = System.Drawing.Color.Red;
            this.valor2.Location = new System.Drawing.Point(76, 93);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(76, 18);
            this.valor2.TabIndex = 1;
            this.valor2.Text = "VALOR 2";
            this.valor2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.Red;
            this.resultado.Location = new System.Drawing.Point(44, 137);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(108, 18);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "RESULTADO";
            this.resultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(26, 187);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(85, 23);
            this.suma.TabIndex = 3;
            this.suma.Text = "sumar";
            this.suma.UseVisualStyleBackColor = true;
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(26, 213);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(85, 23);
            this.resta.TabIndex = 4;
            this.resta.Text = "restar";
            this.resta.UseVisualStyleBackColor = true;
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(26, 242);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(85, 23);
            this.multiplicar.TabIndex = 5;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(26, 271);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(85, 23);
            this.dividir.TabIndex = 6;
            this.dividir.Text = "dividir";
            this.dividir.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(131, 187);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(85, 23);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(131, 216);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 23);
            this.salir.TabIndex = 8;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 365);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Name = "calculadora";
            this.Text = "calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.Label valor2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

