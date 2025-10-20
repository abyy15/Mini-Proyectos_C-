using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_16
{
    public partial class Ejercicio1 : Form
    {
        MenuPrincipal menuPrincipal;
        public Ejercicio1(MenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
        }

        

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbNombres.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un nombre para pasar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (string items in lbNombres.SelectedItems)
            {
                lbNombresSeleccionados.Items.Add(items);
            }

            for (int i = lbNombres.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lbNombres.Items.RemoveAt(lbNombres.SelectedIndices[i]);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Campo inválido: No se permiten números.",
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtNombre.Text = ""; 
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                return;
            }

            string nombreMayus = txtNombre.Text.Trim().ToUpper();

            foreach (string nombre in lbNombres.Items)
            {
                if (nombre.ToUpper() == nombreMayus)
                {
                    MessageBox.Show("El nombre ya fue ingresado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (string nombre in lbNombresSeleccionados.Items)
            {
                if (nombre.ToUpper() == nombreMayus)
                {
                    MessageBox.Show("El nombre ya fue ingresado y se paso a la segunda lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            lbNombres.Items.Add(txtNombre.Text.Trim());
            txtNombre.Text = "";
        }


        private void btnPasanTodos_Click(object sender, EventArgs e)
        {
            int items = lbNombres.Items.Count;

            if (items == 0)
            {
                MessageBox.Show("No hay nombres para pasar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                for (int i = 0; i < items; i++)
                {
                    lbNombresSeleccionados.Items.Add(lbNombres.Items[i]);
                }
            }
            lbNombres.Items.Clear();
        }
    }
}
