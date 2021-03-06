using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        ContactManager contactManager = new ContactManager();
        public ActionResult GetContactList()
        {
            var contactvalues = contactManager.GetAll();

            return View(contactvalues);
        }
        [HttpGet]// sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]// butona tıklandıgında alttaki metod çalışacak
        public ActionResult AddContact(Contact contact)
        {
            contactManager.ContactAddBL(contact);
            return RedirectToAction("GetContactList");
        }
    }
}