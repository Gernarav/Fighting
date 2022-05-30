﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Selection_form : Form
    {
        public static string selectedMap;
        public Selection_form()
        {
            InitializeComponent();
            KeyPreview = true;

            timer1.Interval = 50;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();

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

        public void Update(object sender, EventArgs e)
        {
            Invalidate();
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

        private void SelectionOnPaint(object sender, PaintEventArgs e)
        {
            View.SelectionOnPaint(sender, e);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            openForm1();
        }

        private void Select_Skycraper_map_Click(object sender, EventArgs e)
        {
            selectedMap = "Skycraper_map";

        }

        private void Select_Portal_map_Click(object sender, EventArgs e)
        {
            selectedMap = "Portal_map";
        }

        private void Select_Bridge_map_Click(object sender, EventArgs e)
        {
            selectedMap = "Bridge_map";
        }
    }
}