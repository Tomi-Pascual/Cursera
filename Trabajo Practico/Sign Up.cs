﻿using System;
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
    public partial class Sign_Up : Form
    {

        public string conexion_database;

        public Sign_Up(string conexion_database)
        {
            InitializeComponent();
            this.conexion_database = conexion_database;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
               MessageBox.Show("Ingrese su nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_apellido.Text == "")
            {
                MessageBox.Show("Ingrese su apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Ingrese un email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValidacionEMAIL(e, txt_email.Text) == false)
            {
                MessageBox.Show("Mala redaccion del email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar_email() == true)
            {
                MessageBox.Show("El email a se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_email.TextLength > 40)
            {
                MessageBox.Show("Ingrese su email debe ser menor a 40 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contrasena.TextLength > 20)
            {
                MessageBox.Show("Ingrese su contrasena debe ser menor a 20 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                registro();
                MessageBox.Show("Registro Exitoso.", "Importante", MessageBoxButtons.OK);
                /*DialogResult mensaje_final = MessageBox.Show("Registro Exitoso", "Importante", MessageBoxButtons.OK);
                if (mensaje_final == DialogResult.OK)
                {
                    Application.Exit();
                }*/
            }
        }

        public void registro()
        {
            using (SqlConnection cn = new SqlConnection(conexion_database))
            {
                SqlCommand cmd = new SqlCommand("insert into usuarios(nombre,apellido,email,contrasena) values ('"+ txt_nombre.Text +"','"+ txt_apellido.Text +"','"+ txt_email.Text +"','"+ txt_contrasena.Text +"');", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
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
