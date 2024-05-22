namespace Assignment3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 0, 0, 0, 0, };

            Console.WriteLine("Please enter first number: ");
            inputArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            inputArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number: ");
            inputArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter fourth number: ");
            inputArray[3] = Convert.ToInt32(Console.ReadLine());

            double[] returnArray = TotalAverage(inputArray);
            Console.WriteLine($"The total is {returnArray[0]} and the average is {returnArray[1]}.");
        }

        static double[] TotalAverage(int[] methodInput) 
        {
            int total = methodInput[0] + methodInput[1] + methodInput[2] + methodInput[3];
            double average = total/4;
            
            double[] outputArray = {total,average};
            return outputArray;
        }

    }
}
