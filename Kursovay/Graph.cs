using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;


namespace Kursovay
{

    public partial class Graph : Form
    {
        public int PickCount=0;
        public Lable[] a = new Lable[2];
        public struct Lable
        {
            public int X, Y, Index;
            Lable(int x, int y, int i)
            {
                X= x; Y= y; Index= i; 
            }
        }
        Label label2 = new Label();
        public Graph()
        {
            InitializeComponent();
            this.Load += LoadEvent;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text = "Авторизация";
            Autorisation aut = new Autorisation();
            aut.Show(); this.Hide();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadEvent(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            // создаем эллипс с высотой и шириной формы
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            // создаем с помощью элипса ту область формы, которую мы хотим видеть
            Region myRegion = new Region(myPath);
            // устанавливаем видимую область

        }
        private void Graph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PickCount++;
                label2 = new Label()
                {
                    Text = "Point ",
                    Location = new Point(e.X, e.Y),
                    BackColor = Color.Aqua,
                    Size = new Size(40, 20),
                    TabIndex = PickCount
                };
                label2.MouseClick += label2_MouseClick;
                label2.Text += Convert.ToString(PickCount);
                Controls.Add(label2);
            }
        }
        private void Graph_Load_1(object sender, EventArgs e)
        {

        }
        public int b=0;

        

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            object o = sender;
            
            a[b].Y = Bounds.Y;
            if (b==1)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLine(new Pen(Color.Red), a[0].X, a[0].Y, a[1].X, a[1].Y);
            }
            b++;
            if (b == 2)
            {
                a[0].X = 0; a[0].Y = 0; a[1].X = 0; a[1].Y = 0; b = 0;
            }
        }

        
    }
}
