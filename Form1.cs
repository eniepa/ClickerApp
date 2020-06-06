using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerApp
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int fontSize = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            FirstButton.BackColor = Color.Pink;
            FirstButton.Width -= 5;
            FirstButton.Height -= 5;
            FirstButton.Top = rand.Next(0, 300);
            FirstButton.Left = rand.Next(0, 300);
            int red = rand.Next(0, 256);
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);
            FirstButton.BackColor = Color.FromArgb(red, green, blue);
            FirstButton.Font = new Font("Arial", fontSize, FontStyle.Bold);
            fontSize -= 1;
            if (fontSize != 1)
            {
                fontSize -= 1;
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.Top = rand.Next(0, 300);
            CloseButton.Left = rand.Next(0, 300);

        }

        private void FirstButton_MouseEnter(object sender, EventArgs e)
        {
            FirstButton.Top = rand.Next(0, 300);
            FirstButton.Left = rand.Next(0, 300);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
