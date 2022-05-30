
namespace Fighting
{
    partial class Selection_form
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
            this.btnHome = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Select_Portal_map = new System.Windows.Forms.Button();
            this.Select_Bridge_map = new System.Windows.Forms.Button();
            this.Select_Skycraper_map = new System.Windows.Forms.Button();
            this.Skycraper_Selected = new System.Windows.Forms.PictureBox();
            this.Portal_Selected = new System.Windows.Forms.PictureBox();
            this.Bridge_Selected = new System.Windows.Forms.PictureBox();
            this.randomBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Skycraper_Selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portal_Selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bridge_Selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(29, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(99, 101);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // Select_Portal_map
            // 
            this.Select_Portal_map.BackColor = System.Drawing.Color.Transparent;
            this.Select_Portal_map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Portal_map.Location = new System.Drawing.Point(724, 261);
            this.Select_Portal_map.Name = "Select_Portal_map";
            this.Select_Portal_map.Size = new System.Drawing.Size(470, 269);
            this.Select_Portal_map.TabIndex = 7;
            this.Select_Portal_map.UseVisualStyleBackColor = true;
            this.Select_Portal_map.Click += new System.EventHandler(this.Select_Portal_map_Click);
            // 
            // Select_Bridge_map
            // 
            this.Select_Bridge_map.BackColor = System.Drawing.Color.Transparent;
            this.Select_Bridge_map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Bridge_map.Location = new System.Drawing.Point(1373, 261);
            this.Select_Bridge_map.Name = "Select_Bridge_map";
            this.Select_Bridge_map.Size = new System.Drawing.Size(470, 269);
            this.Select_Bridge_map.TabIndex = 8;
            this.Select_Bridge_map.UseVisualStyleBackColor = true;
            this.Select_Bridge_map.Click += new System.EventHandler(this.Select_Bridge_map_Click);
            // 
            // Select_Skycraper_map
            // 
            this.Select_Skycraper_map.BackColor = System.Drawing.Color.Transparent;
            this.Select_Skycraper_map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Skycraper_map.Location = new System.Drawing.Point(76, 261);
            this.Select_Skycraper_map.Name = "Select_Skycraper_map";
            this.Select_Skycraper_map.Size = new System.Drawing.Size(470, 269);
            this.Select_Skycraper_map.TabIndex = 6;
            this.Select_Skycraper_map.UseVisualStyleBackColor = true;
            this.Select_Skycraper_map.Click += new System.EventHandler(this.Select_Skycraper_map_Click);
            // 
            // Skycraper_Selected
            // 
            this.Skycraper_Selected.BackColor = System.Drawing.Color.Transparent;
            this.Skycraper_Selected.BackgroundImage = global::Fighting.Resource1.Map_Selected;
            this.Skycraper_Selected.Location = new System.Drawing.Point(76, 261);
            this.Skycraper_Selected.Name = "Skycraper_Selected";
            this.Skycraper_Selected.Size = new System.Drawing.Size(470, 269);
            this.Skycraper_Selected.TabIndex = 9;
            this.Skycraper_Selected.TabStop = false;
            this.Skycraper_Selected.Visible = false;
            // 
            // Portal_Selected
            // 
            this.Portal_Selected.BackColor = System.Drawing.Color.Transparent;
            this.Portal_Selected.BackgroundImage = global::Fighting.Resource1.Map_Selected;
            this.Portal_Selected.Location = new System.Drawing.Point(724, 261);
            this.Portal_Selected.Name = "Portal_Selected";
            this.Portal_Selected.Size = new System.Drawing.Size(470, 269);
            this.Portal_Selected.TabIndex = 10;
            this.Portal_Selected.TabStop = false;
            this.Portal_Selected.Visible = false;
            // 
            // Bridge_Selected
            // 
            this.Bridge_Selected.BackColor = System.Drawing.Color.Transparent;
            this.Bridge_Selected.BackgroundImage = global::Fighting.Resource1.Map_Selected;
            this.Bridge_Selected.Location = new System.Drawing.Point(1373, 261);
            this.Bridge_Selected.Name = "Bridge_Selected";
            this.Bridge_Selected.Size = new System.Drawing.Size(470, 269);
            this.Bridge_Selected.TabIndex = 11;
            this.Bridge_Selected.TabStop = false;
            this.Bridge_Selected.Visible = false;
            // 
            // randomBox
            // 
            this.randomBox.BackColor = System.Drawing.Color.Transparent;
            this.randomBox.Location = new System.Drawing.Point(3, 970);
            this.randomBox.Name = "randomBox";
            this.randomBox.Size = new System.Drawing.Size(125, 62);
            this.randomBox.TabIndex = 12;
            this.randomBox.TabStop = false;
            this.randomBox.Visible = false;
            // 
            // Selection_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fighting.Resource1.Selection_form;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.randomBox);
            this.Controls.Add(this.Bridge_Selected);
            this.Controls.Add(this.Portal_Selected);
            this.Controls.Add(this.Skycraper_Selected);
            this.Controls.Add(this.Select_Bridge_map);
            this.Controls.Add(this.Select_Portal_map);
            this.Controls.Add(this.Select_Skycraper_map);
            this.Controls.Add(this.btnHome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Selection_form";
            this.Text = "Selection";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Skycraper_Selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portal_Selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bridge_Selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Select_Portal_map;
        private System.Windows.Forms.Button Select_Bridge_map;
        private System.Windows.Forms.Button Select_Skycraper_map;
        private System.Windows.Forms.PictureBox Skycraper_Selected;
        private System.Windows.Forms.PictureBox Portal_Selected;
        private System.Windows.Forms.PictureBox Bridge_Selected;
        private System.Windows.Forms.PictureBox randomBox;
    }
}