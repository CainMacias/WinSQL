namespace WinSQL
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msSistemaEscolar = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            catalogoToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            msSistemaEscolar.SuspendLayout();
            SuspendLayout();
            // 
            // msSistemaEscolar
            // 
            msSistemaEscolar.ImageScalingSize = new Size(20, 20);
            msSistemaEscolar.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, catalogoToolStripMenuItem });
            msSistemaEscolar.Location = new Point(0, 0);
            msSistemaEscolar.Name = "msSistemaEscolar";
            msSistemaEscolar.Size = new Size(800, 28);
            msSistemaEscolar.TabIndex = 0;
            msSistemaEscolar.Text = "Sistema Escolar";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { materiasToolStripMenuItem, alumnosToolStripMenuItem, profesoresToolStripMenuItem });
            catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            catalogoToolStripMenuItem.Size = new Size(84, 24);
            catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(224, 26);
            materiasToolStripMenuItem.Text = " Materias";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(224, 26);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(224, 26);
            profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msSistemaEscolar);
            MainMenuStrip = msSistemaEscolar;
            Name = "frmMenu";
            Text = "frmMenu";
            msSistemaEscolar.ResumeLayout(false);
            msSistemaEscolar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msSistemaEscolar;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem catalogoToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
    }
}
