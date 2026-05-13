public class UIControl
{
    private Dictionary<string, Delegate> _eventStorage = new();

    // first event
    public event EventHandler Click
    {
        add
        {
            Console.WriteLine("Added Click Subscriber");
            AddEvent("Click", value);
        }
        remove { RemoveEvent("Click", value); }
    }

    // second event
    public event EventHandler Hover
    {
        add { AddEvent("Hover", value); }
        remove { RemoveEvent("Hover", value); }
    }

    // event helper methods 
    private void AddEvent(string eventName, Delegate handler)
    {
        if (!_eventStorage.ContainsKey(eventName))
            _eventStorage[eventName] = null;

        _eventStorage[eventName] = Delegate.Combine(_eventStorage[eventName], handler);
    }

    private void RemoveEvent(string eventName, Delegate handler)
    {
        if (_eventStorage.ContainsKey(eventName))
            _eventStorage[eventName] = Delegate.Remove(_eventStorage[eventName], handler);
    }

    //start event
    public void SimulateClick()
    {
        if (_eventStorage.ContainsKey("Click") && _eventStorage["Click"] != null)
        {

            ((EventHandler)_eventStorage["Click"]).Invoke(this, EventArgs.Empty);
        }
    }
}