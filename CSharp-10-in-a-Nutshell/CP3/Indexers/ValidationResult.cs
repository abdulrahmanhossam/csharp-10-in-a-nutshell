namespace CSharp_10_in_a_Nutshell.CP3.Indexers;

public class ValidationResult
{
    private Dictionary<string, string> _errors = new Dictionary<string, string>();

    public string this[string fieldName]
    {
        get
        {
            if (_errors.ContainsKey(fieldName))
                return _errors[fieldName];
            return "";
        }
        set
        {
            _errors[fieldName] = value;
        }
    }
}