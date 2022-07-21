using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Tuple<bool,string> Add(User user)
        {
            var result = _userDal.Add(user);

            if (result)
            {
                return new Tuple<bool,string>(true, "Kullanıcı Kaydedildi");
            }
            return new Tuple<bool,string>(false, "Kullanıcı Kaydedilmedi!");
        }
    }
}
