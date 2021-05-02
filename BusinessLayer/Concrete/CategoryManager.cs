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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public List<Category> GetList()
        {
            return null; 
        }
        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //public List<Category> GetAllBLL()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBLL(Category p)
        //{
        //    if (p == null || p.CategoryName == null || p.CategoryDescription == null || p.CategoryName == string.Empty || p.CategoryName.Length <= 3 || p.CategoryDescription == string.Empty || p.CategoryName.Length > 50)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }

        //}
    }
}
