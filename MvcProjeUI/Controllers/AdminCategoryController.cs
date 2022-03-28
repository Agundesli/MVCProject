using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFarmework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategoryController
        public ActionResult Index()
        {
            return View();
        }
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        public ActionResult GetCategoryList()
        {
            var categoryvalues = categoryManager.GetList();

            return View(categoryvalues);
        }
        [HttpGet]// sayfa ilk yüklendiğinde alttaki metod çalışacak
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]// butona tıklandıgında alttaki metod çalışacak
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);

            if (result.IsValid)
            {
                categoryManager.CategoryAddBL(category);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int Id)
        {
            var categoryvalues = categoryManager.GetById(Id);
            categoryManager.CategoryDelete(categoryvalues);
            return RedirectToAction("GetCategoryList");
        }
    }
}