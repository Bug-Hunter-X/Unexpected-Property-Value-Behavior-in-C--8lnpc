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
        //some code
        MyProperty = 10;
        Console.WriteLine(MyProperty); //This will correctly print 10
    }
}