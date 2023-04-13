namespace GenericsDemo
{
    class program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

        
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'A', 'T', 'E', 'R' };

            //program.toPrint<int>(intArray);

            //program.toPrint<double>(doubleArray);

            //program.toPrint<char>(charArray);

            //PrintArray<int> intPrintArray = new PrintArray<int>(intArray);
            //intPrintArray.toprint();

            //PrintArray<double> doublePrintArray = new PrintArray<double>(doubleArray);
            //doublePrintArray.toprint();

            //PrintArray<char> charPrintArray = new PrintArray<char>(charArray);
            //charPrintArray.toprint();

            //int num1 = 70;
            //int num2 = 70;

            Console.WriteLine("Please enter the first value");
            
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second value");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third value");

            int num3 = Convert.ToInt32(Console.ReadLine());

            int val = FindMaximum.MaximumIntegerNumber(num1, num2, num3);

            Console.WriteLine("{0} is greater", val);
        }
    }
}