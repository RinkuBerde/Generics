namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            bool[] boolArr = { true, false };

            // for normal methods
            // PrintArray.toPrint(intArray);
            // PrintArray.toPrint(doubleArray);
            //PrintArray.toPrint(charArray);

            //for generics methods
             PrintArray.toPrint<int>(intArray);
             PrintArray.toPrint<double>(doubleArray);
             PrintArray.toPrint<char>(charArray);
             PrintArray.toPrint<bool>(boolArr);
            //PrintArray<int> obj = new PrintArray<int>(intArray);
            //obj.toPrint();

            //for generics class
            new PrintArrayClass<int>(intArray).toPrint();
            new PrintArrayClass<double>(doubleArray).toPrint();
            new PrintArrayClass<char>(charArray).toPrint();
            new PrintArrayClass<bool>(boolArr).toPrint();
        }
    }
}