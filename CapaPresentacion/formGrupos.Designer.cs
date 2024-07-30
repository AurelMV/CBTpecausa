using FontAwesome.Sharp;

namespace CapaPresentacion
{
    partial class formGrupos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtaforo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aforo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cicloins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cicloval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscripciones_Realizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtidgrupo = new System.Windows.Forms.TextBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.Ciclo = new System.Windows.Forms.Label();
            this.cbciclo = new System.Windows.Forms.ComboBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEstuR = new FontAwesome.Sharp.IconButton();
            this.BtnEstd = new FontAwesome.Sharp.IconButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbociclos2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 809);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupos del CBT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aforo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(20, 67);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(151, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // txtaforo
            // 
            this.txtaforo.Location = new System.Drawing.Point(20, 109);
            this.txtaforo.Margin = new System.Windows.Forms.Padding(2);
            this.txtaforo.Name = "txtaforo";
            this.txtaforo.Size = new System.Drawing.Size(151, 20);
            this.txtaforo.TabIndex = 8;
            this.txtaforo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaforo_KeyPress);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boton,
            this.id,
            this.Nombre,
            this.Aforo,
            this.EstadoValor,
            this.Estado,
            this.Cicloins,
            this.Cicloval,
            this.Inscripciones_Realizadas});
            this.dataGridView1.Location = new System.Drawing.Point(405, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 315);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // boton
            // 
            this.boton.FillWeight = 50F;
            this.boton.HeaderText = "";
            this.boton.Name = "boton";
            this.boton.ReadOnly = true;
            this.boton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // id
            // 
            this.id.HeaderText = "idGrupo";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 109.1463F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Aforo
            // 
            this.Aforo.FillWeight = 109.1463F;
            this.Aforo.HeaderText = "Aforo";
            this.Aforo.MinimumWidth = 6;
            this.Aforo.Name = "Aforo";
            this.Aforo.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 109.1463F;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Cicloins
            // 
            this.Cicloins.HeaderText = "Cicloins";
            this.Cicloins.Name = "Cicloins";
            this.Cicloins.ReadOnly = true;
            this.Cicloins.Visible = false;
            // 
            // Cicloval
            // 
            this.Cicloval.FillWeight = 109.1463F;
            this.Cicloval.HeaderText = "cicloval";
            this.Cicloval.Name = "Cicloval";
            this.Cicloval.ReadOnly = true;
            // 
            // Inscripciones_Realizadas
            // 
            this.Inscripciones_Realizadas.FillWeight = 109.1463F;
            this.Inscripciones_Realizadas.HeaderText = "Inscripciones_Realizadas";
            this.Inscripciones_Realizadas.Name = "Inscripciones_Realizadas";
            this.Inscripciones_Realizadas.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Grupos de estudio registrados";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(20, 436);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(294, 29);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.Text = "GUARDAR";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(20, 484);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(294, 36);
            this.iconButton2.TabIndex = 15;
            this.iconButton2.Text = "Limpiar una elecion";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado del Grupo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(20, 162);
            this.cboestado.Margin = new System.Windows.Forms.Padding(2);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(83, 21);
            this.cboestado.TabIndex = 17;
            this.cboestado.SelectedIndexChanged += new System.EventHandler(this.cboestado_SelectedIndexChanged);
            // 
            // txtidgrupo
            // 
            this.txtidgrupo.Location = new System.Drawing.Point(252, 11);
            this.txtidgrupo.Margin = new System.Windows.Forms.Padding(2);
            this.txtidgrupo.Name = "txtidgrupo";
            this.txtidgrupo.Size = new System.Drawing.Size(76, 20);
            this.txtidgrupo.TabIndex = 18;
            this.txtidgrupo.Text = "0";
            this.txtidgrupo.Visible = false;
            this.txtidgrupo.TextChanged += new System.EventHandler(this.txtidgrupo_TextChanged);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(172, 11);
            this.txtindice.Margin = new System.Windows.Forms.Padding(2);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(49, 20);
            this.txtindice.TabIndex = 21;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.CadetBlue;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(752, 61);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(99, 30);
            this.iconButton3.TabIndex = 23;
            this.iconButton3.Text = "Buscar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ingrese la clase de filtrado ";
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(855, 61);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(87, 30);
            this.iconButton4.TabIndex = 27;
            this.iconButton4.Text = "Recargar Tablero";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // Ciclo
            // 
            this.Ciclo.AutoSize = true;
            this.Ciclo.Location = new System.Drawing.Point(22, 199);
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.Size = new System.Drawing.Size(39, 13);
            this.Ciclo.TabIndex = 28;
            this.Ciclo.Text = "Ciclo...";
            // 
            // cbciclo
            // 
            this.cbciclo.FormattingEnabled = true;
            this.cbciclo.Location = new System.Drawing.Point(21, 224);
            this.cbciclo.Name = "cbciclo";
            this.cbciclo.Size = new System.Drawing.Size(177, 21);
            this.cbciclo.TabIndex = 29;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.Crimson;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(20, 386);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(294, 36);
            this.iconButton5.TabIndex = 30;
            this.iconButton5.Text = "Aumentar Aforo";
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(214, 109);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(43, 20);
            this.txtcantidad.TabIndex = 31;
            this.txtcantidad.Visible = false;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(263, 109);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(75, 23);
            this.btnsumar.TabIndex = 32;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Visible = false;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "+";
            this.label6.Visible = false;
            // 
            // btnEstuR
            // 
            this.btnEstuR.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEstuR.IconColor = System.Drawing.Color.Black;
            this.btnEstuR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstuR.Location = new System.Drawing.Point(405, 427);
            this.btnEstuR.Name = "btnEstuR";
            this.btnEstuR.Size = new System.Drawing.Size(147, 48);
            this.btnEstuR.TabIndex = 34;
            this.btnEstuR.Text = "Visualizar Estudiantes registrados ";
            this.btnEstuR.UseVisualStyleBackColor = true;
            this.btnEstuR.Visible = false;
            this.btnEstuR.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // BtnEstd
            // 
            this.BtnEstd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEstd.IconColor = System.Drawing.Color.Black;
            this.BtnEstd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEstd.Location = new System.Drawing.Point(574, 427);
            this.BtnEstd.Name = "BtnEstd";
            this.BtnEstd.Size = new System.Drawing.Size(147, 48);
            this.BtnEstd.TabIndex = 35;
            this.BtnEstd.Text = "Estudiantes Reegistrados Deudores";
            this.BtnEstd.UseVisualStyleBackColor = true;
            this.BtnEstd.Visible = false;
            this.BtnEstd.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(405, 484);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1130, 313);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.Visible = false;
            // 
            // cbociclos2
            // 
            this.cbociclos2.FormattingEnabled = true;
            this.cbociclos2.Location = new System.Drawing.Point(509, 69);
            this.cbociclos2.Name = "cbociclos2";
            this.cbociclos2.Size = new System.Drawing.Size(177, 21);
            this.cbociclos2.TabIndex = 37;
            // 
            // formGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1575, 809);
            this.Controls.Add(this.cbociclos2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnEstd);
            this.Controls.Add(this.btnEstuR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.cbciclo);
            this.Controls.Add(this.Ciclo);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtidgrupo);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtaforo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formGrupos";
            this.Text = "formGrupos";
            this.Load += new System.EventHandler(this.formGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtaforo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txtidgrupo;
        private System.Windows.Forms.TextBox txtindice;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label Ciclo;
        private System.Windows.Forms.ComboBox cbciclo;
        private System.Windows.Forms.DataGridViewButtonColumn boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aforo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cicloins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cicloval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscripciones_Realizadas;
        private IconButton iconButton5;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Label label6;
        private IconButton btnEstuR;
        private IconButton BtnEstd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbociclos2;
    }
}