using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Graphics area;
        int puntoinicio, puntofin;
        public Form1()
        {
            InitializeComponent();
            //declara el area donde apareceran las lineas a dibujar
            area = panelLineas.CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pincel = new Pen(Color.Black);

            switch (comboBoxColores.SelectedIndex)
            {
                case 0: pincel = new Pen(Color.Yellow); 
                    break;
                case 1: pincel = new Pen(Color.Red); 
                    break;
                case 2: pincel = new Pen(Color.Blue); 
                    break;
                case 3: pincel = new Pen(Color.Black); 
                    break;
                default:  
                    pincel = new Pen(Color.Lavender);
                    break;

            }

            if (String.IsNullOrEmpty(textBoxCantidad.Text) || String.IsNullOrEmpty(textBoxEspaciado.Text) || String.IsNullOrEmpty(textBoxInicio.Text) || String.IsNullOrEmpty(textBoxFinal.Text)) 
            {
                MessageBox.Show("Debe ingresar datos en los campos","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int dibujarLineas = int.Parse(textBoxCantidad.Text);//Lineas a dibujar
                int espaciado = int.Parse(textBoxEspaciado.Text);//Establece el espaciado entre cada linea
                puntoinicio = int.Parse(textBoxInicio.Text);//se establece Inicio
                puntofin = int.Parse(textBoxFinal.Text);//se establece Fin
                area.Clear(Color.White);

                
                for (int i = 0; i < dibujarLineas; i++)
                {                    
                    area.DrawLine(pincel, 20, puntoinicio + (espaciado * i), 300, puntofin + (espaciado * i));
                }
            }
        }
    }
}
