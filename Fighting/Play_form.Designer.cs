
using System.Windows.Forms;

namespace Fighting
{
    partial class Play_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.player1_hurtBox = new System.Windows.Forms.PictureBox();
            this.player1_hitBox = new System.Windows.Forms.PictureBox();
            this.player2_hurtBox = new System.Windows.Forms.PictureBox();
            this.player2_hitBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player1_hurtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_hitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_hurtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_hitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(29, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(99, 101);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // player1_hurtBox
            // 
            this.player1_hurtBox.BackColor = System.Drawing.Color.Transparent;
            this.player1_hurtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_hurtBox.Location = new System.Drawing.Point(526, 624);
            this.player1_hurtBox.Name = "player1_hurtBox";
            this.player1_hurtBox.Size = new System.Drawing.Size(150, 363);
            this.player1_hurtBox.TabIndex = 6;
            this.player1_hurtBox.TabStop = false;
            this.player1_hurtBox.Visible = false;
            // 
            // player1_hitBox
            // 
            this.player1_hitBox.BackColor = System.Drawing.Color.Transparent;
            this.player1_hitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_hitBox.Location = new System.Drawing.Point(726, 763);
            this.player1_hitBox.Name = "player1_hitBox";
            this.player1_hitBox.Size = new System.Drawing.Size(253, 35);
            this.player1_hitBox.TabIndex = 7;
            this.player1_hitBox.TabStop = false;
            this.player1_hitBox.Visible = false;
            // 
            // player2_hurtBox
            // 
            this.player2_hurtBox.BackColor = System.Drawing.Color.Transparent;
            this.player2_hurtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_hurtBox.Location = new System.Drawing.Point(1282, 624);
            this.player2_hurtBox.Name = "player2_hurtBox";
            this.player2_hurtBox.Size = new System.Drawing.Size(150, 363);
            this.player2_hurtBox.TabIndex = 8;
            this.player2_hurtBox.TabStop = false;
            this.player2_hurtBox.Visible = false;
            // 
            // player2_hitBox
            // 
            this.player2_hitBox.BackColor = System.Drawing.Color.Transparent;
            this.player2_hitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_hitBox.Location = new System.Drawing.Point(1067, 729);
            this.player2_hitBox.Name = "player2_hitBox";
            this.player2_hitBox.Size = new System.Drawing.Size(253, 35);
            this.player2_hitBox.TabIndex = 9;
            this.player2_hitBox.TabStop = false;
            this.player2_hitBox.Visible = false;
            // 
            // Play_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 739);
            this.Controls.Add(this.player2_hitBox);
            this.Controls.Add(this.player2_hurtBox);
            this.Controls.Add(this.player1_hitBox);
            this.Controls.Add(this.player1_hurtBox);
            this.Controls.Add(this.btnHome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Play_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play_form";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            ((System.ComponentModel.ISupportInitialize)(this.player1_hurtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_hitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_hurtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_hitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Timer timer1;
        private Button btnHome;
        public PictureBox player1_hurtBox;
        public PictureBox player1_hitBox;
        public PictureBox player2_hurtBox;
        public PictureBox player2_hitBox;
    }
}