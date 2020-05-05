using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.Dao
{
    public class UserDao
    {
        HRMSDbContext db = null;
        public UserDao()
        {
            db = new HRMSDbContext();
        }

        public long Insert(SystemUser entity)
        {
            db.SystemUsers.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(SystemUser entity)
        {
            try
            {
                var user = db.SystemUsers.Find(entity.ID);
                user.UserName = entity.UserName;
                if (!string.IsNullOrEmpty(entity.PassWord))
                {
                    user.PassWord = entity.PassWord;
                }
                user.IDBusinessPartner = entity.IDBusinessPartner;
                user.ModifiedBy = entity.ModifiedBy;
                user.ModifiedDate = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public IEnumerable<SystemUser> ListAllPaging(string searchString, int pageNumber, int pageSize)
        {
            IQueryable<SystemUser> model = db.SystemUsers;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.UserName.Contains(searchString) || x.UserName.Contains(searchString));
            }
            return model.OrderByDescending(x => x.CreatedDate).ToPagedList(pageNumber, pageSize);
        }

        public SystemUser GetById(string userName)
        {
            return db.SystemUsers.SingleOrDefault(x => x.UserName == userName);
        }

        public SystemUser ViewDetail(int id)
        {
            return db.SystemUsers.Find(id);
        }

        public int Login(string userName, string passWord)
        {
            var result = db.SystemUsers.SingleOrDefault(x => x.UserName == userName);
            if (result ==null)
            {
                return 0;
            }
            else { if (result.Status == false)
                {
                    return -1;
                }
                else { if (result.PassWord == passWord)
                    {
                        return 1;
                    }
                    else return -2;
                } 
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var user = db.SystemUsers.Find(id);
                db.SystemUsers.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
