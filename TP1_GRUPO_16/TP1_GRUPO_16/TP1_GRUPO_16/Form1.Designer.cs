namespace TP1_GRUPO_16
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.btnEjercicio2 = new System.Windows.Forms.Button();
            this.btnEjercicio3 = new System.Windows.Forms.Button();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblMiembros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio1.Location = new System.Drawing.Point(132, 134);
            this.btnEjercicio1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(160, 78);
            this.btnEjercicio1.TabIndex = 0;
            this.btnEjercicio1.Text = "Ejercicio1";
            this.btnEjercicio1.UseVisualStyleBackColor = true;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // btnEjercicio2
            // 
            this.btnEjercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio2.Location = new System.Drawing.Point(494, 134);
            this.btnEjercicio2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEjercicio2.Name = "btnEjercicio2";
            this.btnEjercicio2.Size = new System.Drawing.Size(160, 78);
            this.btnEjercicio2.TabIndex = 1;
            this.btnEjercicio2.Text = "Ejercicio2";
            this.btnEjercicio2.UseVisualStyleBackColor = true;
            this.btnEjercicio2.Click += new System.EventHandler(this.btnEjercicio2_Click);
            // 
            // btnEjercicio3
            // 
            this.btnEjercicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio3.Location = new System.Drawing.Point(861, 134);
            this.btnEjercicio3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEjercicio3.Name = "btnEjercicio3";
            this.btnEjercicio3.Size = new System.Drawing.Size(160, 78);
            this.btnEjercicio3.TabIndex = 2;
            this.btnEjercicio3.Text = "Ejercicio3";
            this.btnEjercicio3.UseVisualStyleBackColor = true;
            this.btnEjercicio3.Click += new System.EventHandler(this.btnEjercicio3_Click);
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(216, 308);
            this.lblIntegrantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(138, 29);
            this.lblIntegrantes.TabIndex = 3;
            this.lblIntegrantes.Text = "Integrantes:";
            // 
            // lblMiembros
            // 
            this.lblMiembros.AutoSize = true;
            this.lblMiembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembros.Location = new System.Drawing.Point(384, 308);
            this.lblMiembros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiembros.Name = "lblMiembros";
            this.lblMiembros.Size = new System.Drawing.Size(459, 174);
            this.lblMiembros.TabIndex = 4;
            this.lblMiembros.Text = resources.GetString("lblMiembros.Text");
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblMiembros);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.btnEjercicio3);
            this.Controls.Add(this.btnEjercicio2);
            this.Controls.Add(this.btnEjercicio1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Button btnEjercicio2;
        private System.Windows.Forms.Button btnEjercicio3;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblMiembros;
    }
}

