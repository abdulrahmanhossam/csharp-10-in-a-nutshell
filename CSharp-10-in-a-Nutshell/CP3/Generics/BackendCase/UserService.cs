namespace CSharp_10_in_a_Nutshell.CP3.Generics.BackendCase;

public class UserService
{
    // return user and status 
    public Result<User> GetUser(int id)
    {
        return new Result<User> { IsSuccess = true, Data = new User { Name = "Ahmed" } };
    }

    // return balance an status
    public Result<decimal> GetUserBalance(int id)
    {
        return new Result<decimal> { IsSuccess = true, Data = 1500.50m };
    }
}