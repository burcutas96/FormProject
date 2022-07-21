using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        public bool Add(User user)
        {
            using (ReportContext context = new ReportContext())
            {
                var addedUser = context.Entry(user);
                addedUser.State = EntityState.Added;
                context.SaveChanges();
            }
            return true;
        }
    }
}
