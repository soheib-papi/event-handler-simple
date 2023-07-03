
using event_handler_simple;

var myClass = new MyClass();

myClass.PropertyFiveReached += (sender, args) =>
{
    MyClass myObject =(MyClass)sender;
    Console.WriteLine($"{myObject.MyProperty}");
};

for(int i = 1; i < 19; i++)
    myClass.MyProperty = i;

Console.ReadLine();