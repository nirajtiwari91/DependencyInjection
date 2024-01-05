namespace DependencyInjectionExample
{
    public class UserService:IUserService
    {
        public string GetUserName()
        {
            //Logic to retrieve user name
            return "User Service";
        }
    }
}
