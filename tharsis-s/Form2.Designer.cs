namespace tharsis_s
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gMap1 = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gMap2 = new GMap.NET.WindowsForms.GMapControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gMap1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(58, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 473);
            this.panel1.TabIndex = 0;
            // 
            // gMap1
            // 
            this.gMap1.Bearing = 0F;
            this.gMap1.CanDragMap = true;
            this.gMap1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap1.GrayScaleMode = false;
            this.gMap1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap1.LevelsKeepInMemory = 5;
            this.gMap1.Location = new System.Drawing.Point(48, 115);
            this.gMap1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gMap1.MarkersEnabled = true;
            this.gMap1.MaxZoom = 2;
            this.gMap1.MinZoom = 2;
            this.gMap1.MouseWheelZoomEnabled = true;
            this.gMap1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap1.Name = "gMap1";
            this.gMap1.NegativeMode = false;
            this.gMap1.PolygonsEnabled = true;
            this.gMap1.RetryLoadTile = 0;
            this.gMap1.RoutesEnabled = true;
            this.gMap1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap1.ShowTileGridLines = false;
            this.gMap1.Size = new System.Drawing.Size(414, 309);
            this.gMap1.TabIndex = 67;
            this.gMap1.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÖREV YÜKÜNÜN SON KONUMU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gMap2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(626, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 473);
            this.panel2.TabIndex = 1;
            // 
            // gMap2
            // 
            this.gMap2.Bearing = 0F;
            this.gMap2.CanDragMap = true;
            this.gMap2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap2.GrayScaleMode = false;
            this.gMap2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap2.LevelsKeepInMemory = 5;
            this.gMap2.Location = new System.Drawing.Point(50, 115);
            this.gMap2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gMap2.MarkersEnabled = true;
            this.gMap2.MaxZoom = 2;
            this.gMap2.MinZoom = 2;
            this.gMap2.MouseWheelZoomEnabled = true;
            this.gMap2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap2.Name = "gMap2";
            this.gMap2.NegativeMode = false;
            this.gMap2.PolygonsEnabled = true;
            this.gMap2.RetryLoadTile = 0;
            this.gMap2.RoutesEnabled = true;
            this.gMap2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap2.ShowTileGridLines = false;
            this.gMap2.Size = new System.Drawing.Size(414, 309);
            this.gMap2.TabIndex = 67;
            this.gMap2.Zoom = 0D;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(94, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAŞIYICININ SON KONUMU";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Uydunun Son Konumu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl gMap1;
        private GMap.NET.WindowsForms.GMapControl gMap2;
    }
}