using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataBase
{
    public class CRUD
    {
        public static List<Authors> GetAuthors()
        {
            List<Authors> result = new List<Authors>();


            using (var ctx = new BooksEntities1())
            {
                result = ctx.Authors.ToList<Authors>();
            }
                return result;
        }
    }
}
