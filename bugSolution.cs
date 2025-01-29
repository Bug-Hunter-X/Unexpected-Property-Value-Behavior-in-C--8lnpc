public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        //The issue is NOT in the property itself, it is likely caused by some other code not shown in the original example.
        // Ensure that the value is updated properly before accessing it. A simple check can help verify this. 
        MyProperty = 10;
        Console.WriteLine(MyProperty); //This will correctly print 10
        //To confirm the value is properly updated: 
        int temp = MyProperty;
        Console.WriteLine(temp); //this will correctly print 10
    }
} 