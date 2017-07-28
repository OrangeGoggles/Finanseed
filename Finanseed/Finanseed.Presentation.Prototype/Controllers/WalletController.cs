using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finanseed.Presentation.Prototype.Controllers
{
    [Authorize]
    public class WalletController : Controller
    {
        // GET: Wallet
        public ActionResult Index()
        {
            return View();
        }

        // GET: Wallet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Wallet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wallet/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wallet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Wallet/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wallet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Wallet/Delete/5
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
