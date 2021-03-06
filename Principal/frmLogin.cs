﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace Principal
{
    public partial class frmLogin : Form
    {

        private Usuario usuarioLogueado;
     

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }


        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            try
            {
                usuarioLogueado.User = txtUsuario.Text.Trim();
                usuarioLogueado.Pass = txtPass.Text.Trim();
                if (usuarioNegocio.validarUsuario(usuarioLogueado))
                {

                    

                    Close();
                }
                else
                {
                    MessageBox.Show("usuario o pass incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (usuarioLogueado.IdUsuario == 0)
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}