﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAddBL(Category category);

        Category GetById(int Id);//Dışarıdan Id değişkenini alacağız
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
    }

}
