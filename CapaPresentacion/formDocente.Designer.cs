namespace CapaPresentacion
{
    partial class formDocente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdDocente = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.cboxEstadoDocente = new System.Windows.Forms.ComboBox();
            this.btnGuardarDocente = new FontAwesome.Sharp.IconButton();
            this.fechaNacimientoDocente = new System.Windows.Forms.DateTimePicker();
            this.txtEmailDocente = new System.Windows.Forms.TextBox();
            this.txtCelularDocente = new System.Windows.Forms.TextBox();
            this.txtDniDocente = new System.Windows.Forms.TextBox();
            this.txtAmaternoDocente = new System.Windows.Forms.TextBox();
            this.txtApaternoDocente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Docente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 378);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 414);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(27, 73);
            this.txtNombreDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(240, 20);
            this.txtNombreDocente.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdDocente);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.rbtnFemenino);
            this.panel1.Controls.Add(this.rbtnMasculino);
            this.panel1.Controls.Add(this.cboxEstadoDocente);
            this.panel1.Controls.Add(this.btnGuardarDocente);
            this.panel1.Controls.Add(this.fechaNacimientoDocente);
            this.panel1.Controls.Add(this.txtEmailDocente);
            this.panel1.Controls.Add(this.txtCelularDocente);
            this.panel1.Controls.Add(this.txtDniDocente);
            this.panel1.Controls.Add(this.txtAmaternoDocente);
            this.panel1.Controls.Add(this.txtApaternoDocente);
            this.panel1.Controls.Add(this.txtNombreDocente);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 561);
            this.panel1.TabIndex = 0;
            // 
            // txtIdDocente
            // 
            this.txtIdDocente.Enabled = false;
            this.txtIdDocente.Location = new System.Drawing.Point(215, 262);
            this.txtIdDocente.Name = "txtIdDocente";
            this.txtIdDocente.Size = new System.Drawing.Size(52, 20);
            this.txtIdDocente.TabIndex = 27;
            this.txtIdDocente.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(224, 13);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 36);
            this.iconButton1.TabIndex = 26;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(122, 262);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtnFemenino.TabIndex = 25;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(26, 262);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 24;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // cboxEstadoDocente
            // 
            this.cboxEstadoDocente.FormattingEnabled = true;
            this.cboxEstadoDocente.Location = new System.Drawing.Point(27, 429);
            this.cboxEstadoDocente.Margin = new System.Windows.Forms.Padding(2);
            this.cboxEstadoDocente.Name = "cboxEstadoDocente";
            this.cboxEstadoDocente.Size = new System.Drawing.Size(240, 21);
            this.cboxEstadoDocente.TabIndex = 23;
            // 
            // btnGuardarDocente
            // 
            this.btnGuardarDocente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDocente.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarDocente.IconColor = System.Drawing.Color.Black;
            this.btnGuardarDocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarDocente.IconSize = 30;
            this.btnGuardarDocente.Location = new System.Drawing.Point(27, 479);
            this.btnGuardarDocente.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarDocente.Name = "btnGuardarDocente";
            this.btnGuardarDocente.Size = new System.Drawing.Size(240, 48);
            this.btnGuardarDocente.TabIndex = 20;
            this.btnGuardarDocente.Text = "Guardar";
            this.btnGuardarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarDocente.UseVisualStyleBackColor = true;
            this.btnGuardarDocente.Click += new System.EventHandler(this.btnGuardarDocente_Click);
            // 
            // fechaNacimientoDocente
            // 
            this.fechaNacimientoDocente.CustomFormat = "dd/MM/yyyy";
            this.fechaNacimientoDocente.Location = new System.Drawing.Point(27, 350);
            this.fechaNacimientoDocente.Margin = new System.Windows.Forms.Padding(2);
            this.fechaNacimientoDocente.Name = "fechaNacimientoDocente";
            this.fechaNacimientoDocente.Size = new System.Drawing.Size(240, 20);
            this.fechaNacimientoDocente.TabIndex = 19;
            // 
            // txtEmailDocente
            // 
            this.txtEmailDocente.Location = new System.Drawing.Point(27, 393);
            this.txtEmailDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailDocente.Name = "txtEmailDocente";
            this.txtEmailDocente.Size = new System.Drawing.Size(240, 20);
            this.txtEmailDocente.TabIndex = 17;
            // 
            // txtCelularDocente
            // 
            this.txtCelularDocente.Location = new System.Drawing.Point(27, 302);
            this.txtCelularDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCelularDocente.Name = "txtCelularDocente";
            this.txtCelularDocente.Size = new System.Drawing.Size(240, 20);
            this.txtCelularDocente.TabIndex = 15;
            // 
            // txtDniDocente
            // 
            this.txtDniDocente.Location = new System.Drawing.Point(27, 214);
            this.txtDniDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDniDocente.Name = "txtDniDocente";
            this.txtDniDocente.Size = new System.Drawing.Size(240, 20);
            this.txtDniDocente.TabIndex = 13;
            // 
            // txtAmaternoDocente
            // 
            this.txtAmaternoDocente.Location = new System.Drawing.Point(27, 169);
            this.txtAmaternoDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmaternoDocente.Name = "txtAmaternoDocente";
            this.txtAmaternoDocente.Size = new System.Drawing.Size(240, 20);
            this.txtAmaternoDocente.TabIndex = 12;
            // 
            // txtApaternoDocente
            // 
            this.txtApaternoDocente.Location = new System.Drawing.Point(27, 119);
            this.txtApaternoDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtApaternoDocente.Name = "txtApaternoDocente";
            this.txtApaternoDocente.Size = new System.Drawing.Size(240, 20);
            this.txtApaternoDocente.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 506);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(441, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Docentes registrados: ";
            // 
            // formDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 561);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formDocente";
            this.Text = "FormularioDocente";
            this.Load += new System.EventHandler(this.formDocente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDocente;
        private System.Windows.Forms.TextBox txtEmailDocente;
        private System.Windows.Forms.TextBox txtCelularDocente;
        private System.Windows.Forms.TextBox txtDniDocente;
        private System.Windows.Forms.TextBox txtAmaternoDocente;
        private System.Windows.Forms.TextBox txtApaternoDocente;
        private FontAwesome.Sharp.IconButton btnGuardarDocente;
        private System.Windows.Forms.ComboBox cboxEstadoDocente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtIdDocente;
    }
}