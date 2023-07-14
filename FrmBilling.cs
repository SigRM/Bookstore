using appLaboratorioMedico.Utilities;
using ProyectoV1.Entities;
using ProyectoV1.Services;
using ProyectoV1.Utilities.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV1.UI
{
    public partial class FrmBilling : Form
    {
        public static bool HayInstancia = false;
        public static FrmBilling InstanciaActiva = null;
        Utiles utiles = new Utiles();  //Se crea una instancia a utilitarios
        LeerDatos leerDatos = new LeerDatos();
        List<Payment> paymentList = new List<Payment>(); //Se crea una instancia a la clase clientes como tipo lista
        private ErrorProvider oErrorProvider = new ErrorProvider();
        public FrmBilling()
        {
            InitializeComponent();
        }


        private void FrmBilling_Load(object sender, EventArgs e)
        {
            dtpInicial.Value = DateTime.Now;
            dtpFinal.Value = DateTime.Now;
            rdbCompra.Checked = false;
            rdbVenta.Checked = true;

            txtPaymentID.Focus();  //Coloca el accionar del focus en el control textbox de la cedula
            HayInstancia = true; //Definición de variables para la instancia de carga de pantalla
            InstanciaActiva = this;
            paymentList.Clear(); //Limpiamos los datos
            errorProvider1.Clear();

            try
            {
                //Consulta si el archivo clientes.txt no existe 
                if (!File.Exists("payment.txt"))
                {
                    StreamWriter archivo = new StreamWriter("payment.txt");//En caso de no existir lo crea
                    archivo.Close();//Cierra el archivo
                }
                else
                {
                    StreamReader archivo = new StreamReader("payment.txt");//Hace lectura del archivo plano
                    while (!archivo.EndOfStream) //Recorre el archivo
                    {
                        String datos = archivo.ReadLine();//Recorre los registros (cedula, nombre,edad, correo electrónico)
                        String[] registros = datos.Split(';');//Se realiza un split de los datos obtenidos
                        Payment cli = new Payment();//Se crea instancia de clientes
                        cli.payment_id = int.Parse(registros[0].ToString());//Se asignan los valores a la instancia
                        cli.order_id = int.Parse(registros[1].ToString());
                        cli.payment_method_id = int.Parse(registros[2].ToString());
                        cli.amount = decimal.Parse(registros[3].ToString());
                        cli.exchange_rate = decimal.Parse(registros[4].ToString());
                        paymentList.Add(cli);//Se le agrega a la lista la instancia creada
                        //Formas de cargar un grid
                        //1- Por medio de agregacion
                        dgvPayment.Rows.Add(cli.payment_id, cli.order_id, cli.payment_method_id, cli.amount, cli.exchange_rate); //Agrega los datos en el grid view
                    }
                    archivo.Close();//Cierra el archivo
                    //2- Por medio del Dataset según una lista, para utilizar esta opcion se recomienda que no tenga columnas creadas
                    //var listaGrid = clientesList;
                    //dgvDatos.AutoGenerateColumns = true;
                    //dgvDatos.DataSource = listaGrid;
                }
                limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string compraOVenta = "";
            if (this.rdbCompra.Checked)
            {
                compraOVenta = "c";
            }
            else
            {
                compraOVenta = "v";
            }
            ServiceBCCR services = new ServiceBCCR();
            dgvTipoCambio.DataSource = services.GetDolar(this.dtpInicial.Value, this.dtpFinal.Value, compraOVenta);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = paymentList.Exists(x => x.payment_id.ToString() == txtPaymentID.Text.ToString());//Validamos si existe en la lista
                if (resultado)
                {
                    MessageBox.Show("The ID  " + txtPaymentID.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtPaymentID.Text.ToString() == string.Empty)
                {//Si el campo txtCedula está vacio
                    errorProvider1.SetError(txtPaymentID, "Obligatory field"); //En caso de que estuviese vacío activa el control error provider
                    return; //regresa a pantalla
                }

                //Antes de grabar validamos los datos
                // Validar Cedula
                if (string.IsNullOrEmpty(FormatStrings.GetDNINoFormat(this.txtPaymentID.Text)))
                {
                    errorProvider1.SetError(this.txtPaymentID, "ID number incorrect");
                    return;
                }

                // Validar Correo
                if (!LeerDatos.Es_Email(this.txtEmail))
                {
                    errorProvider1.SetError(this.txtEmail, "Email information is incorrect");
                    return;
                }



                grabarArchivo(); //Graba el archivo
                //Se muestra dato en el grid view
                this.dgvPayment.Rows.Add(txtPaymentID.Text, txtOrderID.Text,txtPaymentMethod.Text, txtAmount.Text, txtExchangeRate.Text); //Agrega los valores de cedula, nombre y edad
                //this.FrmBilling(null, null);

                //Limpia los archivos
                // limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        public void limpirDatos()
        {
            txtPaymentID.Clear();
            txtOrderID.Clear();
            txtPaymentMethod.Clear();
            txtAmount.Clear();
            txtExchangeRate.Clear();
            txtIdPromotion.Clear(); //Acciona el cursor al control del textbox cedula
            txtPaymentID.Focus();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void grabarArchivo()
        {
            try
            {
                dgvPayment.DataSource = null;  //Limpiar el datagrid
                dgvPayment.Rows.Clear();//Limpiar el datagrid

                StreamWriter archivo = new StreamWriter("Payment.txt", true); //Abre el archivo y agrega el append del mismo


                archivo.WriteLine(txtPaymentID.Text + ";" + txtOrderID.Text.ToString().ToUpper() + ";" + txtPaymentMethod.Text.ToString().ToUpper() + ";" + txtAmount.Text.ToString().ToUpper()+ txtExchangeRate.Text.ToString().ToUpper() + ";" +txtIdPromotion.Text.ToString().ToLower());//Se agregan al registro
                archivo.Close(); //Cierra el archivo
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPaymentID.Text.Equals(""))
                {
                    bool resultado = paymentList.Exists(x => x.payment_id.ToString() == txtPaymentID.Text.ToString());//Validamos si existe en la lista
                    //Utilizando LinQ se consulta si existe el valor a borrar
                    if (resultado)
                    {
                        for (int i = 0; i < dgvPayment.Rows.Count; i++)//Se recorre el contenido de todas las filas del grid menos 1 dado a que el grid mantiene la linea de carga activa si se elimina la opción de agregar linea en el grid entonces se procede a quitar el menos 1
                        {
                            if (txtPaymentID.Text == dgvPayment.Rows[i].Cells[0].Value.ToString())
                            {//Si el dato de la cedula indicado es igual al valor que apunta la fila en la columna 0= Cedula
                                dgvPayment.Rows.RemoveAt(i); //Elimina la línea del grid que está apuntando
                                GrabarBorrado(); //Realiza proceso de eliminado del archivo
                                MessageBox.Show("Registration deleted sucessfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra mensaje
                            }
                        }
                        //  this.FrmCustomers_Load(null, null);//Hacemos instancia del load
                    }
                }
                else
                {
                    errorProvider1.SetError(txtPaymentID, "Obligatory field");
                }
                limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrabarBorrado()
        {
            try
            {
                dgvPayment.DataSource = null;  //Limpiar el datagrid
                dgvPayment.Rows.Clear();//Limpiar el datagrid

                File.WriteAllText("customers.txt", "");
                StreamWriter archivo = new StreamWriter("customers.txt", true);//Realiza lectura del archivo y permite agregar datos (append)
                                                                               

                //Utilizando LinQ
                List<Payment> lista = paymentList.Where(x => x.ToString() != txtPaymentID.Text).ToList();//Obtenemos la lista de todos los registros donde la cedula sea diferente a lo que tiene la cedula del campo textCedula
                foreach (var item in lista)//Se recorre la lista de datos
                {
                    archivo.WriteLine(item.payment_id.ToString() + ";" + item.order_id.ToString().ToUpper() + ";" + item.payment_method_id.ToString().ToUpper() + ";" + item.amount.ToString().ToUpper() + ";" + item.exchange_rate.ToString().ToUpper() + ";");//Se agregan al registro
                }
                archivo.Close();// Se cierra el registro
                paymentList.Clear();
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBilling_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se inactivan las variables creadas
            HayInstancia = false;
            InstanciaActiva = null;
        }

        private void dgvPayment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvPayment.Rows.Count; i++) //Realiza recorrido de filas (validar si tiene el habilitar agregar filas para dejar o eliminar el -1)
                {
                    txtPaymentID.Text = this.dgvPayment.CurrentRow.Cells[0].Value.ToString();//Muestra los datos de la fila seleccionada y lo coloca en el campo Cedula
                    txtOrderID.Text = this.dgvPayment.CurrentRow.Cells[1].Value.ToString().ToUpper();
                    txtPaymentMethod.Text = this.dgvPayment.CurrentRow.Cells[2].Value.ToString().ToUpper();
                    txtAmount.Text = this.dgvPayment.CurrentRow.Cells[3].Value.ToString().ToUpper();
                    txtExchangeRate.Text = (this.dgvPayment.CurrentRow.Cells[4].Value.ToString().ToLower());
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnEmail_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Si txtCedula es diferente de vacio envia correo
                if (!txtPaymentID.Equals(""))
                {

                    //Construye los datos en una tabla por medio de HTML
                    String mensaje = "";
                    //Se crea una tabla algunos datos importantes para tomar en cuenta
                    //<tr>  definir una fila | <th> define un encabezado | <td> define una celda </tr> Cierre de fila | </th> Cierre de Encabezado  | </td>  Cierre de Celda  | <br>  Salto
                    mensaje += "<table width=100% border=1 cellpadding=0 cellspacing=0>";
                    //Se define una fila con una columna que dice UTN Ingreso
                    mensaje += "<tr><td bgcolor=#004080 style='color:white; padding:4px;' width=40%><strong><div align=center>Magic Book Library</div></strong></td>";
                    //Se define una columna con estilo de color que indica mensaje
                    mensaje += "<td style='padding:4px;'>Magic Book Library Receipt.</td></tr>";
                    mensaje += "</table><br>"; //Cierre de tabla y realiza un saldo

                    //Creación de otra tabla 
                    mensaje += "<table width=100% border=1 cellpadding=0 cellspacing=0>";
                    //Creacion de fila y se agrega un encabezado con los datos de ESTOS SON SUS DATOS
                    mensaje += "<tr><th colspan=6 style='padding:4px;'>This is your information</th></tr>";
                    //CREACION DE FILA NUEVO
                    mensaje += "<tr>";
                    //CREACION DE CELDA CON EL TITULO CEDULA    "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>PAYMENTID</div></th>";
                    //CREACION DE CELDA CON EL TIUTLO DE NOMBRE    "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>ORDERID</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>PAYMENTMETHOD</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>AMOUNT</div></th>";
                    //CREACION DE CELDA CON TITULO DE EDAD   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>EXCHANGERATE</div></th>";
                    //fIN DE FILA CREADA
                    mensaje += "</tr>";
                    //CRAECION DE NUEVA FILA
                    mensaje += "<tr>";
                    //SE AGREGAN LOS VALORES EN CELDAS NUEVAS CONSTRUYENDO EL STRING
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtPaymentID.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtOrderID.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtPaymentMethod.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtAmount.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtExchangeRate.Text);

                    mensaje += "</tr>";
                    //FIN DE CREACION DE TABLA
                    mensaje += "</table>";


                    String asunto = "New Receipt Included";
                    //String ruta = Path.GetFullPath(@"..\..\Instrucciones\Practica_Leccion02.pdf");
                    String ruta = "";
                    String adjunto = ruta;
                    String receptor = txtEmail.Text;
                    EnviarCorreo envioCorreo = new EnviarCorreo();
                    envioCorreo.enviarCorreoGmail(mensaje.ToString(), receptor, asunto, adjunto);

                }
                else
                {
                    MessageBox.Show("Email cannot be send", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
