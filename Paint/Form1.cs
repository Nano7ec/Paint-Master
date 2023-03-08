using System.Drawing.Imaging;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics papel;
        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int sx, sy, cx, cy;
        int id;
        int tamanioPincel = 3;
        bool moviendo = false;
        Pen pen;
        Point px,py;
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(picBoxPapel.Width, picBoxPapel.Height);
            //Asignamos nuestra propiedad graphics a nuestro pictureBox
            papel = picBoxPapel.CreateGraphics();
            picBoxPapel.BackColor = Color.White;
            //Para que los trazos sea mas suave
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //inicializamos nuestra variable con los valores del trackbar
            tamanioPincel = trackBarTamanioPincel.Value;
            //Inicializamos RGB con los valores de los textBox
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            //Inicializamos un pincel conlos colores y el tamano del pincel
            pen = new Pen(Color.FromArgb(R, G, B), tamanioPincel);
            //Los trazos inicien y terminen de forma ovalada
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            picBoxPapel.Image = bm;
            papel = Graphics.FromImage(bm);
            picBoxPapel.BackgroundImage = bm;
            picBoxPapel.BackgroundImageLayout = ImageLayout.None;
        }
        //evento que ocurre cuando le damos clic y sostenerlo sobre el picture box
        private void picBoxPapel_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true;
            py=e.Location;
            cx= e.X;
            cy= e.Y;
            //cambiamos cursosr por una cruz
            picBoxPapel.Cursor = Cursors.Cross;
        }
        //cuando estamos moviendo nuestro curzor sobre el picturebox
        private void picBoxPapel_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
            sx = x - cx;
            sy = y - cy;
            if (id == 2)
            {
                cambiarPincel(int.Parse(txtR.Text),int.Parse(txtG.Text),int.Parse(txtB.Text));
                papel.DrawLine(pen, cx,cy,x,y);
            }
            if(id == 3)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawEllipse(pen, cx,cy,sx,sy);
            }
            if (id == 4)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawRectangle(pen, cx,cy,sx,sy);
            }

        }
        //evento que ocurre al hacer clic al boton pintar 
        private void btnPincel_Click(object sender, EventArgs e)
        {
            id=0;
        }
        //evento que ocurre al hacer clic al boton borrar
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            id=1;
        }
        //es el evento cuando pasamos por encima del picture box
        private void picBoxPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo)
            {
                if (id==0)
                {
                    //cambiar de pincel
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                    //dibujar una linea 
                    px = e.Location;
                    papel.DrawLine(pen, px, py);
                    py = px;
                }
                if (id==1)
                {
                    cambiarPincel(255,255,255);
                    px = e.Location;
                    papel.DrawLine(pen,px, py);
                    py = px;
                }
                //refresh del pictorbox
                picBoxPapel.Refresh();
            }
            x = e.X;
            y=e.Y;
            sx=e.X-cx;
            sy=e.Y-cy;
        }
        //evento para cambiar de color el pincel
        private void cambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackBarTamanioPincel.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        //evento para cambiar de tamaño el pincel
        private void trackBarTamanioPincel_Scroll(object sender, EventArgs e)
        {
            lblTamanioPincel.Text = trackBarTamanioPincel.Value.ToString();
        }
        //es el box donde muestra los colores que coloquemos en el rgb
        private void picBoxColores_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
            }
        }
        //color dialogo mostrara el colordialogo
        private void picBoxNegro_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }
        //es el evento en el que guarde la imagen donde 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (guardar.ShowDialog() == DialogResult.OK)
            {

                Bitmap btm = bm.Clone(new Rectangle(0, 0, picBoxPapel.Width, picBoxPapel.Height), bm.PixelFormat);
                btm.Save(guardar.FileName, ImageFormat.Jpeg);
            }

        }
        //codigos de las figuras
        private void Line_Click(object sender, EventArgs e)
        {
            id=2;
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            id=3;
        }
        private void Cuadrado_Click(object sender, EventArgs e)
        {
            id=4;
        }
        //para pintar
        private void picBoxPapel_Paint(object sender, PaintEventArgs e)
        {
            Graphics papel = e.Graphics;
            if (moviendo)
            {
                if (id==2)
                {
                    papel.DrawLine(pen,cx,cy,x,y);
                    cambiarPincel(int.Parse(txtR.Text),int.Parse(txtG.Text),int.Parse(txtB.Text));
                }
                if(id==3)
                {
                    papel.DrawEllipse(pen, cx,cy,sx,sy);
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
                if(id==4)
                {
                    papel.DrawRectangle(pen, cx,cy,sx,sy);
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
            }
        }

        //codigo de los text box para que solo acepten numeros y no deje poner letras
        private void textBoxx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxy1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxy2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
    //pasar las figuras a este programa
    //*Plus dibujar figuras con dos puntos
    //*plus plus dibujar figuras en tiempo real
    //boton para guardar el dibujo

}