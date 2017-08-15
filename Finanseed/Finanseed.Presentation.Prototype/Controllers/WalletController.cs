using Finanseed.Presentation.Prototype.DAL.Interfaces;
using Finanseed.Presentation.Prototype.Models;
using Microsoft.AspNet.Identity;
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
        public IWalletRepository WalletRepository { get; set; }
        public WalletController(IWalletRepository walletRepository)
        {
            WalletRepository = walletRepository;
        }
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
            var wallet = WalletRepository.Add(new Wallet() { OwnerID = Guid.Parse(User.Identity.GetUserId()), CurrentBalance = 0, RealBalance = 0 });
            return RedirectToAction("Details",new { id = wallet.WalletID});
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
