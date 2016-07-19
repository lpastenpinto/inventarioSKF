using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using Inventario.Model;

namespace Inventario
{
    public partial class Form1 : Form
    {
        FormDetalleDespacho formDetalle;
        List<Bodega> bodegas;
        int idDespachoForm;
        string bodegaOrigen;
        public string URLBASE = "http://inventariopd.azurewebsites.net/API/";
        public Form1()
        {
            InitializeComponent();

            if (!comprobarConexionInternet())
            {
                MessageBox.Show("Imposible conectar a Internet. Compruebe conexion antes de abrir el software");
            }
            else {
                llenarBodegas();
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)comboBox1.SelectedItem;

            //MessageBox.Show(selectedPair.Key + "  " + selectedPair.Value);

            comboBoxSector.Items.Clear();

            dynamic sectorList = sectores.listSectores(URLBASE, selectedPair.Key);
            comboBoxSector.Items.Clear();
            comboBoxSector.DataSource = null;
            foreach (dynamic sect in sectorList)
            {
                comboBoxSector.Items.Add(sect);
            
            }

        }
      
        private void comboBoxSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxSector.SelectedItem.ToString();
            //MessageBox.Show(comboBoxSector.SelectedItem.ToString());
            /*dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            bodegaOrigen = comboBoxSector.SelectedItem.ToString();
           
            dynamic json = Despacho.getDespachoBogedaOrigenList(URLBASE, bodegaOrigen);
           

            foreach (dynamic dato in json)
            {

                dataGridView1.Rows.Add(dato.Cliente.codigoCliente,dato.NombreDocumento ,dato.NumeroDocumento, dato.Fecha, dato.Status,dato.DespachoID);

            }*/
            Loading formLoading = new Loading();
            formLoading.Show();
            llenarDespachos();
            formLoading.Close();
            
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          

            idDespachoForm = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idDespacho"].FormattedValue.ToString());
            //MessageBox.Show(idDespachoForm+"");
            formDetalle = new FormDetalleDespacho(URLBASE,idDespachoForm);
            formDetalle.Show();

        }

        private void llenarBodegas() {
            dynamic json = Bodega.getAllBodegas(URLBASE);
            List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            foreach (dynamic dato in json)
            {
              
                Bodega bodegaTemp = new Bodega();
                bodegaTemp.BodegaID = dato.BodegaID;
                bodegaTemp.ciudad = dato.ciudad;
                bodegaTemp.direccion = dato.direccion;
                bodegaTemp.nombre = dato.nombre;               
                data.Add(new KeyValuePair<int, string>(bodegaTemp.BodegaID, bodegaTemp.nombre));

            }
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            comboBox1.DataSource = new BindingSource(data, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void llenarDespachos() {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            bodegaOrigen = comboBoxSector.SelectedItem.ToString();
            ///*string urlBodegas = "http://localhost:58336/API/jsonDetalleDespacho/" + this.idDespacho;
            //string url = "http://localhost:58336/API/";
            dynamic json = Despacho.getDespachoBogedaOrigenList(URLBASE, bodegaOrigen);


            foreach (dynamic dato in json)
            {

                dataGridView1.Rows.Add(dato.Cliente.codigoCliente, dato.NombreDocumento, dato.NumeroDocumento, dato.Fecha, dato.Status, dato.DespachoID);

            }
        
        }

        private bool comprobarConexionInternet() { 
        
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;

            }
            catch (Exception es)
            {

                return false;
            }
        }
    }
}
