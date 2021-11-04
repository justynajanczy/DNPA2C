using Assignment2.Models;

namespace Assignment2.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}