namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuinscripcion = new FontAwesome.Sharp.IconMenuItem();
            this.sudmenuinscripcion = new System.Windows.Forms.ToolStripMenuItem();
            this.sudmenuestudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.sudmenupagos = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menudocentes = new FontAwesome.Sharp.IconMenuItem();
            this.inscripcionDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuciclos = new FontAwesome.Sharp.IconMenuItem();
            this.menuprogramas = new FontAwesome.Sharp.IconMenuItem();
            this.menucursos = new FontAwesome.Sharp.IconMenuItem();
            this.menugrupos = new FontAwesome.Sharp.IconMenuItem();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuinformacion = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuinscripcion,
            this.menudocentes,
            this.menuciclos,
            this.menuprogramas,
            this.menucursos,
            this.menugrupos,
            this.menuusuario,
            this.menuinformacion});
            this.menu.Location = new System.Drawing.Point(0, 58);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(215, 590);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuinscripcion
            // 
            this.menuinscripcion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sudmenuinscripcion,
            this.sudmenuestudiantes,
            this.sudmenupagos,
            this.inscripcionesToolStripMenuItem});
            this.menuinscripcion.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.menuinscripcion.IconColor = System.Drawing.Color.Black;
            this.menuinscripcion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuinscripcion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinscripcion.Name = "menuinscripcion";
            this.menuinscripcion.Size = new System.Drawing.Size(210, 52);
            this.menuinscripcion.Text = "Inscripción Estudiante";
            this.menuinscripcion.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // sudmenuinscripcion
            // 
            this.sudmenuinscripcion.Name = "sudmenuinscripcion";
            this.sudmenuinscripcion.Size = new System.Drawing.Size(209, 22);
            this.sudmenuinscripcion.Text = "Plataforma de Inscripcion";
            this.sudmenuinscripcion.Click += new System.EventHandler(this.sudmenuinscripcion_Click);
            // 
            // sudmenuestudiantes
            // 
            this.sudmenuestudiantes.Name = "sudmenuestudiantes";
            this.sudmenuestudiantes.Size = new System.Drawing.Size(209, 22);
            this.sudmenuestudiantes.Text = "Estudiantes";
            this.sudmenuestudiantes.Click += new System.EventHandler(this.sudmenuestudiantes_Click);
            // 
            // sudmenupagos
            // 
            this.sudmenupagos.Name = "sudmenupagos";
            this.sudmenupagos.Size = new System.Drawing.Size(209, 22);
            this.sudmenupagos.Text = "Pagos";
            this.sudmenupagos.Click += new System.EventHandler(this.sudmenupagos_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // menudocentes
            // 
            this.menudocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionDocentesToolStripMenuItem,
            this.datosDocentesToolStripMenuItem,
            this.relacionesToolStripMenuItem});
            this.menudocentes.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.menudocentes.IconColor = System.Drawing.Color.Black;
            this.menudocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menudocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menudocentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menudocentes.Name = "menudocentes";
            this.menudocentes.Size = new System.Drawing.Size(210, 52);
            this.menudocentes.Text = "Docentes";
            this.menudocentes.Click += new System.EventHandler(this.menudocentes_Click);
            // 
            // inscripcionDocentesToolStripMenuItem
            // 
            this.inscripcionDocentesToolStripMenuItem.Name = "inscripcionDocentesToolStripMenuItem";
            this.inscripcionDocentesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inscripcionDocentesToolStripMenuItem.Text = "Registrar";
            this.inscripcionDocentesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionDocentesToolStripMenuItem_Click);
            // 
            // datosDocentesToolStripMenuItem
            // 
            this.datosDocentesToolStripMenuItem.Name = "datosDocentesToolStripMenuItem";
            this.datosDocentesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.datosDocentesToolStripMenuItem.Text = "Datos";
            this.datosDocentesToolStripMenuItem.Click += new System.EventHandler(this.datosDocentesToolStripMenuItem_Click);
            // 
            // relacionesToolStripMenuItem
            // 
            this.relacionesToolStripMenuItem.Name = "relacionesToolStripMenuItem";
            this.relacionesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.relacionesToolStripMenuItem.Text = "Relaciones";
            this.relacionesToolStripMenuItem.Click += new System.EventHandler(this.relacionesToolStripMenuItem_Click);
            // 
            // menuciclos
            // 
            this.menuciclos.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.menuciclos.IconColor = System.Drawing.Color.Black;
            this.menuciclos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuciclos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuciclos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuciclos.Name = "menuciclos";
            this.menuciclos.Size = new System.Drawing.Size(210, 52);
            this.menuciclos.Text = "Ciclos";
            this.menuciclos.Click += new System.EventHandler(this.menuciclos_Click);
            // 
            // menuprogramas
            // 
            this.menuprogramas.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.menuprogramas.IconColor = System.Drawing.Color.Black;
            this.menuprogramas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuprogramas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuprogramas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuprogramas.Name = "menuprogramas";
            this.menuprogramas.Size = new System.Drawing.Size(210, 52);
            this.menuprogramas.Text = "Programas de Estudio ";
            this.menuprogramas.Click += new System.EventHandler(this.menuprogramas_Click);
            // 
            // menucursos
            // 
            this.menucursos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.menucursos.IconColor = System.Drawing.Color.Black;
            this.menucursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menucursos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucursos.Name = "menucursos";
            this.menucursos.Size = new System.Drawing.Size(210, 52);
            this.menucursos.Text = "Cursos";
            this.menucursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menucursos.Click += new System.EventHandler(this.menucursos_Click);
            // 
            // menugrupos
            // 
            this.menugrupos.IconChar = FontAwesome.Sharp.IconChar.PeopleArrowsLeftRight;
            this.menugrupos.IconColor = System.Drawing.Color.Black;
            this.menugrupos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menugrupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menugrupos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menugrupos.Name = "menugrupos";
            this.menugrupos.Size = new System.Drawing.Size(210, 52);
            this.menugrupos.Text = "Grupos";
            this.menugrupos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menugrupos.Click += new System.EventHandler(this.menugrupos_Click);
            // 
            // menuusuario
            // 
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(210, 52);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // menuinformacion
            // 
            this.menuinformacion.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuinformacion.IconColor = System.Drawing.Color.Black;
            this.menuinformacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuinformacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinformacion.Name = "menuinformacion";
            this.menuinformacion.Size = new System.Drawing.Size(210, 52);
            this.menuinformacion.Text = "Información";
            this.menuinformacion.Click += new System.EventHandler(this.menuinformacion_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.Brown;
            this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(1078, 58);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Inscripcion CBT";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(215, 58);
            this.contenedor.Margin = new System.Windows.Forms.Padding(2);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(863, 590);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(781, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "lduser";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 648);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.MenuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuinscripcion;
        private FontAwesome.Sharp.IconMenuItem menudocentes;
        private FontAwesome.Sharp.IconMenuItem menuciclos;
        private FontAwesome.Sharp.IconMenuItem menuprogramas;
        private FontAwesome.Sharp.IconMenuItem menugrupos;
        private FontAwesome.Sharp.IconMenuItem menucursos;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menuinformacion;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem sudmenuinscripcion;
        private System.Windows.Forms.ToolStripMenuItem sudmenuestudiantes;
        private System.Windows.Forms.ToolStripMenuItem sudmenupagos;
        private System.Windows.Forms.ToolStripMenuItem inscripcionDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
    }
}

