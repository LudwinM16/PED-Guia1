using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Snake : Form
    {
        List<PictureBox> Lista = new List<PictureBox>();//contendrá el cuerpo de la serpiente
        int TamanioPiezaPrincipal = 26, tiempo = 10; 
        PictureBox Comida = new PictureBox();//IMG donde aparecera el raton  
        String direccion = "right";

        public Snake()
        {
            InitializeComponent();
            iniciarJuego();//Meto de Inicial Juego
                
        }
        public void iniciarJuego() //Creando metodo para  Inicar el Juego
        {
            tiempo = 10; //Inicializamos tiempo 
            direccion = "right";//Inicializamos direccion hacia donde empesaria a moverse
            timer1.Interval = 200;
            Lista = new List<PictureBox>();
            for (int i = 2; 0 <= i; i--)
            {
                crearSerpiente(Lista, this, (i * TamanioPiezaPrincipal) + 70, 80);
            }
            CrearComida();
        } 
        //Metodo para la creacion de la serpiente 
        public void crearSerpiente(List<PictureBox> ListaPelota, Form formulario, int posicionX, int posicionY)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(posicionX, posicionY);//Posicion donde empezará al iniciar el programa
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Cuerpo");//busca la imagen del cuerpo de la serpiente dentro de resources
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaPelota.Add(pb);
            formulario.Controls.Add(pb); 
        }
        private void CrearComida()
        {
            Random rnd = new Random();
            int enteroX = rnd.Next(1, this.Width - TamanioPiezaPrincipal - 10);
            int enteroY = rnd.Next(1, this.Height - TamanioPiezaPrincipal - 40);

            PictureBox pb = new PictureBox();
            pb.Location = new Point(enteroX, enteroY);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("comida");
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            Comida = pb;
            this.Controls.Add(pb);
        }
        private void Snake_KeyDown(object sender, KeyEventArgs e) //detecta la pulsacio de teclas para el cambio de direccion
        {
            direccion = ((e.KeyCode & Keys.Up) == Keys.Up) ? "up" : direccion;
            direccion = ((e.KeyCode & Keys.Down) == Keys.Down) ? "down" : direccion;
            direccion = ((e.KeyCode & Keys.Left) == Keys.Left) ? "left" : direccion;
            direccion = ((e.KeyCode & Keys.Right) == Keys.Right) ? "right" : direccion;
        }

        public void reiniciarJuego() 
        { 
            foreach (PictureBox Serpiente in Lista) { this.Controls.Remove(Serpiente); }
            this.Controls.Remove(Comida);
            iniciarJuego();//Iniciamos de nuevo
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nx = Lista[0].Location.X;
            int ny = Lista[0].Location.Y;
            Lista[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Cabeza" + direccion);

            for (int i = Lista.Count-1;i>=0;i--)
            {
                if (i == 0)  // se evalua si la pieza es la img de cabeza
                {
                    if (direccion == "right") nx = nx + TamanioPiezaPrincipal;
                    else if (direccion == "left") nx = nx - TamanioPiezaPrincipal;
                    else if (direccion == "up") ny = ny - TamanioPiezaPrincipal;
                    else if (direccion == "down") ny = ny + TamanioPiezaPrincipal;

                    Lista[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Cabeza" + direccion);
                    Lista[0].Location = new Point(nx, ny);
                }
                else 
                {
                    
                    Lista[i].Location = new Point((Lista[i - 1].Location.X), (Lista[i].Location.Y));
                    Lista[i].Location = new Point((Lista[i].Location.X), (Lista[i - 1].Location.Y));
                }
            }

            //Detectamos colisiones con el raton
            for (int contarPiezas=1; contarPiezas<Lista.Count; contarPiezas++) 
                {
                    if(Lista[contarPiezas].Bounds.IntersectsWith(Comida.Bounds)) //verifica si la serpiente toca el raton
                    {
                        this.Controls.Remove(Comida);
                        tiempo = Convert.ToInt32(timer1.Interval);
                        if (tiempo > 10) { timer1.Interval = tiempo - 10; }//disminuimos el tiempo, haciendo mas rapida a la serpiente
                        lblPuntos.Text=(Convert.ToInt32(lblPuntos.Text) + 1).ToString();// aumentamos el puntaje
                        CrearComida(); //creamos una nueva IMG de raton
                        crearSerpiente(Lista, this, Lista[Lista.Count - 1].Location.X * TamanioPiezaPrincipal, 0);//añanadimos una nueva parte al cuerpo de la serpiente

                    }
                
                }

            //se usa para saber si la serpiente ha salido de los limites y reiniciar el juego
            if ((Lista[0].Location.X>= this.Width-15) || (Lista[0].Location.Y>= this.Height-50) || (Lista[0].Location.Y < -10) || (Lista[0].Location.X < -30))
            {
     
                reiniciarJuego();
            }

            //Dtectamos Colision   entre el cuerpo del gusano 
            for (int conteoPiezas =1;  conteoPiezas < Lista.Count; conteoPiezas++) 
            {
              if (Lista[0].Bounds.IntersectsWith(Lista[conteoPiezas].Bounds)) {
                    reiniciarJuego(); 
                }
            }
        }
    }
}
