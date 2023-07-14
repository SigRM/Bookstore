using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV1.UI
{
    public partial class FrmLogIn : Form
    {
        private int contador = 0;
        private int indicativo = 0;
        private string userDato = "";
        private string passDato = "";
        public FrmLogIn(int pIndicativo, string pUserDato, string pPassDato)
        {
            indicativo = pIndicativo;
            userDato = pUserDato;
            passDato = pPassDato;
            InitializeComponent();
        }

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            this.cmbRoles.Items.Clear();
            this.txtUsername.Clear();
            this.txtPassword.Clear();           
            this.cmbRoles.Items.Add("Administrator");
            this.cmbRoles.Items.Add("Employee");
            this.cmbRoles.Items.Add("Customer");
            this.cmbRoles.SelectedIndex = 0;
            this.txtUsername.Focus();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                LogIn oUser = LogIn.GetInstance();
                oUser.Identificacion = this.txtUsername.Text;
                oUser.contrasena = this.txtPassword.Text;
                oUser.rol = (this.cmbRoles.Text);
                if ((oUser.rol.ToString().Trim().ToUpper().Equals("ADMINISTRATOR") && oUser.Identificacion.ToString().Trim().ToUpper().Equals("ADMIN") && oUser.contrasena.ToString().Trim().ToUpper().Equals("123")) ||
                    (oUser.rol.ToString().Trim().ToUpper().Equals("EMPLOYEE") && oUser.Identificacion.ToString().Trim().ToUpper().Equals("EMPLOYEE") && oUser.contrasena.ToString().Trim().ToUpper().Equals("123")) ||
                    (oUser.rol.ToString().Trim().ToUpper().Equals("CUSTOMER") && oUser.Identificacion.ToString().Trim().ToUpper().Equals("CUSTOMER") && oUser.contrasena.ToString().Trim().ToUpper().Equals("123"))) 
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    contador++;
                    MessageBox.Show("Incorrect user , try No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    if (contador == 3)
                    {
                        this.DialogResult = DialogResult.Abort;
                        Close();
                    }
                }
            }
            catch (Exception error)
            {
                contador++;
                if (error.Message.Trim().Contains("Sign In Failed") == true || error.Message.Trim().Contains("Login failed") == true)
                    MessageBox.Show("Incorrect user, try No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error ->" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (contador == 3)
                {
                    this.DialogResult = DialogResult.Abort;
                    Close();
                }
            }
        }
    }
}
