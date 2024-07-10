namespace CapaPresentacion
{
    partial class formProgramas
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
            this.txtNombrePrograma = new System.Windows.Forms.TextBox();
            this.btnGuardarPrograma = new FontAwesome.Sharp.IconButton();
            this.btnEliminarPrograma = new FontAwesome.Sharp.IconButton();
            this.txtIdPrograma = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 137);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PROGRAMAS DE ESTUDIO QUE OFRECE EL ISTTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del programa:";
            // 
            // txtNombrePrograma
            // 
            this.txtNombrePrograma.Location = new System.Drawing.Point(183, 47);
            this.txtNombrePrograma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombrePrograma.Name = "txtNombrePrograma";
            this.txtNombrePrograma.Size = new System.Drawing.Size(340, 20);
            this.txtNombrePrograma.TabIndex = 4;
            // 
            // btnGuardarPrograma
            // 
            this.btnGuardarPrograma.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPrograma.FlatAppearance.BorderSize = 0;
            this.btnGuardarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPrograma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrograma.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarPrograma.IconColor = System.Drawing.Color.Black;
            this.btnGuardarPrograma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPrograma.IconSize = 30;
            this.btnGuardarPrograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPrograma.Location = new System.Drawing.Point(68, 89);
            this.btnGuardarPrograma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarPrograma.Name = "btnGuardarPrograma";
            this.btnGuardarPrograma.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarPrograma.TabIndex = 5;
            this.btnGuardarPrograma.Text = "Guardar";
            this.btnGuardarPrograma.UseVisualStyleBackColor = false;
            this.btnGuardarPrograma.Click += new System.EventHandler(this.btnGuardarPrograma_Click);
            // 
            // btnEliminarPrograma
            // 
            this.btnEliminarPrograma.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPrograma.FlatAppearance.BorderSize = 0;
            this.btnEliminarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPrograma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPrograma.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarPrograma.IconColor = System.Drawing.Color.Black;
            this.btnEliminarPrograma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarPrograma.IconSize = 30;
            this.btnEliminarPrograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPrograma.Location = new System.Drawing.Point(373, 89);
            this.btnEliminarPrograma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPrograma.Name = "btnEliminarPrograma";
            this.btnEliminarPrograma.Size = new System.Drawing.Size(150, 40);
            this.btnEliminarPrograma.TabIndex = 6;
            this.btnEliminarPrograma.Text = "Eliminar";
            this.btnEliminarPrograma.UseVisualStyleBackColor = false;
            // 
            // txtIdPrograma
            // 
            this.txtIdPrograma.Enabled = false;
            this.txtIdPrograma.Location = new System.Drawing.Point(11, 103);
            this.txtIdPrograma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdPrograma.Name = "txtIdPrograma";
            this.txtIdPrograma.Size = new System.Drawing.Size(29, 20);
            this.txtIdPrograma.TabIndex = 8;
            this.txtIdPrograma.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 235);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "PROGRAMAS DE ESTUDIO REGISTRADOS";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 25;
            this.btnLimpiar.Location = new System.Drawing.Point(528, 38);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(43, 36);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // formProgramas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 412);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtIdPrograma);
            this.Controls.Add(this.btnEliminarPrograma);
            this.Controls.Add(this.btnGuardarPrograma);
            this.Controls.Add(this.txtNombrePrograma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formProgramas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formularioProgramas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombrePrograma;
        private FontAwesome.Sharp.IconButton btnGuardarPrograma;
        private FontAwesome.Sharp.IconButton btnEliminarPrograma;
        private System.Windows.Forms.TextBox txtIdPrograma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}