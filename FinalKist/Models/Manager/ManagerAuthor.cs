using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalKist.Models.DAL;
using FinalKist.Models.Entity;
namespace FinalKist.Models.Manager
{
    public class ManagerAuthor
    {
        public static void SaveAuthor(AuthorEntity detail)
        {
            using (LMSEntities dbe=new DAL.LMSEntities())
            {
                    Author author = new DAL.Author();
                    author.Id = detail.Id;
                    author.FirstName = detail.FirstName;
                    author.LastName = detail.LastName;
                    author.Phone = detail.Phone;
                    author.Email = detail.Email;
                    author.Qualification = detail.Qualification;
                    dbe.Authors.Add(author);
                    dbe.SaveChanges();
                }
        }

        public static void EditAuthor(AuthorEntity detail)
        {
            using (LMSEntities dbe = new DAL.LMSEntities())
            {
                Author author = dbe.Authors.Find(detail.Id); 
                author.FirstName = detail.FirstName;
                author.LastName = detail.LastName;
                author.Phone = detail.Phone;
                author.Email = detail.Email;
                author.Qualification = detail.Qualification;
               // dbe.Entry(author).State = System.Data.Entity.EntityState.Modified;
                dbe.SaveChanges();
            }
        }
        public static List<AuthorEntity> GetAuthors()
        {
            List<AuthorEntity> authors = new List<Entity.AuthorEntity>();
            using (LMSEntities dbe = new LMSEntities())
            {
                AuthorEntity authorEntity;
                var authorList = dbe.Authors.ToList();
                foreach(Author author in authorList)
                {
                    authorEntity = new Entity.AuthorEntity();
                    authorEntity.Id = author.Id;
                    authorEntity.FirstName = author.FirstName;
                    authorEntity.LastName = author.LastName;
                    authorEntity.Phone = author.Phone;
                    authorEntity.Email = author.Email;
                    authorEntity.Qualification = author.Qualification;
                    authors.Add(authorEntity);
                }
            }
            return authors;
        }


        public static void DelAuthor(string Id)
        {
            using (LMSEntities dbe = new LMSEntities())
            {
                Author author = dbe.Authors.Where(o => o.Id.Equals(Id)).SingleOrDefault();
                dbe.Authors.Remove(author);
                dbe.SaveChanges();
            }
        }

        public static AuthorEntity DetailAuthor(string Id)
        {
            AuthorEntity authorEntity = new Entity.AuthorEntity();
            using (LMSEntities dbe = new LMSEntities())
            {
                Author author = dbe.Authors.Where(o => o.Id.Equals(Id)).Single();
                authorEntity.Id = author.Id;
                authorEntity.FirstName = author.FirstName;
                authorEntity.LastName = author.LastName;
                authorEntity.Phone = author.Phone;
                authorEntity.Email = author.Email;
                authorEntity.Qualification = author.Qualification;
            }
            return authorEntity;
        }
    }
}