namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseCLick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
        }

        private void paint1_MouseClick(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();//para "dibujar" y "rellenar" la figura
            Pen lapiz = new Pen(Color.Black);//para el contorno de la figura

            //generamos el color al azar
            List<Color> colores = new List<Color> { Color.Green, Color.Blue, Color.Red, Color.Beige, Color.DarkBlue, Color.DeepPink, Color.Indigo, Color.LemonChiffon, Color.Lavender, Color.Aquamarine, Color.Magenta};
            Random colorRnd = new Random();
            int iColor = colorRnd.Next(0, colores.Count);
            Color colorRandom = colores[iColor];

            //randomizamos el tamaño del objeto
            int dimensionRnd = colorRnd.Next(10, 400);

            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(colorRandom);
                g.DrawEllipse(lapiz, x - 50, y - 50, dimensionRnd, dimensionRnd);
                g.FillEllipse(sb, x - 50, y - 50, dimensionRnd, dimensionRnd);

            }
            if(listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(colorRandom);
                g.DrawRectangle(lapiz, x - 50, y - 50, dimensionRnd, dimensionRnd);
                g.FillRectangle(sb, x - 50, y - 50, dimensionRnd, dimensionRnd);
            }
        }
    }
}
