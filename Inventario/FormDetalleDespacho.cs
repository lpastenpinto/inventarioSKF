using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using System.Net;
using Inventario.Model;

namespace Inventario
{
    public partial class FormDetalleDespacho : Form
    {
        int idDespacho;
        string URLBASE;
        
        public FormDetalleDespacho(string URLBASE,int idDespacho)
        {
            InitializeComponent();
            this.idDespacho = idDespacho;
            this.URLBASE = URLBASE;
            cargarDetalle();
            
            //dataGridView1.Rows.Add(idDespacho.ToString());
            //MessageBox.Show(idDespacho.ToString());
        }

        private void FormDetalleDespacho_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarDetalle(){
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();           
            dynamic json = Despacho.getDespachoConDetalle(URLBASE, this.idDespacho);
            List<productos> detalleDespacho = new List<productos>();

            Despacho desp = new Despacho();
            
            dynamic jsonDespacho = json[0].Despacho;
            labelNombreCliente.Text = jsonDespacho.Cliente.nombreCliente;
            labelNombreDocumento.Text = jsonDespacho.NombreDocumento;
            labelCodigoCliente.Text = jsonDespacho.Cliente.codigoCliente; ;
            labelNumeroDocumento.Text = jsonDespacho.NumeroDocumento;
           
            foreach (dynamic dato in json)
            {
                //productos detTmp = new productos();
                //detTmp.DetalleDespachoID
                DetalleDespacho detDes = new DetalleDespacho();
                string DetalleDespachoID = dato.DetalleDespachoID;
                string productosID = dato.productosID;
                dataGridView1.Rows.Add(dato.productos.descripcion, dato.productos.codigo,dato.Cantidad);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool verif = true;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                try
                {
                    string campoEstado = dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
                catch (Exception) {                    
                        verif = false;                    
                }
                
            }

            if (verif)
            {
                
                string URI = URLBASE + "guardarDespachos";                
                string parameters = "idDespacho=" + this.idDespacho;
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string HtmlResult = wc.UploadString(URI, parameters);
                    if (HtmlResult.Equals("false"))
                    {
                        MessageBox.Show("Error al actualizar. Compruebe conexion a internet");
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else {
                MessageBox.Show("Debe verificar todos los productos");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("");
            dataGridView1.CurrentRow.Cells["Estado"].Value="Listo";
            //dataGridView1.Rows[e.RowIndex].Cells[].Value=""; 
            //idDespachoForm = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idDespacho"].FormattedValue.ToString());
            //AGREGAR
        }

        private void dataGridView1_KeyDown(object sender, KeyPressEventArgs e)
        {
            /*MessageBox.Show("sal");
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("mensaje dent");
            }*/
            /*if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("a");
            }*/
            MessageBox.Show("aa");
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Enter)
            {
                string codigoDataGrid = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                MessageBox.Show(codigoDataGrid);
                //e.Handled = true;
                //MessageBox.Show(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
            } 
            
        }

       

        
       

        
    }
}
