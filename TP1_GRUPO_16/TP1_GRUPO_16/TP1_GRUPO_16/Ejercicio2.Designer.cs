namespace TP1_GRUPO_16
{
    partial class Ejercicio2
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
            this.gbIngresoDatos = new System.Windows.Forms.GroupBox();
            this.txtbxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbxNombresApellidos = new System.Windows.Forms.ListBox();
            this.gbIngresoDatos.SuspendLayout();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngresoDatos
            // 
            this.gbIngresoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbIngresoDatos.Controls.Add(this.txtbxApellido);
            this.gbIngresoDatos.Controls.Add(this.label2);
            this.gbIngresoDatos.Controls.Add(this.label1);
            this.gbIngresoDatos.Controls.Add(this.txbNombre);
            this.gbIngresoDatos.Controls.Add(this.lblNombre);
            this.gbIngresoDatos.Controls.Add(this.btnAgregar);
            this.gbIngresoDatos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresoDatos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gbIngresoDatos.Location = new System.Drawing.Point(26, 28);
            this.gbIngresoDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbIngresoDatos.Name = "gbIngresoDatos";
            this.gbIngresoDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbIngresoDatos.Size = new System.Drawing.Size(268, 244);
            this.gbIngresoDatos.TabIndex = 0;
            this.gbIngresoDatos.TabStop = false;
            this.gbIngresoDatos.Text = "Ingreso de Datos";
            // 
            // txtbxApellido
            // 
            this.txtbxApellido.BackColor = System.Drawing.Color.SeaShell;
            this.txtbxApellido.Location = new System.Drawing.Point(75, 70);
            this.txtbxApellido.Name = "txtbxApellido";
            this.txtbxApellido.Size = new System.Drawing.Size(174, 26);
            this.txtbxApellido.TabIndex = 5;
            this.txtbxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxApellido_KeyPress);
            this.txtbxApellido.Leave += new System.EventHandler(this.txtbxApellido_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellido:";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.SeaShell;
            this.txbNombre.Location = new System.Drawing.Point(76, 32);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(174, 26);
            this.txbNombre.TabIndex = 2;
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombre_KeyPress);
            this.txbNombre.Leave += new System.EventHandler(this.txbNombre_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(34, 177);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // gbElementos
            // 
            this.gbElementos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbElementos.Controls.Add(this.btnBorrar);
            this.gbElementos.Controls.Add(this.lbxNombresApellidos);
            this.gbElementos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.gbElementos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gbElementos.Location = new System.Drawing.Point(333, 28);
            this.gbElementos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbElementos.Size = new System.Drawing.Size(268, 244);
            this.gbElementos.TabIndex = 1;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Location = new System.Drawing.Point(76, 188);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(102, 32);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbxNombresApellidos
            // 
            this.lbxNombresApellidos.BackColor = System.Drawing.Color.SeaShell;
            this.lbxNombresApellidos.FormattingEnabled = true;
            this.lbxNombresApellidos.ItemHeight = 19;
            this.lbxNombresApellidos.Location = new System.Drawing.Point(14, 28);
            this.lbxNombresApellidos.Name = "lbxNombresApellidos";
            this.lbxNombresApellidos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxNombresApellidos.Size = new System.Drawing.Size(246, 118);
            this.lbxNombresApellidos.Sorted = true;
            this.lbxNombresApellidos.TabIndex = 0;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(626, 305);
            this.Controls.Add(this.gbElementos);
            this.Controls.Add(this.gbIngresoDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ejercicio2_FormClosed);
            this.gbIngresoDatos.ResumeLayout(false);
            this.gbIngresoDatos.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngresoDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.TextBox txtbxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxNombresApellidos;
        private System.Windows.Forms.Button btnBorrar;
    }
}