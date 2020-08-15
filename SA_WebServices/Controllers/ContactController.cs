using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SA_WebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public ContactController() { }
        //GET: api/contact/list
        [HttpGet]
        [Route("list")]
        public string Lista()
        {

            ServiceReference1.administratorcontact100Client ws = new ServiceReference1.administratorcontact100Client();
            Task<ServiceReference1.readListResponse> task = ws.readListAsync(0,0,null,null,null,null,null);
            return "True" ;
        }

        //GET: api/contact/add
        [HttpGet]
        [Route("add")]
        public string Crear()
        {

            ServiceReference1.administratorcontact100Client ws = new ServiceReference1.administratorcontact100Client();
            ws.createAsync("",0,"",0);
            return "True";
        }
    }
}
