namespace CSharp_10_in_a_Nutshell.CP3.GenericConstraints.BackendCase;

public class GenericRepository<T> where T : BaseEntity, new()
{
    public void SaveToDatabase(T entity)
    {
        Console.WriteLine($"Saving entity with ID: {entity.Id} to database.");
    }

    public T CreateNewRecord()
    {
        T newObj = new T();
        Console.WriteLine($"Created new {newObj.GetType().Name}");
        return newObj;
    }
}