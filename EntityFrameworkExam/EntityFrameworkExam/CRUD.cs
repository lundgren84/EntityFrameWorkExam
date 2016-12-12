using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExam
{
    public class CRUD
    {
        internal static List<Authors> GetAuthors()
        {
            using (var ctx = new BooksEntities1())
            {
                return ctx.Authors.ToList<Authors>();
            }
        }

        internal static List<Titles> GetAuthorsTitles(int authorID)
        {
            using (var ctx = new BooksEntities1())
            {
                Authors author = ctx.Authors.FirstOrDefault(x => x.AuthorID == authorID);
                return author.Titles.ToList();
            }
        }

        internal static List<Authors> FindAuthor(string search)
        {
            using (var ctx = new BooksEntities1())
            {
                return ctx.Authors.Where(x => x.FirstName.ToLower().Contains(search) || x.LastName.ToLower().Contains(search)).ToList<Authors>();
            }
        }

        internal static void AddNewAuthor(Authors author)
        {
            using (var ctx = new BooksEntities1())
            {
                ctx.Authors.Add(author);
                ctx.SaveChanges();
            }
        }

        internal static void AddNewStore(Stores store)
        {
            using (var ctx = new BooksEntities1())
            {
                ctx.Stores.Add(store);
                ctx.SaveChanges();
            }
        }

        internal static List<Titles> FindTitle(string search)
        {

            using (var ctx = new BooksEntities1())
            {
                return ctx.Titles.Where(x => x.Title.ToLower().Contains(search)).ToList<Titles>();
            }
        }
    }
}