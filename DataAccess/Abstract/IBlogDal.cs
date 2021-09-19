using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal
    {
        List<Blog> ListAllBlog();
        void BlogAdd(Blog blog);
        void BlogDelete (Blog blog);
        void BlogUpdate(Blog blog);
        Blog GetById(int id);
    }
}
