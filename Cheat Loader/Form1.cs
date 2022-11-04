using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat_Loader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {
            // make a event here
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://skinchanger-csgo.com/"); // SITE OF YOUR PRODUCT
        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://inventorychanger.ru/"); // SITE OF YOUR PRODUCT
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://zeer-gaming.ru/"); // SITE OF YOUR PRODUCT
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            // make a event here
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // loading form here
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/csgo_skinchanger"); // GROUP OF YOUR PRODUCT
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            // if you wont close steam ->

            
            foreach (var process in Process.GetProcessesByName("steam"))
            {
                process.Kill();

            }


            // opening the loading screen and hide the menu screen
            Form2 main = new Form2();
            this.Hide();
            main.Show();
        }
    }
}
