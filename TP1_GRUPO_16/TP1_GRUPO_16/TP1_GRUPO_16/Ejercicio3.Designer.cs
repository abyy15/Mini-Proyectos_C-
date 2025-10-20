namespace TP1_GRUPO_16
{
    partial class Ejercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio3));
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.radioBtnFemenino = new System.Windows.Forms.RadioButton();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.radioBtnCasado = new System.Windows.Forms.RadioButton();
            this.radioBtnSoltero = new System.Windows.Forms.RadioButton();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.clbOficios = new System.Windows.Forms.CheckedListBox();
            this.gbEdad = new System.Windows.Forms.GroupBox();
            this.rbEdad3 = new System.Windows.Forms.RadioButton();
            this.rbEdad2 = new System.Windows.Forms.RadioButton();
            this.rbEdad1 = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.gbSexo.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.gbEdad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.BackColor = System.Drawing.Color.Transparent;
            this.gbSexo.Controls.Add(this.radioBtnMasculino);
            this.gbSexo.Controls.Add(this.radioBtnFemenino);
            this.gbSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbSexo.Location = new System.Drawing.Point(14, 57);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSexo.Size = new System.Drawing.Size(357, 237);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnMasculino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMasculino.Location = new System.Drawing.Point(33, 134);
            this.radioBtnMasculino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(156, 32);
            this.radioBtnMasculino.TabIndex = 1;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemenino
            // 
            this.radioBtnFemenino.AutoSize = true;
            this.radioBtnFemenino.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnFemenino.Checked = true;
            this.radioBtnFemenino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFemenino.Location = new System.Drawing.Point(33, 71);
            this.radioBtnFemenino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnFemenino.Name = "radioBtnFemenino";
            this.radioBtnFemenino.Size = new System.Drawing.Size(151, 32);
            this.radioBtnFemenino.TabIndex = 0;
            this.radioBtnFemenino.TabStop = true;
            this.radioBtnFemenino.Text = "Femenino";
            this.radioBtnFemenino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.gbEstadoCivil.Controls.Add(this.radioBtnCasado);
            this.gbEstadoCivil.Controls.Add(this.radioBtnSoltero);
            this.gbEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstadoCivil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbEstadoCivil.Location = new System.Drawing.Point(14, 305);
            this.gbEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEstadoCivil.Size = new System.Drawing.Size(357, 237);
            this.gbEstadoCivil.TabIndex = 2;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // radioBtnCasado
            // 
            this.radioBtnCasado.AutoSize = true;
            this.radioBtnCasado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnCasado.Checked = true;
            this.radioBtnCasado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCasado.Location = new System.Drawing.Point(33, 134);
            this.radioBtnCasado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnCasado.Name = "radioBtnCasado";
            this.radioBtnCasado.Size = new System.Drawing.Size(130, 32);
            this.radioBtnCasado.TabIndex = 3;
            this.radioBtnCasado.TabStop = true;
            this.radioBtnCasado.Text = "Casado";
            this.radioBtnCasado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnCasado.UseVisualStyleBackColor = true;
            // 
            // radioBtnSoltero
            // 
            this.radioBtnSoltero.AutoSize = true;
            this.radioBtnSoltero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnSoltero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSoltero.Location = new System.Drawing.Point(33, 71);
            this.radioBtnSoltero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnSoltero.Name = "radioBtnSoltero";
            this.radioBtnSoltero.Size = new System.Drawing.Size(115, 32);
            this.radioBtnSoltero.TabIndex = 2;
            this.radioBtnSoltero.Text = "Soltero";
            this.radioBtnSoltero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnSoltero.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSeleccionados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionados.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionados.Location = new System.Drawing.Point(843, 66);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(344, 97);
            this.btnSeleccionados.TabIndex = 3;
            this.btnSeleccionados.Text = "Mostrar lo que se selecciono";
            this.btnSeleccionados.UseVisualStyleBackColor = false;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(435, 366);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 28);
            this.lblResultado.TabIndex = 4;
            // 
            // clbOficios
            // 
            this.clbOficios.BackColor = System.Drawing.Color.SteelBlue;
            this.clbOficios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbOficios.ForeColor = System.Drawing.Color.White;
            this.clbOficios.FormattingEnabled = true;
            this.clbOficios.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficios.Location = new System.Drawing.Point(454, 102);
            this.clbOficios.Name = "clbOficios";
            this.clbOficios.Size = new System.Drawing.Size(324, 140);
            this.clbOficios.TabIndex = 5;
            // 
            // gbEdad
            // 
            this.gbEdad.BackColor = System.Drawing.Color.Transparent;
            this.gbEdad.Controls.Add(this.rbEdad3);
            this.gbEdad.Controls.Add(this.rbEdad2);
            this.gbEdad.Controls.Add(this.rbEdad1);
            this.gbEdad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEdad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbEdad.Location = new System.Drawing.Point(15, 552);
            this.gbEdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEdad.Name = "gbEdad";
            this.gbEdad.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEdad.Size = new System.Drawing.Size(357, 192);
            this.gbEdad.TabIndex = 2;
            this.gbEdad.TabStop = false;
            this.gbEdad.Text = "Edad";
            // 
            // rbEdad3
            // 
            this.rbEdad3.AutoSize = true;
            this.rbEdad3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEdad3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEdad3.Location = new System.Drawing.Point(33, 131);
            this.rbEdad3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEdad3.Name = "rbEdad3";
            this.rbEdad3.Size = new System.Drawing.Size(205, 32);
            this.rbEdad3.TabIndex = 2;
            this.rbEdad3.Text = "41 años o más";
            this.rbEdad3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEdad3.UseVisualStyleBackColor = true;
            // 
            // rbEdad2
            // 
            this.rbEdad2.AutoSize = true;
            this.rbEdad2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEdad2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEdad2.Location = new System.Drawing.Point(33, 88);
            this.rbEdad2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEdad2.Name = "rbEdad2";
            this.rbEdad2.Size = new System.Drawing.Size(178, 32);
            this.rbEdad2.TabIndex = 1;
            this.rbEdad2.Text = "26 – 40 años";
            this.rbEdad2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEdad2.UseVisualStyleBackColor = true;
            // 
            // rbEdad1
            // 
            this.rbEdad1.AutoSize = true;
            this.rbEdad1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEdad1.Checked = true;
            this.rbEdad1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEdad1.Location = new System.Drawing.Point(33, 43);
            this.rbEdad1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEdad1.Name = "rbEdad1";
            this.rbEdad1.Size = new System.Drawing.Size(178, 32);
            this.rbEdad1.TabIndex = 0;
            this.rbEdad1.TabStop = true;
            this.rbEdad1.Text = "18 – 25 años";
            this.rbEdad1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEdad1.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(843, 215);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(344, 97);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar lo que se selecciono";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(830, 344);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(126, 43);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(962, 351);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(200, 26);
            this.txtbxNombre.TabIndex = 8;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 791);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gbEdad);
            this.Controls.Add(this.clbOficios);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.gbSexo);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio3_FormClosed);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.gbEdad.ResumeLayout(false);
            this.gbEdad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.RadioButton radioBtnFemenino;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton radioBtnCasado;
        private System.Windows.Forms.RadioButton radioBtnSoltero;
        private System.Windows.Forms.Button btnSeleccionados;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckedListBox clbOficios;
        private System.Windows.Forms.GroupBox gbEdad;
        private System.Windows.Forms.RadioButton rbEdad2;
        private System.Windows.Forms.RadioButton rbEdad1;
        private System.Windows.Forms.RadioButton rbEdad3;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtbxNombre;
    }
}