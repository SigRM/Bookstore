using appLaboratorioMedico.Utilities;
using ProyectoV1.Entities;
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
    public partial class FrmPromotions : Form
    {
        public static bool HayInstancia = false;
        public static FrmPromotions InstanciaActiva = null;
        Utiles utiles = new Utiles();  //Se crea una instancia a utilitarios
        LeerDatos leerDatos = new LeerDatos();
        List<Promotions> promotionList = new List<Promotions>(); //Se crea una instancia a la clase clientes como tipo lista
        private ErrorProvider oErrorProvider = new ErrorProvider();

        public FrmPromotions()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            ExportarGrid exportar = new ExportarGrid();
            exportar.ExportarPDF2(dataGridView1, "NewPromotion");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtID.Text.Equals(""))
                {
                    bool resultado = promotionList.Exists(x => x.promotion_id.ToString() == txtID.Text.ToString());//Validamos si existe en la lista
                    //Utilizando LinQ se consulta si existe el valor a borrar
                    if (resultado)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)//Se recorre el contenido de todas las filas del grid menos 1 dado a que el grid mantiene la linea de carga activa si se elimina la opción de agregar linea en el grid entonces se procede a quitar el menos 1
                        {
                            if (txtID.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                            {//Si el dato de la cedula indicado es igual al valor que apunta la fila en la columna 0= Cedula
                                dataGridView1.Rows.RemoveAt(i); //Elimina la línea del grid que está apuntando
                                GrabarBorrado(); //Realiza proceso de eliminado del archivo
                                MessageBox.Show("Registro eliminado correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra mensaje
                            }
                        }
                        this.FrmPromotions_Load(null, null);//Hacemos instancia del load
                    }
                }
                else
                {
                    errorProvider1.SetError(txtID, "Obligatory field");
                }
                limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpirDatos()
        {
            txtID.Clear();
            txtName.Clear();
            txtDiscount.Clear();
            txtID.Focus(); //Acciona el cursor al control del textbox cedula
        }

        private void GrabarBorrado()
        {
            try
            {
                dataGridView1.DataSource = null;  //Limpiar el datagrid
                dataGridView1.Rows.Clear();//Limpiar el datagrid

                File.WriteAllText("clientes.txt", "");
                StreamWriter archivo = new StreamWriter("clientes.txt", true);//Realiza lectura del archivo y permite agregar datos (append)
                                                                              //Proceso para recorrer lo contenido en el grid
                                                                              //for (int i = 0; i < dgvDatos.Rows.Count; i++) //Realiza recorrido de filas (validar si tiene el habilitar agregar filas para dejar o eliminar el -1)
                                                                              //{
                                                                              //    archivo.WriteLine(dgvDatos.Rows[i].Cells[0].Value.ToString()); //Escribe en el archivo según apunte la fila y la columna correspondiente
                                                                              //    archivo.WriteLine(dgvDatos.Rows[i].Cells[1].Value.ToString());
                                                                              //    archivo.WriteLine(dgvDatos.Rows[i].Cells[2].Value.ToString());
                                                                              //}

                //Utilizando LinQ
                List<Promotions> lista = promotionList.Where(x => x.promotion_id.ToString() != txtID.Text).ToList();//Obtenemos la lista de todos los registros donde la cedula sea diferente a lo que tiene la cedula del campo textCedula
                foreach (var item in lista)//Se recorre la lista de datos
                {
                    archivo.WriteLine(item.promotion_id.ToString() + ";" + item.promotion_name.ToString().ToUpper() + ";" + item.discount.ToString().ToLower());//Se agregan al registro
                }
                archivo.Close();// Se cierra el registro
                promotionList.Clear();
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que permite guardar la información en el archivo clientes.txt
        /// </summary>
        private void grabarArchivo()
        {
            try
            {
                dataGridView1.DataSource = null;  //Limpiar el datagrid
                dataGridView1.Rows.Clear();//Limpiar el datagrid

                StreamWriter archivo = new StreamWriter("clientes.txt", true); //Abre el archivo y agrega el append del mismo


                archivo.WriteLine(txtID.Text + ";" + txtName.Text.ToString().ToUpper() + ";" + txtDiscount.Text.ToString().ToLower());//Se agregan al registro
                archivo.Close(); //Cierra el archivo
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPromotions_Load(object sender, EventArgs e)
        {
            txtID.Focus();  //Coloca el accionar del focus en el control textbox de la cedula
            HayInstancia = true; //Definición de variables para la instancia de carga de pantalla
            InstanciaActiva = this;
            promotionList.Clear(); //Limpiamos los datos
            errorProvider1.Clear();

            try
            {
                //Consulta si el archivo clientes.txt no existe 
                if (!File.Exists("promotions.txt"))
                {
                    StreamWriter archivo = new StreamWriter("promotions.txt");//En caso de no existir lo crea
                    archivo.Close();//Cierra el archivo
                }
                else
                {
                    StreamReader archivo = new StreamReader("promotions.txt");//Hace lectura del archivo plano
                    while (!archivo.EndOfStream) //Recorre el archivo
                    {
                        String datos = archivo.ReadLine();//Recorre los registros (cedula, nombre,edad, correo electrónico)
                        String[] registros = datos.Split(';');//Se realiza un split de los datos obtenidos
                        Promotions cli = new Promotions();//Se crea instancia de clientes
                        cli.promotion_id = int.Parse(registros[0].ToString());//Se asignan los valores a la instancia
                        cli.promotion_name = registros[1];
                        cli.discount = decimal.Parse(registros[2].ToString());
                        cli.start_discount_date = DateTime.Parse(registros[3].ToString());
                        cli.end_discount_date = DateTime.Parse(registros[4].ToString());
                        promotionList.Add(cli);//Se le agrega a la lista la instancia creada
                        //Formas de cargar un grid
                        //1- Por medio de agregacion
                        dataGridView1.Rows.Add(cli.promotion_id, cli.promotion_name, cli.discount, cli.start_discount_date, cli.end_discount_date); //Agrega los datos en el grid view
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

        private void FrmPromotions_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se inactivan las variables creadas
            HayInstancia = false;
            InstanciaActiva = null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) //Realiza recorrido de filas (validar si tiene el habilitar agregar filas para dejar o eliminar el -1)
                {
                    txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();//Muestra los datos de la fila seleccionada y lo coloca en el campo Cedula
                    txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString().ToUpper();
                    txtDiscount.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString().ToUpper();
                    datetimeStarDate.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString().ToUpper();
                    datetimeEndDate.Text = (this.dataGridView1.CurrentRow.Cells[4].Value.ToString().ToLower());
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = promotionList.Exists(x => x.promotion_id.ToString() == txtID.Text.ToString());//Validamos si existe en la lista
                if (resultado)
                {
                    MessageBox.Show("The ID  " + txtID.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtID.Text.ToString() == string.Empty)
                {//Si el campo txtCedula está vacio
                    errorProvider1.SetError(txtID, "Obligatory field"); //En caso de que estuviese vacío activa el control error provider
                    return; //regresa a pantalla
                }

                //Antes de grabar validamos los datos
                // Validar Cedula
                if (string.IsNullOrEmpty(FormatStrings.GetDNINoFormat(this.txtID.Text)))
                {
                    errorProvider1.SetError(this.txtID, "ID number incorrect");
                    return;
                }

                // Validar Nombre
                if (!LeerDatos.Es_Cadena(this.txtName))
                {
                    errorProvider1.SetError(this.txtName, "Name with the wrong format");
                    return;
                }



                grabarArchivo(); //Graba el archivo
                //Se muestra dato en el grid view
                this.dataGridView1.Rows.Add(txtID.Text, txtName.Text, txtDiscount.Text,datetimeStarDate.Text, datetimeEndDate.Text); //Agrega los valores de cedula, nombre y edad
                this.FrmPromotions_Load(null, null);

                //Limpia los archivos
                // limpirDatos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
