using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace FirstGame
{
    public partial class FirstGame : Form
    {
        public FirstGame()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            SoundPlayer player = new SoundPlayer(Properties.Resources.dingSound);
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.cheeringSound);
            player.Play();

            goButton.Visible = false;
            light1Label.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            light2Label.Visible = true;
            player.Play();

            Refresh();
            Thread.Sleep(1000);
            player.Play();

            light3Label.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            player.Play();

            light1Label.Visible = false;
            light2Label.Visible = false;
            light3Label.Visible = false;

            goLabel.Visible = true; 
            this.BackColor = Color.Lime;
            player1.Play();

            while (true)
            {
                for (int i = 0; i <= 500; i = i +5)
                {
                    Refresh();
                    Thread.Sleep(10);
                    goLabel.Location = new Point(i, i);
                }
                for (int i = 0; i <= 500; i = i +5)
                {
                    Refresh();
                    Thread.Sleep(10);
                    goLabel.Location = new Point(-i +500, i);
                }
                for (int i = 0; i <= 500; i = i +5)
                {
                    Refresh();
                    Thread.Sleep(10);
                    goLabel.Location = new Point(i, -i+500);
                }
                for (int i = 0; i <= 500; i = i +5)
                {
                    Refresh();
                    Thread.Sleep(10);
                    goLabel.Location = new Point(-i + 500, -i + 500);
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
