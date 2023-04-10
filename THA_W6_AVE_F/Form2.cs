using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_AVE_F
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int i { get; set; }
        public List<Button> buttons = new List<Button>();

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int a = 1; a <= i; a++) 
            {
                for (int b = 1; b <= i; b++)
                {
                    Button btnword = new Button();
                    btnword.Text = "";
                    btnword.Location = new Point(20 + (a*40),20+(b*40));
                    btnword.Size = new Size(40,40);
                    btnword.Click += new EventHandler(Btnword_Click);
                    btnword.Tag = a+","+b;
                    this.Controls.Add(btnword);
                    buttons.Add(btnword);
                }
            }
        }

        private void Btnword_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
        }
    }
}
