using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabSatrack.Api.Models
{
    public class Alarma
    {
     
        public string Id { get; set; }
        [JsonProperty("Status")]
        public bool Estado { get; set; }
        [JsonProperty("Description")]
        public string  Descripcion { get; set; }
        [JsonProperty("Event")]
        public string Evento { get; set; }
    }
}