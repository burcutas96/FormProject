using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        Tuple<bool, string> Add(User user);
    }
}
