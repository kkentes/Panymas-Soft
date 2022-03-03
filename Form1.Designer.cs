namespace Principal
{
    partial class Guardar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guardar));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msjsv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addingr = new System.Windows.Forms.Button();
            this.Ingr = new System.Windows.Forms.TextBox();
            this.svmsj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.procdure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(106, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // msjsv
            // 
            this.msjsv.AutoSize = true;
            this.msjsv.Location = new System.Drawing.Point(93, 134);
            this.msjsv.Name = "msjsv";
            this.msjsv.Size = new System.Drawing.Size(10, 13);
            this.msjsv.TabIndex = 4;
            this.msjsv.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingredientes";
            // 
            // addingr
            // 
            this.addingr.Location = new System.Drawing.Point(302, 444);
            this.addingr.Name = "addingr";
            this.addingr.Size = new System.Drawing.Size(75, 23);
            this.addingr.TabIndex = 6;
            this.addingr.Text = "Guardar";
            this.addingr.UseVisualStyleBackColor = true;
            this.addingr.Click += new System.EventHandler(this.addingr_Click);
            // 
            // Ingr
            // 
            this.Ingr.Location = new System.Drawing.Point(106, 140);
            this.Ingr.Multiline = true;
            this.Ingr.Name = "Ingr";
            this.Ingr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Ingr.Size = new System.Drawing.Size(377, 128);
            this.Ingr.TabIndex = 7;
            // 
            // svmsj
            // 
            this.svmsj.AutoSize = true;
            this.svmsj.Location = new System.Drawing.Point(408, 527);
            this.svmsj.Name = "svmsj";
            this.svmsj.Size = new System.Drawing.Size(0, 13);
            this.svmsj.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Procedimiento";
            // 
            // procdure
            // 
            this.procdure.Location = new System.Drawing.Point(106, 289);
            this.procdure.Multiline = true;
            this.procdure.Name = "procdure";
            this.procdure.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.procdure.Size = new System.Drawing.Size(375, 120);
            this.procdure.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Guardar Receta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.procdure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.svmsj);
            this.Controls.Add(this.Ingr);
            this.Controls.Add(this.addingr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msjsv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Guardar";
            this.Text = "Guardar Receta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label msjsv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addingr;
        private System.Windows.Forms.TextBox Ingr;
        private System.Windows.Forms.Label svmsj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox procdure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

