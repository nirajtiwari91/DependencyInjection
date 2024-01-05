namespace DependencyInjectionExample
{
    public class UserServiceNew:IUserService
    {
        public string GetUserName()
        {
            //New logic to retrieve user name
            return "New User Service";
        }
    }
}
