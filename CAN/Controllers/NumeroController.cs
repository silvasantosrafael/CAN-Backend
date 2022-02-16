using CAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace CAN.Controllers
{
    
    [RoutePrefix("api/")]
    public class NumeroController : ApiController
    {
     
        public void Post([FromBody] NumeroWaba value)
        {
            value.Insert();
        }

        public List<NumeroWaba> Get()
        {
            NumeroWaba listaNumero = new NumeroWaba();
            return listaNumero.SelectAll();
        }

        public List<NumeroWaba> Get(int id)
        {
            NumeroWaba listaNumeroid = new NumeroWaba();
            return listaNumeroid.Select(id);
        }

        public void Put([FromBody] NumeroWaba value)
        {
            value.Update();
        }

        public void Delete(int id)
        {
            NumeroWaba deletaNumero = new NumeroWaba(id);
            deletaNumero.Delete();
        }
    }
}
