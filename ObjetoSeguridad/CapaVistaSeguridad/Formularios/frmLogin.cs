﻿//BRIAN SANTIZO FORM
//0901-17-1483
using System;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica
{
    public partial class frmLogin : Form
    {
        string strUsuarioDB, strContrasenaDB;
        

        public frmLogin()
        {
            InitializeComponent();
            //CODIFICACION PARA EL TEXTFIELD DE CONTRASEÑA
            txtPassword.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            pnlBlanco.BackColor = Color.FromArgb(25, 0, 0, 0);
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.Application.Exit();
        }

    }
}
