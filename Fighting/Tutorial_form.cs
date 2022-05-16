using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Tutorial_form : Form
    {
        public Tutorial_form()
        {
            InitializeComponent();
            KeyPreview = true;

            timer1.Interval = 100;
            timer1.Start();

            View.StartPlay();

            KeyDown += new KeyEventHandler(OnPress);
            Invalidate();
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    openForm1();
                    break;
            }
        }

        public void openForm1()
        {
            this.Hide();
            Form1 formToSwitch = new Form1();
            formToSwitch.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openForm1();
        }
    }
}
