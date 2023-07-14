using Entidades;
using ProyectoV1.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV1
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void qRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQRPromotion frmQR = new FrmQRPromotion();
            frmQR.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBooks frmbooks = new FrmBooks();
            frmbooks.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCx = new FrmCustomers();
            frmCx.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmployees frmemployee = new FrmEmployees();
            frmemployee.Show();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            int valorLogin = 0;
            string usuarioDato = "";
            string claveDato = "";

            FrmLogIn ofrmLoging = new FrmLogIn(valorLogin, usuarioDato, claveDato);
            try
            {
                ofrmLoging.ShowDialog(this);
                if (ofrmLoging.DialogResult == DialogResult.Abort || ofrmLoging.DialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                this.Text = string.Format("{0} {1}", Application.ProductName, Application.ProductVersion);
                //validar el tipo de seguridad reportada
                Seguridad();

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Seguridad()
        {
            LogIn oUsuario = LogIn.GetInstance();
            string nombre = oUsuario.Identificacion;
            string clave = oUsuario.contrasena;
            string rol = oUsuario.rol;

            string nombreRol = "";
            if (oUsuario.rol.ToString() == "1")
            {
                nombreRol = "CUSTOMER";
            }
            else if (oUsuario.rol.ToString() == "2")
            {
                nombreRol = "EMPLOYEE";
            }
            else
            {
                nombreRol = "ADMINISTRATOR";
            }

            string persona = "Sigrid Rojas Murillo";

            this.Text = "Magic Book Store  -- Welcome! " + persona + " Rol: " + nombreRol;
         //   Utilities.Utiles.hablar(100, 0, this.Text);

            List<string> menus = new List<string>(); //Customer
            List<string> menus1 = new List<string>();//Employee
            List<string> menus2 = new List<string>();//Administrator



            //si el usuario es de tipo Administrator
            menus.Add("processesToolStripMenuItem"); //Tareas
            menus.Add("maintenanceToolStripMenuItem"); //acerca de
            menus.Add("aboutToolStripMenuItem");
            menus.Add("ExitToolStripMenuItem"); //Salir

            //si el usuario es de tipo Employee
            menus1.Add("reportsToolStripMenuItem"); //Tareas
            menus1.Add("maintenanceToolStripMenuItem"); //acerca de
            menus1.Add("ExitToolStripMenuItem"); //Salir

            //si el usuario es de tipo Customer
            menus2.Add("reportsToolStripMenuItem"); //acerca de
            menus2.Add("maintenanceToolStripMenuItem");//Actividades
            menus2.Add("ExitToolStripMenuItem"); //Salir

            if (rol != null && !rol.ToString().Trim().ToUpper().Equals(""))
            {
                if (rol.ToString().ToUpper() == "ADMINISTRATOR")
                {
                    //Deshabilitar todas las opciones del menú
                    foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                    {
                        ((ToolStripMenuItem)(opcionMenu)).Enabled = false;
                    }

                    foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                    {
                        opcionMenu.Enabled = menus.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                    }
                }
                else
                {
                    if (rol.ToString().ToUpper() == "EMPLOYEE")
                    {
                        //Deshabilitar todas las opciones del menú
                        foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                        {
                            //((ToolStripMenuItem)(opcionMenu)).Enabled = false;
                            ((ToolStripMenuItem)(opcionMenu)).Visible = false;
                        }

                        foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                        {
                            //opcionMenu.Enabled = menus1.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                            opcionMenu.Visible = menus1.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                        }
                    }//END EMPLOYEE
                    else
                    {
                        //Deshabilitar todas las opciones del menú
                        foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                        {
                            ((ToolStripMenuItem)(opcionMenu)).Enabled = false;
                        }

                        foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                        {
                            opcionMenu.Enabled = menus2.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                        }
                    }//END
                }
            }
        }

        private void promotionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPromotions frm = new FrmPromotions();
            frm.Show();

        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
        }


    }
    }

