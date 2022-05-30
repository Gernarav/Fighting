using System;
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
        public static string player1Skin = "Left_Blue_Sprites";
        public static string player2Skin = "Right_Red_Sprites";
        public static string selectedMap = "Skycraper_map";
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

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            openForm1();
        }

        private void Select_Skycraper_map_Click(object sender, EventArgs e)
        {
            selectedMap = "Skycraper_map";
            Skycraper_Selected.Visible = true;
            Portal_Selected.Visible = false;
            Bridge_Selected.Visible = false;
        }

        private void Select_Portal_map_Click(object sender, EventArgs e)
        {
            selectedMap = "Portal_map";
            Skycraper_Selected.Visible = false;
            Portal_Selected.Visible = true;
            Bridge_Selected.Visible = false;
        }

        private void Select_Bridge_map_Click(object sender, EventArgs e)
        {
            selectedMap = "Bridge_map";
            Skycraper_Selected.Visible = false;
            Portal_Selected.Visible = false;
            Bridge_Selected.Visible = true;
        }

        private void Left_Select_Blue_Click(object sender, EventArgs e)
        {
            player1Skin = "Left_Blue_Sprites";
            Selected_Left_Blue.Visible = true;
            Selected_Left_Red.Visible = false;
            Selected_Left_Green.Visible = false;
            Selected_Left_Yellow.Visible = false;
        }

        private void Left_Select_Red_Click(object sender, EventArgs e)
        {
            player1Skin = "Left_Red_Sprites";
            Selected_Left_Blue.Visible = false;
            Selected_Left_Red.Visible = true;
            Selected_Left_Green.Visible = false;
            Selected_Left_Yellow.Visible = false;
        }

        private void Left_Select_Green_Click(object sender, EventArgs e)
        {
            player1Skin = "Left_Green_Sprites";
            Selected_Left_Blue.Visible = false;
            Selected_Left_Red.Visible = false;
            Selected_Left_Green.Visible = true;
            Selected_Left_Yellow.Visible = false;
        }

        private void Left_Select_Yellow_Click(object sender, EventArgs e)
        {
            player1Skin = "Left_Yellow_Sprites";
            Selected_Left_Blue.Visible = false;
            Selected_Left_Red.Visible = false;
            Selected_Left_Green.Visible = false;
            Selected_Left_Yellow.Visible = true;
        }

        private void Right_Select_Blue_Click(object sender, EventArgs e)
        {
            player2Skin = "Right_Blue_Sprites";
            Selected_Right_Blue.Visible = true;
            Selected_Right_Red.Visible = false;
            Selected_Right_Green.Visible = false;
            Selected_Right_Yellow.Visible = false;
        }

        private void Right_Select_Red_Click(object sender, EventArgs e)
        {
            player2Skin = "Right_Red_Sprites";
            Selected_Right_Blue.Visible = false;
            Selected_Right_Red.Visible = true;
            Selected_Right_Green.Visible = false;
            Selected_Right_Yellow.Visible = false;
        }

        private void Right_Select_Green_Click(object sender, EventArgs e)
        {
            player2Skin = "Right_Green_Sprites";
            Selected_Right_Blue.Visible = false;
            Selected_Right_Red.Visible = false;
            Selected_Right_Green.Visible = true;
            Selected_Right_Yellow.Visible = false;
        }

        private void Right_Select_Yellow_Click(object sender, EventArgs e)
        {
            player2Skin = "Right_Yellow_Sprites";
            Selected_Right_Blue.Visible = false;
            Selected_Right_Red.Visible = false;
            Selected_Right_Green.Visible = false;
            Selected_Right_Yellow.Visible = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Bitmap hero1 = SelectSkin(player1Skin);
            Bitmap hero2 = SelectSkin(player2Skin);
            Image map = SelectMap();
            this.Hide();
            Play_form formToSwitch = new Play_form(hero1, hero2, map);
            formToSwitch.ShowDialog();
            this.Close();
        }

        public Image SelectMap()
        {
            switch(selectedMap)
            {
                case "Skycraper_map":
                    return Resource1.Skycraper_map;
                case "Portal_map":
                    return Resource1.Portal_map;
                case "Bridge_map":
                    return Resource1.Bridge_map;
            }
            return Resource1.Bridge_map;
        }

        public Bitmap SelectSkin(string skinName)
        {
            switch (skinName)
            {
                case "Left_Blue_Sprites":
                    return new Bitmap(Resource1.Left_Blue_Sprites);
                case "Left_Red_Sprites":
                    return new Bitmap(Resource1.Left_Red_Sprites);
                case "Left_Green_Sprites":
                    return new Bitmap(Resource1.Left_Green_Sprites);
                case "Left_Yellow_Sprites":
                    return new Bitmap(Resource1.Left_Yellow_Sprites);
                case "Right_Blue_Sprites":
                    return new Bitmap(Resource1.Right_Blue_Sprites);
                case "Right_Red_Sprites":
                    return new Bitmap(Resource1.Right_Red_Sprites);
                case "Right_Green_Sprites":
                    return new Bitmap(Resource1.Right_Green_Sprites);
                case "Right_Yellow_Sprites":
                    return new Bitmap(Resource1.Right_Yellow_Sprites);
            }
            return new Bitmap(Resource1.Left_Yellow_Sprites);
        }
    }
}
