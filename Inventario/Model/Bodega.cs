using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using Inventario.Model;
using System.Net;

namespace Inventario.Model
{
    public class Bodega
    {        
        public int BodegaID { get; set; }        
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }

        public static dynamic getAllBodegas(string urlBodegas)
        {

            //string urlBodegas = "http://localhost:58336/API/Bodegas";

            string jsonString = "{}";
            urlBodegas = urlBodegas + "Bodegas";

            WebClient http = new WebClient();
            JavaScriptSerializer js = new JavaScriptSerializer();
            http.Headers.Add(HttpRequestHeader.Accept, "application/json");
            jsonString = http.DownloadString(urlBodegas);

            dynamic json = JValue.Parse(jsonString).ToList();
            return json;
        }
    }
}
