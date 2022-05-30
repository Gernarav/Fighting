
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
            this.Select_Portal_map.BackgroundImage = global::Fighting.Resource1.Map_Selected;
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
            this.Select_Bridge_map.BackgroundImage = global::Fighting.Resource1.Map_Selected;
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
            this.Select_Skycraper_map.BackgroundImage = global::Fighting.Resource1.Map_Selected;
            this.Select_Skycraper_map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Skycraper_map.Location = new System.Drawing.Point(76, 261);
            this.Select_Skycraper_map.Name = "Select_Skycraper_map";
            this.Select_Skycraper_map.Size = new System.Drawing.Size(470, 269);
            this.Select_Skycraper_map.TabIndex = 6;
            this.Select_Skycraper_map.UseVisualStyleBackColor = true;
            this.Select_Skycraper_map.Visible = false;
            this.Select_Skycraper_map.Click += new System.EventHandler(this.Select_Skycraper_map_Click);
            // 
            // Selection_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fighting.Resource1.Selection_form;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
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
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectionOnPaint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Select_Portal_map;
        private System.Windows.Forms.Button Select_Bridge_map;
        private System.Windows.Forms.Button Select_Skycraper_map;
    }
}