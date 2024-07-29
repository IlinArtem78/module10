// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

namespace module10 { 


    class Program
{
  static void Main(string[] args)
    {

            //контравариация интерфейса
            IUpdater<Account> updater1 = new UserService();
            IUpdater<User> updater2 = new UserService();

        }
}

}

public interface IUpdater<in T>
{
    void Update(T entity);
}

public class User
{

}

public class Account : User
{

}

class UserService : IUpdater<User>
{
    public void Update(User entity)
    {
        throw new NotImplementedException();
    }
}