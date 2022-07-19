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
using System.Text.RegularExpressions;

namespace Trabajo_Practico
{
    public partial class Administrador_de_Usuarios : Form
    {
        public string conexion_database;

        public Administrador_de_Usuarios(string conexion_database)
        {
            InitializeComponent();

            this.conexion_database = conexion_database;

            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(conexion_database))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Creado por error
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if(txt_id.Text != "")
            {
                MessageBox.Show("No se debe ingresar un ID para insertar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text == "")
            {
                MessageBox.Show("Ingrese un apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Ingrese un email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValidacionEMAIL(e, txt_email.Text) == false)
            {
                MessageBox.Show("Ingrese email valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_email() == true)
            {
                MessageBox.Show("El email a se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese un contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    SqlCommand cmd = new SqlCommand("insert into usuarios(nombre,apellido,email,contrasena) values ('" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_email.Text + "','" + txt_contrasena.Text + "');", cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Usuario ingresado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Actualiza la tabla
                DataTable dt = new DataTable();
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();
                }

                //Limpiar textBoxs
                txt_id.Clear();
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_email.Clear();
                txt_contrasena.Clear();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "1")
            {
                MessageBox.Show("No se puede modificar este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_id.Text == "")
            {
                MessageBox.Show("Ingrese un ID para modificar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text == "")
            {
                MessageBox.Show("Ingrese un apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Ingrese un email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValidacionEMAIL(e, txt_email.Text) == false)
            {
                MessageBox.Show("Ingrese email valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese un contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_id() == false)
            {
                MessageBox.Show("Ingrese un ID valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_email() == true)
            {
                MessageBox.Show("El email a se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    SqlCommand cmd = new SqlCommand("update usuarios set nombre = '" + txt_nombre.Text + "', apellido = '" + txt_apellido.Text + "', email = '" + txt_email.Text + "', contrasena = '" + txt_contrasena.Text + "' where id = " + txt_id.Text + ";", cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Usuario modificado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Actualiza la tabla
                DataTable dt = new DataTable();
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();
                }

                //Limpiar textBoxs
                txt_id.Clear();
                txt_nombre.Clear();
                txt_apellido.Clear();
                txt_email.Clear();
                txt_contrasena.Clear();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(txt_id.Text == "1")
            {
                MessageBox.Show("No se puede eliminar este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_id() == false)
            {
                MessageBox.Show("Ingrese un ID valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nombre.Text != "")
            {
                MessageBox.Show("No se debe ingresar un nombre para eliminar un cliente, solo se necesita el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text != "")
            {
                MessageBox.Show("No se debe ingresar un apellido para eliminar un cliente, solo se necesita el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.Text != "")
            {
                MessageBox.Show("No se debe ingresar un email para eliminar un cliente, solo se necesita el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.Text != "")
            {
                MessageBox.Show("No se debe ingresar una contraseña para eliminar un cliente, solo se necesita el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    
                    SqlCommand cmd = new SqlCommand("delete from usuarios where id = " + txt_id.Text + ";", cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Usuario eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Actualiza la tabla
                DataTable dt = new DataTable();
                using (SqlConnection cn = new SqlConnection(conexion_database))
                {
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();
                }

                //Limpiar texBoxs
                txt_id.Clear();
            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(conexion_database))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from usuarios;", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        static public bool ValidacionEMAIL(EventArgs e, string Mail)//validacion formato de direccion de e-mail
        {

            Regex mRegxExpression;

            if (Mail.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Mail.Trim()))
                {
                    //no es correcta
                    return false;
                }
                else
                {
                    //es correcta
                    return true;
                }

            }
            else
            {
                //no es correcta, esta vacia
                return false;
            }

        }

        public bool validar_email()
        {
            SqlConnection cn = new SqlConnection(conexion_database);

            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from usuarios where email = '" + txt_email.Text + "'", cn);
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validar_id()
        {
            SqlConnection cn = new SqlConnection(conexion_database);

            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from usuarios where id = '" + txt_id.Text + "'", cn);
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
