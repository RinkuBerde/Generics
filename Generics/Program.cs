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

            // PrintArray.toPrint(intArray);
            // PrintArray.toPrint(doubleArray);
            //PrintArray.toPrint(charArray);

             PrintArray.toPrint<int>(intArray);
             PrintArray.toPrint<double>(doubleArray);
             PrintArray.toPrint<char>(charArray);
             PrintArray.toPrint<bool>(boolArr);
            //PrintArray<int> obj = new PrintArray<int>(intArray);
            //obj.toPrint();

        }
    }
}