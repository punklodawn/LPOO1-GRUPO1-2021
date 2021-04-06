namespace Vistas
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edificioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEdificioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inquilinosToolStripMenuItem,
            this.departamenteToolStripMenuItem,
            this.edificioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.usuariosToolStripMenuItem.Text = "MENU";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // inquilinosToolStripMenuItem
            // 
            this.inquilinosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem});
            this.inquilinosToolStripMenuItem.Name = "inquilinosToolStripMenuItem";
            this.inquilinosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.inquilinosToolStripMenuItem.Text = "Inquilinos";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.altaToolStripMenuItem.Text = "Alta Inquilinos";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // departamenteToolStripMenuItem
            // 
            this.departamenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDepartamentoToolStripMenuItem});
            this.departamenteToolStripMenuItem.Name = "departamenteToolStripMenuItem";
            this.departamenteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.departamenteToolStripMenuItem.Text = "Departamente";
            // 
            // altaDepartamentoToolStripMenuItem
            // 
            this.altaDepartamentoToolStripMenuItem.Name = "altaDepartamentoToolStripMenuItem";
            this.altaDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.altaDepartamentoToolStripMenuItem.Text = "Alta Departamento";
            // 
            // edificioToolStripMenuItem
            // 
            this.edificioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEdificioToolStripMenuItem});
            this.edificioToolStripMenuItem.Name = "edificioToolStripMenuItem";
            this.edificioToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.edificioToolStripMenuItem.Text = "Edificio";
            // 
            // altaEdificioToolStripMenuItem
            // 
            this.altaEdificioToolStripMenuItem.Name = "altaEdificioToolStripMenuItem";
            this.altaEdificioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.altaEdificioToolStripMenuItem.Text = "Alta Edificio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 179);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edificioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEdificioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}