using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hackathon.DomainModel;
using Hackathon.Models;

namespace Hackathon.Controllers
{   
    public class NalsController : Controller
    {
		private readonly INalRepository nalRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public NalsController() : this(new nalRepository())
        {
        }

        public NalsController(INalRepository nalRepository)
        {
			this.nalRepository = nalRepository;
        }

        //
        // GET: /nals/

        public ViewResult Index()
        {
            return View(nalRepository.All);
        }

        //
        // GET: /nals/Details/5

        public ViewResult Details(int id)
        {
            return View(nalRepository.Find(id));
        }
        [HttpGet]
        public ViewResult Search()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Search(string owner1 = "", string m_addr_1 = "")
        {
            return View("SearchResult", nalRepository.Search(owner1, m_addr_1));
        }

        //
        // GET: /nals/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /nals/Create

        [HttpPost]
        public ActionResult Create(nal nal)
        {
            if (ModelState.IsValid) {
                nalRepository.InsertOrUpdate(nal);
                nalRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /nals/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(nalRepository.Find(id));
        }

        //
        // POST: /nals/Edit/5

        [HttpPost]
        public ActionResult Edit(nal nal)
        {
            if (ModelState.IsValid) {
                nalRepository.InsertOrUpdate(nal);
                nalRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /nals/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(nalRepository.Find(id));
        }

        //
        // POST: /nals/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            nalRepository.Delete(id);
            nalRepository.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                nalRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

