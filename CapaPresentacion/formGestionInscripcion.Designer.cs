namespace CapaPresentacion
{
    partial class formGestionInscripcion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Turno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtestudiante = new System.Windows.Forms.TextBox();
            this.cbociclo = new System.Windows.Forms.ComboBox();
            this.cboprograma = new System.Windows.Forms.ComboBox();
            this.cbogrupo = new System.Windows.Forms.ComboBox();
            this.cbopago = new System.Windows.Forms.ComboBox();
            this.cboturno = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestudiantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprograma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtidinscripcion = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.txtidestudiante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion de Inscripciones";
            // 
            // Turno
            // 
            this.Turno.AutoSize = true;
            this.Turno.Location = new System.Drawing.Point(18, 32);
            this.Turno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(35, 13);
            this.Turno.TabIndex = 2;
            this.Turno.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "fecha inscripcion ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estudiante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ciclo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Programa de estudios ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Grupo";
            // 
            // txtfecha
            // 
            this.txtfecha.CustomFormat = "yyyy-MM-dd";
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(20, 91);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(151, 20);
            this.txtfecha.TabIndex = 10;
            // 
            // txtestudiante
            // 
            this.txtestudiante.Enabled = false;
            this.txtestudiante.Location = new System.Drawing.Point(243, 42);
            this.txtestudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtestudiante.Name = "txtestudiante";
            this.txtestudiante.Size = new System.Drawing.Size(76, 20);
            this.txtestudiante.TabIndex = 11;
            // 
            // cbociclo
            // 
            this.cbociclo.FormattingEnabled = true;
            this.cbociclo.Location = new System.Drawing.Point(243, 78);
            this.cbociclo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbociclo.Name = "cbociclo";
            this.cbociclo.Size = new System.Drawing.Size(92, 21);
            this.cbociclo.TabIndex = 12;
            // 
            // cboprograma
            // 
            this.cboprograma.FormattingEnabled = true;
            this.cboprograma.Location = new System.Drawing.Point(302, 115);
            this.cboprograma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboprograma.Name = "cboprograma";
            this.cboprograma.Size = new System.Drawing.Size(92, 21);
            this.cboprograma.TabIndex = 13;
            // 
            // cbogrupo
            // 
            this.cbogrupo.FormattingEnabled = true;
            this.cbogrupo.Location = new System.Drawing.Point(412, 52);
            this.cbogrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbogrupo.Name = "cbogrupo";
            this.cbogrupo.Size = new System.Drawing.Size(92, 21);
            this.cbogrupo.TabIndex = 14;
            // 
            // cbopago
            // 
            this.cbopago.FormattingEnabled = true;
            this.cbopago.Location = new System.Drawing.Point(34, 145);
            this.cbopago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbopago.Name = "cbopago";
            this.cbopago.Size = new System.Drawing.Size(92, 21);
            this.cbopago.TabIndex = 15;
            this.cbopago.SelectedIndexChanged += new System.EventHandler(this.cbopago_SelectedIndexChanged);
            // 
            // cboturno
            // 
            this.cboturno.FormattingEnabled = true;
            this.cboturno.Location = new System.Drawing.Point(54, 32);
            this.cboturno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboturno.Name = "cboturno";
            this.cboturno.Size = new System.Drawing.Size(92, 21);
            this.cboturno.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boton,
            this.id,
            this.Turnos,
            this.Fecha,
            this.valorpago,
            this.Pago,
            this.idestudiantes,
            this.Estudiante,
            this.idciclo,
            this.Ciclo,
            this.idprograma,
            this.Programa,
            this.idusuario,
            this.Usuario,
            this.idGrupo,
            this.Grupo});
            this.dataGridView1.Location = new System.Drawing.Point(20, 237);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(925, 209);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // boton
            // 
            this.boton.Frozen = true;
            this.boton.HeaderText = "";
            this.boton.MinimumWidth = 6;
            this.boton.Name = "boton";
            this.boton.ReadOnly = true;
            this.boton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.boton.Width = 50;
            // 
            // id
            // 
            this.id.HeaderText = "idInscripcion";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Turnos
            // 
            this.Turnos.Frozen = true;
            this.Turnos.HeaderText = "Turnos";
            this.Turnos.MinimumWidth = 6;
            this.Turnos.Name = "Turnos";
            this.Turnos.ReadOnly = true;
            this.Turnos.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // valorpago
            // 
            this.valorpago.HeaderText = "valorpago";
            this.valorpago.MinimumWidth = 6;
            this.valorpago.Name = "valorpago";
            this.valorpago.ReadOnly = true;
            this.valorpago.Width = 125;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.MinimumWidth = 6;
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            this.Pago.Width = 125;
            // 
            // idestudiantes
            // 
            this.idestudiantes.HeaderText = "idestudiantes";
            this.idestudiantes.MinimumWidth = 6;
            this.idestudiantes.Name = "idestudiantes";
            this.idestudiantes.ReadOnly = true;
            this.idestudiantes.Visible = false;
            this.idestudiantes.Width = 125;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.MinimumWidth = 6;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            this.Estudiante.Width = 125;
            // 
            // idciclo
            // 
            this.idciclo.HeaderText = "idciclo";
            this.idciclo.MinimumWidth = 6;
            this.idciclo.Name = "idciclo";
            this.idciclo.ReadOnly = true;
            this.idciclo.Visible = false;
            this.idciclo.Width = 125;
            // 
            // Ciclo
            // 
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.MinimumWidth = 6;
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.ReadOnly = true;
            this.Ciclo.Width = 125;
            // 
            // idprograma
            // 
            this.idprograma.HeaderText = "idprograma";
            this.idprograma.MinimumWidth = 6;
            this.idprograma.Name = "idprograma";
            this.idprograma.ReadOnly = true;
            this.idprograma.Visible = false;
            this.idprograma.Width = 125;
            // 
            // Programa
            // 
            this.Programa.HeaderText = "Programa";
            this.Programa.MinimumWidth = 6;
            this.Programa.Name = "Programa";
            this.Programa.ReadOnly = true;
            this.Programa.Width = 125;
            // 
            // idusuario
            // 
            this.idusuario.HeaderText = "idusuario";
            this.idusuario.MinimumWidth = 6;
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Visible = false;
            this.idusuario.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 125;
            // 
            // idGrupo
            // 
            this.idGrupo.HeaderText = "idGrupo";
            this.idGrupo.MinimumWidth = 6;
            this.idGrupo.Name = "idGrupo";
            this.idGrupo.ReadOnly = true;
            this.idGrupo.Visible = false;
            this.idGrupo.Width = 125;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.MinimumWidth = 6;
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.Width = 125;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(139, 6);
            this.txtindice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(49, 20);
            this.txtindice.TabIndex = 24;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtidinscripcion
            // 
            this.txtidinscripcion.Location = new System.Drawing.Point(202, 6);
            this.txtidinscripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidinscripcion.Name = "txtidinscripcion";
            this.txtidinscripcion.Size = new System.Drawing.Size(76, 20);
            this.txtidinscripcion.TabIndex = 23;
            this.txtidinscripcion.Text = "0";
            this.txtidinscripcion.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(412, 154);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(294, 29);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.Text = "GUARDAR";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(270, 154);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(76, 20);
            this.txtusuario.TabIndex = 25;
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(538, 27);
            this.txtidusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(76, 20);
            this.txtidusuario.TabIndex = 26;
            this.txtidusuario.Visible = false;
            // 
            // txtidestudiante
            // 
            this.txtidestudiante.Location = new System.Drawing.Point(538, 65);
            this.txtidestudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidestudiante.Name = "txtidestudiante";
            this.txtidestudiante.Size = new System.Drawing.Size(76, 20);
            this.txtidestudiante.TabIndex = 27;
            this.txtidestudiante.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Buscar un Pago";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(377, 211);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(127, 20);
            this.txtbusqueda.TabIndex = 38;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(269, 211);
            this.cbobusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(92, 21);
            this.cbobusqueda.TabIndex = 37;
            // 
            // iconButton5
            // 
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(628, 203);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(87, 30);
            this.iconButton5.TabIndex = 36;
            this.iconButton5.Text = "Recargar Tablero";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.Location = new System.Drawing.Point(524, 203);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(99, 30);
            this.iconButton6.TabIndex = 35;
            this.iconButton6.Text = "Buscar";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // formGestionInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 455);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.txtidestudiante);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtidinscripcion);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboturno);
            this.Controls.Add(this.cbopago);
            this.Controls.Add(this.cbogrupo);
            this.Controls.Add(this.cboprograma);
            this.Controls.Add(this.cbociclo);
            this.Controls.Add(this.txtestudiante);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formGestionInscripcion";
            this.Text = "GestionInscripcion";
            this.Load += new System.EventHandler(this.formGestionInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Turno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.TextBox txtestudiante;
        private System.Windows.Forms.ComboBox cbociclo;
        private System.Windows.Forms.ComboBox cboprograma;
        private System.Windows.Forms.ComboBox cbogrupo;
        private System.Windows.Forms.ComboBox cbopago;
        private System.Windows.Forms.ComboBox cboturno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtidinscripcion;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.DataGridViewButtonColumn boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.TextBox txtidestudiante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
    }
}