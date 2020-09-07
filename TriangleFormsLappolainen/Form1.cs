using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TriangleFormsLappolainen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double a, b, c, h;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            //h = Convert.ToDouble(txtH.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона A");
            listView1.Items.Add("Сторона B");
            listView1.Items.Add("Сторона C");
            listView1.Items.Add("Высота A");
            listView1.Items.Add("Высота B");
            listView1.Items.Add("Высота C");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.OutputA());
            listView1.Items[1].SubItems.Add(triangle.OutputB());
            listView1.Items[2].SubItems.Add(triangle.OutputC());
            //listView1.Items[3].SubItems.Add(Convert.ToString(Math.Round(triangle.Height(), 2)));
            listView1.Items[3].SubItems.Add(Convert.ToString(Math.Round(triangle.hA(),2)));
            listView1.Items[4].SubItems.Add(Convert.ToString(Math.Round(triangle.hB(),2)));
            listView1.Items[5].SubItems.Add(Convert.ToString(Math.Round(triangle.hC(),2)));
            listView1.Items[6].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[7].SubItems.Add(Convert.ToString(Math.Round(triangle.Surface(), 2)));
            if (triangle.ExistTriangle) { listView1.Items[8].SubItems.Add("Существует"); }
            else listView1.Items[8].SubItems.Add("Не существует");
            listView1.Items[9].SubItems.Add(triangle.TriangleType());
            pictureTriangle.Image = Image.FromFile(triangle.ImageSource());
            
        
        

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
