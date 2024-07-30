namespace CapaPresentacion
{
    partial class formInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programa_de_Estudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbociclo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1216, 654);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "INFORMACIÓN DE LOS ALUMNOS";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(12, 56);
            this.cbobusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(148, 21);
            this.cbobusqueda.TabIndex = 3;
            this.cbobusqueda.SelectedIndexChanged += new System.EventHandler(this.cbobusqueda_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione el grupo que desee visualizar";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.CadetBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(272, 48);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(116, 35);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Estudiante,
            this.Nombre_Estudiante,
            this.Apellido_Paterno,
            this.Apellido_Materno,
            this.Edad,
            this.Pago,
            this.Programa_de_Estudios,
            this.Grupo,
            this.Ciclo});
            this.dataGridView1.Location = new System.Drawing.Point(11, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1196, 550);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_Estudiante
            // 
            this.id_Estudiante.HeaderText = "id_Estudiante";
            this.id_Estudiante.MinimumWidth = 6;
            this.id_Estudiante.Name = "id_Estudiante";
            this.id_Estudiante.Visible = false;
            // 
            // Nombre_Estudiante
            // 
            this.Nombre_Estudiante.HeaderText = "Nombre_Estudiante";
            this.Nombre_Estudiante.MinimumWidth = 6;
            this.Nombre_Estudiante.Name = "Nombre_Estudiante";
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.HeaderText = "Apellido_Paterno";
            this.Apellido_Paterno.MinimumWidth = 6;
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.HeaderText = "Apellido_Materno";
            this.Apellido_Materno.MinimumWidth = 6;
            this.Apellido_Materno.Name = "Apellido_Materno";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.MinimumWidth = 6;
            this.Pago.Name = "Pago";
            // 
            // Programa_de_Estudios
            // 
            this.Programa_de_Estudios.HeaderText = "Programa_de_Estudios";
            this.Programa_de_Estudios.MinimumWidth = 6;
            this.Programa_de_Estudios.Name = "Programa_de_Estudios";
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.MinimumWidth = 6;
            this.Grupo.Name = "Grupo";
            // 
            // Ciclo
            // 
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.MinimumWidth = 6;
            this.Ciclo.Name = "Ciclo";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(1059, 40);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(148, 37);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "Convertir a PDF";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Location = new System.Drawing.Point(164, 57);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(104, 20);
            this.txtbuscar.TabIndex = 8;
            // 
            // cbociclo
            // 
            this.cbociclo.FormattingEnabled = true;
            this.cbociclo.Location = new System.Drawing.Point(813, 56);
            this.cbociclo.Name = "cbociclo";
            this.cbociclo.Size = new System.Drawing.Size(232, 21);
            this.cbociclo.TabIndex = 9;
            this.cbociclo.SelectedIndexChanged += new System.EventHandler(this.cbociclo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(767, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Solo se mostrarán los estudiantes registrados en cierto ciclo en específico y que" +
    " hayan realizado sus pagos ";
            // 
            // formInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1218, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbociclo);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formInfo";
            this.Text = "formInfo";
            this.Load += new System.EventHandler(this.formInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbociclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programa_de_Estudios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.Label label4;
    }
}