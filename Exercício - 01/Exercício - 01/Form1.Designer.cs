namespace Exercício___01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Numero = new System.Windows.Forms.TextBox();
            this.Recursiva = new System.Windows.Forms.Button();
            this.Interativa = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero
            // 
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(12, 12);
            this.Numero.MaxLength = 4;
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(286, 38);
            this.Numero.TabIndex = 0;
            this.Numero.TextChanged += new System.EventHandler(this.Valor);
            this.Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Aprovador);
            // 
            // Recursiva
            // 
            this.Recursiva.Location = new System.Drawing.Point(192, 56);
            this.Recursiva.Name = "Recursiva";
            this.Recursiva.Size = new System.Drawing.Size(106, 39);
            this.Recursiva.TabIndex = 2;
            this.Recursiva.Text = "Recursiva";
            this.Recursiva.UseVisualStyleBackColor = true;
            this.Recursiva.Click += new System.EventHandler(this.Recursive);
            // 
            // Interativa
            // 
            this.Interativa.Location = new System.Drawing.Point(12, 56);
            this.Interativa.Name = "Interativa";
            this.Interativa.Size = new System.Drawing.Size(106, 39);
            this.Interativa.TabIndex = 3;
            this.Interativa.Text = "Interativa";
            this.Interativa.UseVisualStyleBackColor = true;
            this.Interativa.Click += new System.EventHandler(this.Interactive);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(12, 162);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(29, 31);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 261);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Interativa);
            this.Controls.Add(this.Recursiva);
            this.Controls.Add(this.Numero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.Button Recursiva;
        private System.Windows.Forms.Button Interativa;
        private System.Windows.Forms.Label Resultado;
    }
}

