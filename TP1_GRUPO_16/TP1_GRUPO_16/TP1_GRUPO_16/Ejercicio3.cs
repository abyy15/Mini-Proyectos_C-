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
    public partial class Ejercicio3 : Form
    {
        MenuPrincipal menuPrincipal;
        public Ejercicio3(MenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
        }

        private void Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.Show();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            bool nombreEscrito = txtbxNombre.Text != "";
            bool oficioSeleccionado = clbOficios.CheckedItems.Count > 0;
            bool sexoSeleccionado = radioBtnFemenino.Checked || radioBtnMasculino.Checked;

            if (oficioSeleccionado && sexoSeleccionado && nombreEscrito)
            {
                lblResultado.ForeColor = Color.Black;
                lblResultado.Text = "RESULTADO" + "\r\n";
                string mostrar;
                mostrar = "Nombre: " + txtbxNombre.Text + "\r\n";
                mostrar += "Sexo: " + (radioBtnFemenino.Checked ? "Femenino" : "Masculino");

                if (radioBtnFemenino.Checked==true)
                {
                    this.BackgroundImage = null;
                    BackColor = Color.FromArgb(196, 133, 134);
                }
                else
                {
                    this.BackgroundImage = null;
                    BackColor = Color.FromArgb(149, 157, 131); 
                }
               
                mostrar += "\r\n" + "Estado civil: " + (radioBtnCasado.Checked ? "Casado" : "Soltero");

                mostrar += "\r\n" + "Edad; ";
                if (rbEdad1.Checked) mostrar += "18 - 25 años";
                else if (rbEdad2.Checked) mostrar += "26 - 40 años";
                else if (rbEdad2.Checked) mostrar += "41 años o más";
                lblResultado.Text += mostrar;

                mostrar += "\r\n" + "Oficio: ";

                foreach (Object items in clbOficios.CheckedItems)
                {
                    mostrar += "\r\n" + "  - " + items.ToString();
                }
                lblResultado.Text = mostrar;
            }
            else
            {
               MessageBox.Show("Por favor, debe seleccionar al menos una casilla en cada opcion.", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show("¿Esta seguro que desea borrar las opciones seleccionadas?", "Confirmar Eliminación", buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)

                {
                    lblResultado.Text = "";
                    radioBtnFemenino.Checked = true;
                    radioBtnMasculino.Checked = false;
                    radioBtnCasado.Checked = false;
                    radioBtnSoltero.Checked = true;
                    rbEdad1.Checked = true;
                    rbEdad2.Checked = false;
                    rbEdad3.Checked = false;
                    for (int i = 0; i < clbOficios.Items.Count; i++)
                    {
                        clbOficios.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay nada para borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
