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
    class sectores
    {
        public int sectoresID { get; set; }
        
        public int BodegaID { get; set; }
        
        public string nombre { get; set; }


        public static dynamic listSectores(string urlBase, int nombre) {
            //string urlBodegas = "http://localhost:58336/API/jsonListBodegaOrigen/" + nombre;

            urlBase = urlBase + "jsonListBodegaOrigen/" + nombre;
            string jsonString = "{}";

            WebClient http = new WebClient();
            JavaScriptSerializer js = new JavaScriptSerializer();
            http.Headers.Add(HttpRequestHeader.Accept, "application/json");
            jsonString = http.DownloadString(urlBase);


            dynamic json = JValue.Parse(jsonString).ToList();
            return json;
        }
    }
}
