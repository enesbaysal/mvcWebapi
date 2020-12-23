using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mvcWebapi.Models;
using mvcWebapi.RoleDB;

namespace mvcWebapi.Controllers
{
    public class ApiRoleController : ApiController
    {
        // GET: api/ApiRole
        public IEnumerable<Roles> Get()
        {
            return RoleD.roleList;
        }

        // GET: api/ApiRole/5
        public IHttpActionResult Get(int id)
        {
            var rl = (RoleD.roleList.Where(m => m.Id == id)).FirstOrDefault();

            if (rl == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(rl);
            }
        }

        // POST: api/ApiRole
        [HttpPost]
        public IHttpActionResult Post([FromBody]Roles newRole)
        {
            var rolAd = newRole != null ? newRole.rolAdi : "";

            RoleD.roleList.Add(newRole);
            return Ok(rolAd);
        }

        // PUT: api/ApiRole/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiRole/5
        public void Delete(int id)
        {
        }
    }
}
