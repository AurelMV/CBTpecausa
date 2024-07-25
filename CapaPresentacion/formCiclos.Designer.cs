namespace CapaPresentacion
{
    partial class formCiclos
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
            this.txtNombreCiclo = new System.Windows.Forms.TextBox();
            this.datetpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datetpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarCiclo = new FontAwesome.Sharp.IconButton();
            this.txtIdCiclo = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 366);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CICLOS ACADÉMICOS DEL CBT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Ciclo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Inicio";
            // 
            // txtNombreCiclo
            // 
            this.txtNombreCiclo.Location = new System.Drawing.Point(19, 80);
            this.txtNombreCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCiclo.Name = "txtNombreCiclo";
            this.txtNombreCiclo.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCiclo.TabIndex = 4;
            // 
            // datetpFechaInicio
            // 
            this.datetpFechaInicio.CustomFormat = "dd/MM/YYYY";
            this.datetpFechaInicio.Location = new System.Drawing.Point(19, 129);
            this.datetpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.datetpFechaInicio.Name = "datetpFechaInicio";
            this.datetpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.datetpFechaInicio.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(487, 319);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ciclos del CBT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Finalización";
            // 
            // datetpFechaFin
            // 
            this.datetpFechaFin.Location = new System.Drawing.Point(19, 178);
            this.datetpFechaFin.Name = "datetpFechaFin";
            this.datetpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.datetpFechaFin.TabIndex = 12;
            // 
            // btnRegistrarCiclo
            // 
            this.btnRegistrarCiclo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarCiclo.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCiclo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCiclo.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnRegistrarCiclo.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarCiclo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCiclo.IconSize = 40;
            this.btnRegistrarCiclo.Location = new System.Drawing.Point(46, 234);
            this.btnRegistrarCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarCiclo.Name = "btnRegistrarCiclo";
            this.btnRegistrarCiclo.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrarCiclo.TabIndex = 6;
            this.btnRegistrarCiclo.Text = "Guardar";
            this.btnRegistrarCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCiclo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCiclo.UseVisualStyleBackColor = false;
            this.btnRegistrarCiclo.Click += new System.EventHandler(this.btnRegistrarCiclo_Click);
            // 
            // txtIdCiclo
            // 
            this.txtIdCiclo.Location = new System.Drawing.Point(71, 335);
            this.txtIdCiclo.Name = "txtIdCiclo";
            this.txtIdCiclo.ReadOnly = true;
            this.txtIdCiclo.Size = new System.Drawing.Size(69, 20);
            this.txtIdCiclo.TabIndex = 13;
            this.txtIdCiclo.Text = "0";
            this.txtIdCiclo.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(189, 45);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // formCiclos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(745, 366);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtIdCiclo);
            this.Controls.Add(this.datetpFechaFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistrarCiclo);
            this.Controls.Add(this.datetpFechaInicio);
            this.Controls.Add(this.txtNombreCiclo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formCiclos";
            this.Text = "formularioCiclos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCiclo;
        private System.Windows.Forms.DateTimePicker datetpFechaInicio;
        private FontAwesome.Sharp.IconButton btnRegistrarCiclo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetpFechaFin;
        private System.Windows.Forms.TextBox txtIdCiclo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}