using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hackathon.DomainModel;
using Hackathon.Models;

namespace Hackathon.Controllers
{   
    public class SalesController : Controller
    {
		private readonly ISaleRepository saleRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public SalesController() : this(new saleRepository())
        {
        }

        public SalesController(ISaleRepository saleRepository)
        {
			this.saleRepository = saleRepository;
        }

        //
        // GET: /sales/

        public ViewResult Index(string strap)
        {

            var result = saleRepository.Search(strap);

            return View(result);
        }

        //
        // GET: /sales/Details/5

        public ViewResult Details(int id)
        {
            return View(saleRepository.Find(id));
        }

        //
        // GET: /sales/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /sales/Create

        [HttpPost]
        public ActionResult Create(sale sale)
        {
            if (ModelState.IsValid) {
                saleRepository.InsertOrUpdate(sale);
                saleRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /sales/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(saleRepository.Find(id));
        }

        //
        // POST: /sales/Edit/5

        [HttpPost]
        public ActionResult Edit(sale sale)
        {
            if (ModelState.IsValid) {
                saleRepository.InsertOrUpdate(sale);
                saleRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /sales/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(saleRepository.Find(id));
        }

        //
        // POST: /sales/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            saleRepository.Delete(id);
            saleRepository.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                saleRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

