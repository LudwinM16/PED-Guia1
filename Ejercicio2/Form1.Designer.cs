
namespace Ejercicio2
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
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEspaciado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxColores = new System.Windows.Forms.ComboBox();
            this.buttonDibujar = new System.Windows.Forms.Button();
            this.panelLineas = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(138, 23);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(121, 20);
            this.textBoxCantidad.TabIndex = 0;
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de \r\nlineas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Espaciado entre \r\nlineas:";
            // 
            // textBoxEspaciado
            // 
            this.textBoxEspaciado.Location = new System.Drawing.Point(138, 71);
            this.textBoxEspaciado.Name = "textBoxEspaciado";
            this.textBoxEspaciado.Size = new System.Drawing.Size(121, 20);
            this.textBoxEspaciado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color de las \r\nlineas:";
            // 
            // comboBoxColores
            // 
            this.comboBoxColores.FormattingEnabled = true;
            this.comboBoxColores.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Negro"});
            this.comboBoxColores.Location = new System.Drawing.Point(138, 119);
            this.comboBoxColores.Name = "comboBoxColores";
            this.comboBoxColores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColores.TabIndex = 5;
            // 
            // buttonDibujar
            // 
            this.buttonDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDibujar.Location = new System.Drawing.Point(60, 318);
            this.buttonDibujar.Name = "buttonDibujar";
            this.buttonDibujar.Size = new System.Drawing.Size(180, 33);
            this.buttonDibujar.TabIndex = 6;
            this.buttonDibujar.Text = "Dibujar Lineas";
            this.buttonDibujar.UseVisualStyleBackColor = true;
            this.buttonDibujar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLineas
            // 
            this.panelLineas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLineas.Location = new System.Drawing.Point(374, 29);
            this.panelLineas.Name = "panelLineas";
            this.panelLineas.Size = new System.Drawing.Size(697, 312);
            this.panelLineas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inicio lineas:";
            // 
            // textBoxInicio
            // 
            this.textBoxInicio.Location = new System.Drawing.Point(138, 168);
            this.textBoxInicio.Name = "textBoxInicio";
            this.textBoxInicio.Size = new System.Drawing.Size(121, 20);
            this.textBoxInicio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fin lineas:";
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(138, 214);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(121, 20);
            this.textBoxFinal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelLineas);
            this.Controls.Add(this.buttonDibujar);
            this.Controls.Add(this.comboBoxColores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEspaciado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCantidad);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEspaciado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxColores;
        private System.Windows.Forms.Button buttonDibujar;
        private System.Windows.Forms.Panel panelLineas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFinal;
    }
}

