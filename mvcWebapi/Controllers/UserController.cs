using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcWebapi.Models;




namespace mvcWebapi.Controllers
{
    public class UserController : Controller
    {
       


        // GET: User
        public ActionResult UsersListe()
        {
            return View(UserDB.UserD.userList);
        }

        

        // GET: User/Create
        public ActionResult UsersCreate()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult UsersCreate(Users newUser)
        {
            try
            {
               Users nUser = new Users()

                {
                    
                    Ad=newUser.Ad,
                    Soyad=newUser.Soyad,
                    Email=newUser.Email,
                    rolAd=newUser.rolAd

                };
                UserDB.UserD.userList.Add(nUser);

                return RedirectToAction("UsersListe");
            }
            catch
            {
                return RedirectToAction("UsersListe");
            }
        }


        // GET: User/Delete/5
        public ActionResult UsersDelete(int? id)
        {
            //Users aa = UserDB.UserD.userList.Where(m => m.Id == id).SingleOrDefault();
            //UserDB.UserD.userList.Remove(aa);



            //var sil = UserDB.UserD.userList.Where(m => m.Id == id).SingleOrDefault();

            //UserDB.UserD.userList.Remove(sil);



            return RedirectToAction("Index");


      
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
