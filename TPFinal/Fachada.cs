using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TPFinal
{
    public class Fachada
    {
         Usuario Login(string DNI,string PIN)
        {
            var mUrl = ("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/clients?id="+DNI+"&pass="+PIN);

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

                // Se ejecuta la consulta
                WebResponse mResponse = mRequest.GetResponse();

                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    if (mResponseJSON.Count >= 1)
                    {
                        string iNombre= mResponseJSON[0].response.client.name;
                        string iCategoria= mResponseJSON[0].response.client.segment;
                        return new Usuario(iNombre, iCategoria);
                    }
                    else
                    {
                        return null;
                    }
                }
            
        
    }
    }
}
