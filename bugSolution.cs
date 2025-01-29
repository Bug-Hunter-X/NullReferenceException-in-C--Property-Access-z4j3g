public class ExampleClass
{
    public int? MyProperty { get; set; }

    public void MyMethod()
    {
        // Solution 1: Null-conditional operator
        int? value = MyProperty?.GetHashCode();

        // Solution 2: Null check
        int value2 = 0;
        if (MyProperty.HasValue)
        {
            value2 = MyProperty.Value.GetHashCode();
        }
    }
}