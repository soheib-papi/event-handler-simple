
namespace event_handler_simple;

class MyClass
{
    private int myProperty;

    public int MyProperty
    {
        get { return myProperty; }
        set
        {
            myProperty = value;
            if (myProperty % 5 == 0)
            {
                OnPropertyFiveReached();
            }
        }
    }

    public event EventHandler PropertyFiveReached;

    protected virtual void OnPropertyFiveReached()
    {
        PropertyFiveReached?.Invoke(this, EventArgs.Empty);
    }
}