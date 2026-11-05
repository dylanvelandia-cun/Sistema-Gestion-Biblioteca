namespace BibliotecaApp.Presentacion
{
    partial class FrmPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnEditoriales = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlcontenido = new System.Windows.Forms.Panel();
            this.pnlLibros = new System.Windows.Forms.Panel();
            this.lblTotalLibros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPrestamos = new System.Windows.Forms.Panel();
            this.lblTotalPrestamos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlcontenido.SuspendLayout();
            this.pnlLibros.SuspendLayout();
            this.pnlPrestamos.SuspendLayout();
            this.pnlUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(94)))));
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.btnPrestamos);
            this.pnlMenu.Controls.Add(this.btnEditoriales);
            this.pnlMenu.Controls.Add(this.btnAutores);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnLibros);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.lblTitulo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 494);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(14, 393);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(210, 45);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnPrestamos.Location = new System.Drawing.Point(14, 342);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(210, 45);
            this.btnPrestamos.TabIndex = 6;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnEditoriales
            // 
            this.btnEditoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditoriales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditoriales.ForeColor = System.Drawing.Color.White;
            this.btnEditoriales.Location = new System.Drawing.Point(14, 291);
            this.btnEditoriales.Name = "btnEditoriales";
            this.btnEditoriales.Size = new System.Drawing.Size(210, 45);
            this.btnEditoriales.TabIndex = 5;
            this.btnEditoriales.Text = "Editoriales";
            this.btnEditoriales.UseVisualStyleBackColor = false;
            this.btnEditoriales.Click += new System.EventHandler(this.btnEditoriales_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.White;
            this.btnAutores.Location = new System.Drawing.Point(14, 243);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(210, 45);
            this.btnAutores.TabIndex = 4;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = false;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(14, 192);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(210, 45);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.White;
            this.btnLibros.Location = new System.Drawing.Point(14, 141);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(210, 45);
            this.btnLibros.TabIndex = 2;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(12, 90);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(210, 45);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.ImageKey = "(ninguno)";
            this.lblTitulo.Location = new System.Drawing.Point(8, -4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BIBLIOTECA";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlcontenido
            // 
            this.pnlcontenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlcontenido.Controls.Add(this.pnlLibros);
            this.pnlcontenido.Controls.Add(this.pnlPrestamos);
            this.pnlcontenido.Controls.Add(this.pnlUsuarios);
            this.pnlcontenido.Controls.Add(this.lblBienvenida);
            this.pnlcontenido.Controls.Add(this.lblEncabezado);
            this.pnlcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontenido.Location = new System.Drawing.Point(230, 0);
            this.pnlcontenido.Name = "pnlcontenido";
            this.pnlcontenido.Size = new System.Drawing.Size(570, 494);
            this.pnlcontenido.TabIndex = 1;
            // 
            // pnlLibros
            // 
            this.pnlLibros.BackColor = System.Drawing.Color.White;
            this.pnlLibros.Controls.Add(this.lblTotalLibros);
            this.pnlLibros.Controls.Add(this.label4);
            this.pnlLibros.Location = new System.Drawing.Point(167, 90);
            this.pnlLibros.Name = "pnlLibros";
            this.pnlLibros.Size = new System.Drawing.Size(230, 120);
            this.pnlLibros.TabIndex = 4;
            // 
            // lblTotalLibros
            // 
            this.lblTotalLibros.AutoSize = true;
            this.lblTotalLibros.Location = new System.Drawing.Point(105, 24);
            this.lblTotalLibros.Name = "lblTotalLibros";
            this.lblTotalLibros.Size = new System.Drawing.Size(18, 20);
            this.lblTotalLibros.TabIndex = 1;
            this.lblTotalLibros.Text = "0";
            this.lblTotalLibros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Libros registrados";
            // 
            // pnlPrestamos
            // 
            this.pnlPrestamos.BackColor = System.Drawing.Color.White;
            this.pnlPrestamos.Controls.Add(this.lblTotalPrestamos);
            this.pnlPrestamos.Controls.Add(this.label8);
            this.pnlPrestamos.Location = new System.Drawing.Point(167, 342);
            this.pnlPrestamos.Name = "pnlPrestamos";
            this.pnlPrestamos.Size = new System.Drawing.Size(230, 120);
            this.pnlPrestamos.TabIndex = 3;
            // 
            // lblTotalPrestamos
            // 
            this.lblTotalPrestamos.AutoSize = true;
            this.lblTotalPrestamos.Location = new System.Drawing.Point(105, 25);
            this.lblTotalPrestamos.Name = "lblTotalPrestamos";
            this.lblTotalPrestamos.Size = new System.Drawing.Size(18, 20);
            this.lblTotalPrestamos.TabIndex = 1;
            this.lblTotalPrestamos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Prestamos Activos";
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlUsuarios.Controls.Add(this.lblTotalUsuarios);
            this.pnlUsuarios.Controls.Add(this.label6);
            this.pnlUsuarios.Location = new System.Drawing.Point(167, 216);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(230, 120);
            this.pnlUsuarios.TabIndex = 2;
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Location = new System.Drawing.Point(100, 27);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(18, 20);
            this.lblTotalUsuarios.TabIndex = 1;
            this.lblTotalUsuarios.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Usuarios Registrados";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.lblBienvenida.Location = new System.Drawing.Point(25, 55);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(516, 32);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido al Sistema de Gestión de Biblioteca";
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.lblEncabezado.Location = new System.Drawing.Point(111, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(334, 60);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Panel Principal";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.pnlcontenido);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlcontenido.ResumeLayout(false);
            this.pnlcontenido.PerformLayout();
            this.pnlLibros.ResumeLayout(false);
            this.pnlLibros.PerformLayout();
            this.pnlPrestamos.ResumeLayout(false);
            this.pnlPrestamos.PerformLayout();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnEditoriales;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlcontenido;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Panel pnlLibros;
        private System.Windows.Forms.Panel pnlPrestamos;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalLibros;
        private System.Windows.Forms.Label lblTotalPrestamos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Label label6;
    }
}