namespace Vistas
{
    partial class Bienvenido_Form
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
            this.Ingresar_btn = new System.Windows.Forms.Button();
            this.Usuario_lbl = new System.Windows.Forms.Label();
            this.Contraseña_lbl = new System.Windows.Forms.Label();
            this.Bienvenido_lbl = new System.Windows.Forms.Label();
            this.Usuario_txtBox = new System.Windows.Forms.TextBox();
            this.Contraseña_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ingresar_btn
            // 
            this.Ingresar_btn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar_btn.Location = new System.Drawing.Point(333, 271);
            this.Ingresar_btn.Name = "Ingresar_btn";
            this.Ingresar_btn.Size = new System.Drawing.Size(249, 45);
            this.Ingresar_btn.TabIndex = 0;
            this.Ingresar_btn.Text = "INGRESAR";
            this.Ingresar_btn.UseVisualStyleBackColor = true;
            // 
            // Usuario_lbl
            // 
            this.Usuario_lbl.AutoSize = true;
            this.Usuario_lbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_lbl.Location = new System.Drawing.Point(183, 126);
            this.Usuario_lbl.Name = "Usuario_lbl";
            this.Usuario_lbl.Size = new System.Drawing.Size(144, 35);
            this.Usuario_lbl.TabIndex = 1;
            this.Usuario_lbl.Text = "USUARIO";
            // 
            // Contraseña_lbl
            // 
            this.Contraseña_lbl.AutoSize = true;
            this.Contraseña_lbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña_lbl.Location = new System.Drawing.Point(120, 192);
            this.Contraseña_lbl.Name = "Contraseña_lbl";
            this.Contraseña_lbl.Size = new System.Drawing.Size(207, 35);
            this.Contraseña_lbl.TabIndex = 2;
            this.Contraseña_lbl.Text = "CONTRASEÑA";
            // 
            // Bienvenido_lbl
            // 
            this.Bienvenido_lbl.AutoSize = true;
            this.Bienvenido_lbl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenido_lbl.Location = new System.Drawing.Point(357, 9);
            this.Bienvenido_lbl.Name = "Bienvenido_lbl";
            this.Bienvenido_lbl.Size = new System.Drawing.Size(190, 35);
            this.Bienvenido_lbl.TabIndex = 3;
            this.Bienvenido_lbl.Text = "BIENVENIDO";
            this.Bienvenido_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Usuario_txtBox
            // 
            this.Usuario_txtBox.Location = new System.Drawing.Point(333, 126);
            this.Usuario_txtBox.Multiline = true;
            this.Usuario_txtBox.Name = "Usuario_txtBox";
            this.Usuario_txtBox.Size = new System.Drawing.Size(249, 35);
            this.Usuario_txtBox.TabIndex = 1;
            // 
            // Contraseña_textBox
            // 
            this.Contraseña_textBox.Location = new System.Drawing.Point(333, 192);
            this.Contraseña_textBox.Multiline = true;
            this.Contraseña_textBox.Name = "Contraseña_textBox";
            this.Contraseña_textBox.Size = new System.Drawing.Size(249, 35);
            this.Contraseña_textBox.TabIndex = 4;
            // 
            // Bienvenido_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 357);
            this.Controls.Add(this.Contraseña_textBox);
            this.Controls.Add(this.Usuario_txtBox);
            this.Controls.Add(this.Bienvenido_lbl);
            this.Controls.Add(this.Contraseña_lbl);
            this.Controls.Add(this.Usuario_lbl);
            this.Controls.Add(this.Ingresar_btn);
            this.Name = "Bienvenido_Form";
            this.Text = "BIENVENDIO AL SISTEMA";
            this.Load += new System.EventHandler(this.Bienvenido_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ingresar_btn;
        private System.Windows.Forms.Label Usuario_lbl;
        private System.Windows.Forms.Label Contraseña_lbl;
        private System.Windows.Forms.Label Bienvenido_lbl;
        private System.Windows.Forms.TextBox Usuario_txtBox;
        private System.Windows.Forms.TextBox Contraseña_textBox;
    }
}

