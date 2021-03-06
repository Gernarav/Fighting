using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Fighting
{
    public partial class Play_form : Form
    {
        public static bool roundIsOver;
        public static Entity winner;
        public static string winnerName;
        public static Entity player1;
        public static Entity player2;
        public static Bitmap hero1;
        public static Bitmap hero2;
        public static Image map;
        public Play_form(Bitmap player1Skin, Bitmap player2Skin, Image selectedMap)
        {
            InitializeComponent();

            KeyPreview = true;

            SetSkins(player1Skin, player2Skin);
            SetMap(selectedMap);

            roundIsOver = false;
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();

            CreatePlayers();

            KeyDown += new KeyEventHandler(OnPress);

            Invalidate();
        }

        public void SetMap(Image selectedMap)
        {
            map = selectedMap;
            this.BackgroundImage = map;
        }

        public void SetSkins(Bitmap player1Skin, Bitmap player2Skin)
        {
            hero1 = player1Skin;
            hero2 = player2Skin;
        }

        public void CreatePlayers()
        {
            player1 = new Entity
                (30, 300, 1, 
                hero1,
                player1_hurtBox,
                player1_hitBox);

            player2 = new Entity
                (730, 300, 2,
                hero2,
                player2_hurtBox,
                player2_hitBox);
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            if(!roundIsOver)
            {
                if (!player1.isMoving)
                    switch (e.KeyCode)
                    {
                        case Keys.D:
                            SetMove(player1, 30, 1);
                            player1.dirX = 30;
                            player1.isMoving = true;
                            player1.SetAnimation(1);
                            break;
                        case Keys.A:
                            SetMove(player1, -30, 2);
                            break;
                        case Keys.F:
                            SetMove(player1, 20, 3);
                            break;
                        case Keys.Escape:
                            openForm1();
                            break;
                    }

                if (!player2.isMoving)
                    switch (e.KeyCode)
                    {
                        case Keys.L:
                            SetMove(player2, 30, 1);
                            break;
                        case Keys.J:
                            SetMove(player2, -30, 2);
                            break;
                        case Keys.I:
                            SetMove(player2, -20, 3);
                            break;
                    }
            }
            
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    openForm1();
                    break;
                case Keys.Space:
                    break;
            }
        }

        public void Update(object sender, EventArgs e)
        {
            if(!roundIsOver)
            {
                WinnerStatus();

                if (player1.isMoving)
                    MakeMove(player1);

                if (player2.isMoving)
                    MakeMove(player2);
                Invalidate();
                return;
            }


            timer1.Stop();
            timer1.Dispose();
            Thread.Sleep(500);

            DialogResult gameOver = MessageBox.Show(
                "Play again?", winnerName + " won!",
                MessageBoxButtons.YesNo);

            switch (gameOver)
            {
                case DialogResult.Yes:
                    this.Hide();
                    Play_form formToSwitch = new Play_form(hero1, hero2, map);
                    formToSwitch.ShowDialog();
                    this.Close();
                    break;
                case DialogResult.No:
                    openForm1();
                    break;
            }
        }

        public void SetMove(Entity player, int dirX, int SetAnimation)
        {
            if (SetAnimation == 3)
                player.isAttacking = true;
            player.isMoving = true;
            player.dirX = dirX;
            player.SetAnimation(SetAnimation);
        }

        public bool InBorders(Entity player)
        {
            switch(player.side)
            {
                case 1:
                    if (player1.posX + player1.dirX > 0 && player1.hurtBox.Right + player1.dirX + 50 < player2.hurtBox.Left)
                        return true;
                    return false;
                case 2:
                    if (player2.hurtBox.Left + player2.dirX - 50 > player1_hurtBox.Right && player2.hurtBox.Right + player2.dirX + 50 < ClientSize.Width)
                        return true;
                    return false;
            }
            return false;
        }

        public void MakeMove(Entity player)
        {
            if (InBorders(player))
            {
                player.posX += player.dirX;
                player.hurtBox.Left += player.dirX;
                player.hitBox.Left += player.dirX;
            }
        }

        public void WinnerStatus()
        {
            if (player1.isAttacking && player1_hitBox.Right >= player2_hurtBox.Left)
            {
                RoundOver(player1);
            }


            if (player2.isAttacking &&  player2_hitBox.Left <= player1_hurtBox.Right)
            {
                RoundOver(player2);
            }

        }

        public void RoundOver(Entity player)
        {
            roundIsOver = true;
            winner = player;
            switch(player.side)
            {
                case 1:
                    winnerName = "Player1";
                    break;
                case 2:
                    winnerName = "Player2";
                    break;
            }
        }

        public void openForm1()
        {
            this.Hide();
            Main_menu_form formToSwitch = new Main_menu_form();
            formToSwitch.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openForm1();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            View.PlayOnPaint(sender, e);
        }
    }
}
