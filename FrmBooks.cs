using ProyectoV1.Entities;
using ProyectoV1.Files;
using ProyectoV1.Interfaces;
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
    public partial class FrmBooks : Form
    {
        public FrmBooks()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            try
            {
                if (cmbFile.SelectedItem != null)
                {
                    var path = (IBookMaintenance)cmbFile.SelectedItem;
                    dgvBooksMaintenance.DataSource = path.GetTheBook();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {
            cmbFile.Items.Add(new FileXMLBook());
            cmbFile.Items.Add(new FileJsonBook());
            cmbFile.SelectedIndex = 0;
        }

        private void cmbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Books book = new Books()
                {
                    author = txtAuthor.Text,
                    title = txtTitle.Text,
                    price = int.Parse(txtPrice.Text),

                };

                var path = cmbFile.SelectedItem as IBookMaintenance;
                path.Add(book);

                Reload();
                MessageBox.Show("Book saved sucessfully!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opppppps. Warning: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtPrice.Clear();
            txtTitle.Clear();

        }
    }
}
