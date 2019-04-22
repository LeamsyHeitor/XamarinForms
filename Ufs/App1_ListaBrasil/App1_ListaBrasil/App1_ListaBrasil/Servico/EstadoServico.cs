using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App1_ListaBrasil.Modelo;
using Newtonsoft.Json;

namespace App1_ListaBrasil.Servico
{
  public class EstadoServico
    {
        private static string URL = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";

        public List<Estado> GetEstados()
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(URL);

            return JsonConvert.DeserializeObject<List<Estado>>(conteudo);
        }
    }
}
