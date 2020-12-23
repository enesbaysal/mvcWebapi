using mvcWebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcWebapi.UserDB
{
    public class UserD
    {
        public static List<Users> userList = new List<Users>()
        {

            new Users
            {
                Id = 1,
                Ad = "Enes",
                Soyad = "Baysal",
                Email="baysal@gmail.com",
                rolAd = RoleDB.RoleD.roleList[0].rolAdi                 

            }

        };
    }
}