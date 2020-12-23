using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mvcWebapi.Models;
using mvcWebapi.UserDB;

namespace mvcWebapi.Controllers
{
    public class ApiUserController : ApiController
    {
        // GET: api/ApiUser
        public IEnumerable<Users> Get()
        {
            return UserD.userList;
        }

        // GET: api/ApiUser/5
        public IHttpActionResult Get(int id)
        {

            var usr = (UserD.userList.Where(m => m.Id == id)).FirstOrDefault();

            if (usr==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(usr);
            }
        }

        // POST: api/ApiUser
        [HttpPost]
        public IHttpActionResult Post([FromBody]Users newUser)
        {
            var userAd = newUser != null ? newUser.Ad : "";
            var userSoyad = newUser != null ? newUser.Soyad : "";
            var userMail = newUser != null ? newUser.Email : "";
            var  userRolAd= newUser != null ? newUser.rolAd : "";
            UserD.userList.Add(newUser);
            return Ok(userAd);
        }

        // PUT: api/ApiUser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiUser/5
        public void Delete(int id)
        {
        }
    }
}
    