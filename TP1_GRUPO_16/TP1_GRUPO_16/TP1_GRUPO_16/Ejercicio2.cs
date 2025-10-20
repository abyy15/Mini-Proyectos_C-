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
    public partial class Ejercicio2 : Form
    {
        MenuPrincipal menuPrincipal;
        public Ejercicio2(MenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;

            // 🔹 Asignar evento solo al botón Agregar
            btnAgregar.Click += BtnAgregar_Click;
        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.Show();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text.Trim();
            string apellido = txtbxApellido.Text.Trim();
            


            if(string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Los campos no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El campo Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string nuevoNombre = txbNombre.Text.Trim() + " " + txtbxApellido.Text.Trim();

                foreach(string nombreApellido in lbxNombresApellidos.Items){
                    if(nuevoNombre.ToUpper() == nombreApellido.ToUpper())
                    {
                        MessageBox.Show("El nombre ya fue ingresado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                lbxNombresApellidos.Items.Add(nuevoNombre);

                txbNombre.Clear();
                txtbxApellido.Clear();
                txbNombre.Focus();
            }
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show("¡No puedes ingresar numeros!", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; 
            }

            txbNombre.BackColor = Color.SeaShell;
        }

        private void txtbxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show("¡No puedes ingresar numeros!", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            txtbxApellido.BackColor = Color.SeaShell;
        }

        private void txbNombre_Leave(object sender, EventArgs e)
        {
            if (txbNombre.Text.Trim() == "")
            {
                txbNombre.BackColor = Color.LightCoral;
            }
            
        }

        private void txtbxApellido_Leave(object sender, EventArgs e)
        {
            if (txtbxApellido.Text.Trim() == "")
            {
                txtbxApellido.BackColor = Color.LightCoral;
            }
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var listSeleccionados = lbxNombresApellidos.SelectedItems;
            var listCopia = new List<string>();

            if (listSeleccionados.Count == 0)
            {
                MessageBox.Show("No hay ningún elemento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (var item in listSeleccionados)
                {
                    listCopia.Add(item.ToString());
                }

                foreach (var item in listCopia)               
                {
                    DialogResult Resultado = MessageBox.Show("¿Está seguro que quiere continuar?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Resultado == DialogResult.OK)
                    {
                        lbxNombresApellidos.Items.Remove(item);
                    }
                    else
                    {
                        return;
                    }
                    
                }
            }

        }
    }
}
