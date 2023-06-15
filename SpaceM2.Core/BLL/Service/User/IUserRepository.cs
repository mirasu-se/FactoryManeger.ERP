using SpaceM2.Core.BLL.Model;
namespace SpaceM2.Core.BLL.Service
{
    public interface IUserRepository
    {
        UserModel GetLogedInUser(string password);
        bool ValidateUser(string password);
    }
}