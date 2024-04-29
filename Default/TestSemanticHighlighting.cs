namespace Default1;

internal class TestSemanticHighlighting
{
	int test = 0;
	string _test2 = "";
	
	private void TestTestSemanticHighlightingMethod(int _test)
	{
		_test++;
		
		Tuple<int, string, List<int>> tuple = new(_test, _test2, []);
		
		var variable1 = 5;
		var variable2 = 5;
		var variable3 = "";
		var variable4 = variable1;
		var variable5 = variable1;
		
		// Local Variables
		var myLocalVariable = "This is a local variable";
		Console.WriteLine(myLocalVariable);
		
#if DEBUG
		var debugVariable1 = "This is a local variable for DEBUG configuration";
		var debugVariable2 = "This is a local variable for DEBUG configuration";
		var debugVariable3 = "This is a local variable for DEBUG configuration";
		Console.WriteLine(debugVariable1);
#else
        var releaseVariable = "This is a local variable for non-DEBUG configuration";
        Console.WriteLine(releaseVariable);
#endif
		
		// Using a local variable inside a loop
		for (int k = 0; k < 5; k++)
		{
			Console.WriteLine("Value of the local variable i: " + k);
		}

		// Call a method with parameters
		int a = 5;
		int b = 6;
		var result = AddNumbers(a, b);
		Console.WriteLine("AddNumbers result: " + result);
        
		// Use parameters in a lambda function
		var numbers = new[] {1, 2, 3, 4, 5};
		Array.ForEach(numbers, x => Console.WriteLine("ForEach parameter: " + x));
	}

	private static int AddNumbers(int a, int b)  // parameters a and b
	{
		// Local variable inside a method
		var sum = a + b;
		return sum;
	}
}