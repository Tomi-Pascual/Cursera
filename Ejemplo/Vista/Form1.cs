using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conexion = "";

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text == "")
            {
                MessageBox.Show("Ingrese su apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nombnre_usuario.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("insert into usuarios(nombre,apellido,usuario,contrasena) values ('" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_nombnre_usuario.Text + "','" + txt_contrasena.Text + "');", cn);
                    cmd.CommandType = CommandType.Text;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Registro existoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

// '" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_nombnre_usuario.Text + "','" + txt_contrasena.Text + "'
