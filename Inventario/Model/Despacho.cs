using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Inventario.Model;
using System.Net;
using System.Web.Script.Serialization;

namespace Inventario.Model
{
    class Despacho
    {
        
        public int DespachoID { get; set; }        
        public string NombreDocumento { get; set; }        
        public int NumeroDocumento { get; set; }
        public int ClienteID { get; set; }        
        public string DireccionDespacho { get; set; }
        public int BodegaID { get; set; }
        public DateTime Fecha { get; set; }      
        public string BodegaOrigen { get; set; }
        public int Linea { get; set; }        
        public string Status { get; set; }
        public Bodega Bodega { get; set; }
        public Cliente Cliente { get; set; }

        public static dynamic getDespachoBogedaOrigenList(string urlBase,string bodegaOrigen){

            //string urlBodegas = "http://localhost:58336/API/jsonDespachoPorBodegaOrigen/" + bodegaOrigen;
            urlBase=urlBase+"jsonDespachoPorBodegaOrigen/" + bodegaOrigen;
            string jsonString = "{}";


            WebClient http = new WebClient();
            JavaScriptSerializer js = new JavaScriptSerializer();
            http.Headers.Add(HttpRequestHeader.Accept, "application/json");
            jsonString = http.DownloadString(urlBase);


            dynamic json = JValue.Parse(jsonString).ToList();
            return json;

        }

        public static dynamic getDespachoConDetalle(string urlBase,int idDespacho) {
            //string urlBodegas = "http://localhost:58336/API/jsonDetalleDespacho/" + this.idDespacho;
            urlBase = urlBase + "jsonDetalleDespacho/" + idDespacho;
            string jsonString = "{}";


            WebClient http = new WebClient();
            JavaScriptSerializer js = new JavaScriptSerializer();
            http.Headers.Add(HttpRequestHeader.Accept, "application/json");
            jsonString = http.DownloadString(urlBase);

            //dynamic jsonInicial = JValue.Parse(jsonString);
            dynamic json = JValue.Parse(jsonString).ToList();
            return json;
        }
    }
}
