using System;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Form1 : Form
    {
        //Controller
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

            timer1.Interval = 100;
            timer1.Start();

            View.Start();

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

        //private void btnTutorial_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Play_form formToSwitch = new Tutorial_form();
        //    formToSwitch.ShowDialog();
        //    this.Close();
        //}

        //private void btnSettings_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Play_form formToSwitch = new Settings_form();
        //    formToSwitch.ShowDialog();
        //    this.Close();
        //}
    }
}
