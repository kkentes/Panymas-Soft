namespace Principal
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionesBásicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recetasToolStripMenuItem,
            this.conversionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarRecetaToolStripMenuItem,
            this.mostrarRecetaToolStripMenuItem});
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.recetasToolStripMenuItem.Text = "Recetas";
            // 
            // guardarRecetaToolStripMenuItem
            // 
            this.guardarRecetaToolStripMenuItem.Name = "guardarRecetaToolStripMenuItem";
            this.guardarRecetaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.guardarRecetaToolStripMenuItem.Text = "Guardar Receta";
            this.guardarRecetaToolStripMenuItem.Click += new System.EventHandler(this.guardarRecetaToolStripMenuItem_Click);
            // 
            // mostrarRecetaToolStripMenuItem
            // 
            this.mostrarRecetaToolStripMenuItem.Name = "mostrarRecetaToolStripMenuItem";
            this.mostrarRecetaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.mostrarRecetaToolStripMenuItem.Text = "Mostrar Receta";
            this.mostrarRecetaToolStripMenuItem.Click += new System.EventHandler(this.mostrarRecetaToolStripMenuItem_Click);
            // 
            // conversionesToolStripMenuItem
            // 
            this.conversionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversionesBásicasToolStripMenuItem});
            this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
            this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.conversionesToolStripMenuItem.Text = "Conversiones";
            this.conversionesToolStripMenuItem.Click += new System.EventHandler(this.conversionesToolStripMenuItem_Click);
            // 
            // conversionesBásicasToolStripMenuItem
            // 
            this.conversionesBásicasToolStripMenuItem.Name = "conversionesBásicasToolStripMenuItem";
            this.conversionesBásicasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.conversionesBásicasToolStripMenuItem.Text = "Conversiones Básicas";
            this.conversionesBásicasToolStripMenuItem.Click += new System.EventHandler(this.conversionesBásicasToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditosToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 344);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionesBásicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
    }
}