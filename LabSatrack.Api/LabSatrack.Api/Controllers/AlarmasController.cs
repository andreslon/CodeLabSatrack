using LabSatrack.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LabSatrack.Api.Controllers
{
    public class AlarmasController : ApiController
    {
        // GET: api/Alarmas
        public List<Alarma> Get()
        {
            var alarmas = new List<Alarma>();

            alarmas.Add(new Alarma { Id= Guid.NewGuid().ToString(), Descripcion= "Descripcion", Estado= true, Evento= "Evento" });
            alarmas.Add(new Alarma { Id = Guid.NewGuid().ToString(), Descripcion = "Descripcion", Estado = true, Evento = "Evento" });
            alarmas.Add(new Alarma { Id = Guid.NewGuid().ToString(), Descripcion = "Descripcion", Estado = true, Evento = "Evento" });
            alarmas.Add(new Alarma { Id = Guid.NewGuid().ToString(), Descripcion = "Descripcion", Estado = true, Evento = "Evento" });
            alarmas.Add(new Alarma { Id = Guid.NewGuid().ToString(), Descripcion = "Descripcion", Estado = true, Evento = "Evento" });
            alarmas.Add(new Alarma { Id = Guid.NewGuid().ToString(), Descripcion = "Descripcion", Estado = true, Evento = "Evento" });
            alarmas.Add(new Alarma { Id = Guid.NewGuid().ToString(), Descripcion = "Descripcion", Estado = true, Evento = "Evento" });
            alarmas.Add(new Alarma { Id = Guid.NewGuid().ToString(), Descripcion = "Descripcion", Estado = true, Evento = "Evento" });
            return alarmas;
        }

        // GET: api/Alarmas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Alarmas
        public void Post([FromBody]Alarma value)
        {
        }

        // PUT: api/Alarmas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Alarmas/5
        public void Delete(int id)
        {
        }
    }
}
