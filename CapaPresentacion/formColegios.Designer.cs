namespace CapaPresentacion
{
    partial class formColegios
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
            this.cbodistrito = new System.Windows.Forms.ComboBox();
            this.cboprovincia = new System.Windows.Forms.ComboBox();
            this.cbodepartamentos = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombrecle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtDistritoSeleccionado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbodistrito
            // 
            this.cbodistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodistrito.FormattingEnabled = true;
            this.cbodistrito.Location = new System.Drawing.Point(15, 190);
            this.cbodistrito.Name = "cbodistrito";
            this.cbodistrito.Size = new System.Drawing.Size(150, 21);
            this.cbodistrito.TabIndex = 80;
            this.cbodistrito.SelectedIndexChanged += new System.EventHandler(this.cbodistrito_SelectedIndexChanged);
            // 
            // cboprovincia
            // 
            this.cboprovincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprovincia.FormattingEnabled = true;
            this.cboprovincia.Location = new System.Drawing.Point(15, 140);
            this.cboprovincia.Name = "cboprovincia";
            this.cboprovincia.Size = new System.Drawing.Size(150, 21);
            this.cboprovincia.TabIndex = 79;
            this.cboprovincia.SelectedIndexChanged += new System.EventHandler(this.cboprovincia_SelectedIndexChanged);
            // 
            // cbodepartamentos
            // 
            this.cbodepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodepartamentos.FormattingEnabled = true;
            this.cbodepartamentos.Location = new System.Drawing.Point(15, 89);
            this.cbodepartamentos.Name = "cbodepartamentos";
            this.cbodepartamentos.Size = new System.Drawing.Size(150, 21);
            this.cbodepartamentos.TabIndex = 78;
            this.cbodepartamentos.SelectedIndexChanged += new System.EventHandler(this.cbodepartamentos_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(12, 169);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 18);
            this.label28.TabIndex = 77;
            this.label28.Text = "Distrito";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(12, 122);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 18);
            this.label27.TabIndex = 76;
            this.label27.Text = "Provincia";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 69);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 18);
            this.label26.TabIndex = 75;
            this.label26.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 33);
            this.label1.TabIndex = 81;
            this.label1.Text = "Agregar un nuevo Colegio";
            // 
            // txtnombrecle
            // 
            this.txtnombrecle.Location = new System.Drawing.Point(227, 89);
            this.txtnombrecle.Name = "txtnombrecle";
            this.txtnombrecle.Size = new System.Drawing.Size(220, 20);
            this.txtnombrecle.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Ingrese el nuevo nombre del Colegio";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(227, 140);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(176, 54);
            this.iconButton1.TabIndex = 84;
            this.iconButton1.Text = "Guardar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtDistritoSeleccionado
            // 
            this.txtDistritoSeleccionado.Location = new System.Drawing.Point(12, 258);
            this.txtDistritoSeleccionado.Name = "txtDistritoSeleccionado";
            this.txtDistritoSeleccionado.Size = new System.Drawing.Size(100, 20);
            this.txtDistritoSeleccionado.TabIndex = 85;
            // 
            // formColegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.txtDistritoSeleccionado);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombrecle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbodistrito);
            this.Controls.Add(this.cboprovincia);
            this.Controls.Add(this.cbodepartamentos);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Name = "formColegios";
            this.Text = "formColegios";
            this.Load += new System.EventHandler(this.formColegios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbodistrito;
        private System.Windows.Forms.ComboBox cboprovincia;
        private System.Windows.Forms.ComboBox cbodepartamentos;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombrecle;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtDistritoSeleccionado;
    }
}