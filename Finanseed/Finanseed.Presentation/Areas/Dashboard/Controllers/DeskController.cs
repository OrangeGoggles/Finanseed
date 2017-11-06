using System.Web.Mvc;

namespace Finanseed.Presentation.Areas.Dashboard.Controllers
{
    [Authorize]
    public class DeskController : Controller
    {
        // GET: Dashboard/Desk
        public ActionResult Principal()
        {
            return View();
        }

        // GET: Dashboard/Desk/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dashboard/Desk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Desk/Create
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

        // GET: Dashboard/Desk/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dashboard/Desk/Edit/5
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

        // GET: Dashboard/Desk/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dashboard/Desk/Delete/5
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
