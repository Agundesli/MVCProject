using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class WriterController : Controller
    {
        // GET: Writer
        public ActionResult Index()
        {
            return View();
        }
        WritterManager writterManager = new WritterManager();
        public ActionResult GetWriterList()
        {
            var writervalues = writterManager.GetAll();

            return View(writervalues);
        }
        [HttpGet]// sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]// butona tıklandıgında alttaki metod çalışacak
        public ActionResult AddWriter(Writer writer)
        {
            writterManager.WriterAddBL(writer);
            return RedirectToAction("GetWriterList");
        }
    }
}