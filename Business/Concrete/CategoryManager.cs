using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal  _CategoryDal;

        public CategoryManager(ICategoryDal categoryDal) 
        {
            _CategoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _CategoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _CategoryDal.Get(c=>c.CategoryId == categoryId);
        }
    }

}
 