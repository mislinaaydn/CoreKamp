using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void CategoryAdd(Category category)
        {
            c.Add(category);
            c.SaveChanges();

        }

        public void CategoryDelete(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public void CategoryUpdate(Category category)
        {

            c.Update(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }
    }
}
