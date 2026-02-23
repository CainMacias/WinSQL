namespace WinSQL.Vistas
{
    partial class frmMaterias
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
            splitContainer1 = new SplitContainer();
            dgvMaterias = new DataGridView();
            Buscar = new Label();
            txtMateria = new TextBox();
            btnAgregarMaterias = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregarMaterias);
            splitContainer1.Panel1.Controls.Add(txtMateria);
            splitContainer1.Panel1.Controls.Add(Buscar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvMaterias);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 98;
            splitContainer1.TabIndex = 0;
            // 
            // dgvMaterias
            // 
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Dock = DockStyle.Fill;
            dgvMaterias.Location = new Point(0, 0);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.Size = new Size(800, 348);
            dgvMaterias.TabIndex = 0;
            // 
            // Buscar
            // 
            Buscar.AutoSize = true;
            Buscar.Location = new Point(12, 9);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(52, 20);
            Buscar.TabIndex = 0;
            Buscar.Text = "Buscar";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(12, 45);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(378, 27);
            txtMateria.TabIndex = 1;
            // 
            // btnAgregarMaterias
            // 
            btnAgregarMaterias.Location = new Point(465, 45);
            btnAgregarMaterias.Name = "btnAgregarMaterias";
            btnAgregarMaterias.Size = new Size(94, 29);
            btnAgregarMaterias.TabIndex = 2;
            btnAgregarMaterias.Text = "Agregar";
            btnAgregarMaterias.UseVisualStyleBackColor = true;
            // 
            // frmMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmMaterias";
            Text = "Materias";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtMateria;
        private Label Buscar;
        private DataGridView dgvMaterias;
        private Button btnAgregarMaterias;
    }
}