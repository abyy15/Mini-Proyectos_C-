namespace TP1_GRUPO_16
{
    partial class Ejercicio1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.lbNombresSeleccionados = new System.Windows.Forms.ListBox();
            this.btnPasarUno = new System.Windows.Forms.Button();
            this.btnPasanTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(91, 35);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(222, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(406, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 24);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombres
            // 
            this.lbNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNombres.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.ItemHeight = 15;
            this.lbNombres.Location = new System.Drawing.Point(67, 84);
            this.lbNombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNombres.Size = new System.Drawing.Size(137, 122);
            this.lbNombres.TabIndex = 3;
            // 
            // lbNombresSeleccionados
            // 
            this.lbNombresSeleccionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbNombresSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNombresSeleccionados.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombresSeleccionados.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbNombresSeleccionados.FormattingEnabled = true;
            this.lbNombresSeleccionados.ItemHeight = 15;
            this.lbNombresSeleccionados.Location = new System.Drawing.Point(386, 84);
            this.lbNombresSeleccionados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbNombresSeleccionados.Name = "lbNombresSeleccionados";
            this.lbNombresSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNombresSeleccionados.Size = new System.Drawing.Size(137, 122);
            this.lbNombresSeleccionados.TabIndex = 4;
            // 
            // btnPasarUno
            // 
            this.btnPasarUno.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarUno.Location = new System.Drawing.Point(263, 102);
            this.btnPasarUno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPasarUno.Name = "btnPasarUno";
            this.btnPasarUno.Size = new System.Drawing.Size(69, 27);
            this.btnPasarUno.TabIndex = 5;
            this.btnPasarUno.Text = ">";
            this.btnPasarUno.UseVisualStyleBackColor = true;
            this.btnPasarUno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPasanTodos
            // 
            this.btnPasanTodos.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasanTodos.Location = new System.Drawing.Point(263, 145);
            this.btnPasanTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPasanTodos.Name = "btnPasanTodos";
            this.btnPasanTodos.Size = new System.Drawing.Size(69, 27);
            this.btnPasanTodos.TabIndex = 6;
            this.btnPasanTodos.Text = " >>";
            this.btnPasanTodos.UseVisualStyleBackColor = true;
            this.btnPasanTodos.Click += new System.EventHandler(this.btnPasanTodos_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(610, 357);
            this.Controls.Add(this.btnPasanTodos);
            this.Controls.Add(this.btnPasarUno);
            this.Controls.Add(this.lbNombresSeleccionados);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.ListBox lbNombresSeleccionados;
        private System.Windows.Forms.Button btnPasarUno;
        private System.Windows.Forms.Button btnPasanTodos;
    }
}