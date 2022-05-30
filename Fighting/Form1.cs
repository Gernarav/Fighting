using System;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

            timer1.Interval = 50;
            timer1.Start();

            //View.StartPlay();

            KeyDown += new KeyEventHandler(OnPress);
            Invalidate();
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play_form formToSwitch = new Play_form();
            formToSwitch.ShowDialog();
            this.Close();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutorial_form formToSwitch = new Tutorial_form();
            formToSwitch.ShowDialog();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings_form formToSwitch = new Settings_form();
            formToSwitch.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
