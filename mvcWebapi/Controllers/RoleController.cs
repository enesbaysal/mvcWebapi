using mvcWebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcWebapi.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult RolesListe()
        {
            return View(RoleDB.RoleD.roleList);
        }



        // GET: Role/Create
        public ActionResult RolesCreate()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult RolesCreate(Roles newRole)
        {
            try
            {
                Roles nRol = new Roles()
                {

                    rolAdi = newRole.rolAdi
                };

                RoleDB.RoleD.roleList.Add(nRol);
                

                return RedirectToAction("RolesListe");
            }
            catch
            {
                return RedirectToAction("RolesListe");
            }
        }



        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Role/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
