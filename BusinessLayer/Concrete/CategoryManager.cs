using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        //Id ye karşılık geleni siler
        public Category GetById(int Id)
        {
            return _categoryDal.Get(x => x.CategoryId == Id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //public List<Category> GetAll()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length < 3  || p.CategoryDescription == "") 
        //    {
        //        Console.WriteLine("Hata");
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

    }
}
