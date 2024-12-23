namespace Week6_ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindOddOne.FindOddNumber();// Challenge Problem 1
            int[] nums = { 0, 1, 0, 3, 12 }; //array of integers declared
            Console.WriteLine($" Your original array is: {string.Join(", ", nums)}");

           
            MissingNumber.MoveZeroes(nums); //calling method MoveZeroes

            Console.WriteLine($"\n Your corrected array is: {string.Join(", ", nums)}"); //print out corrected array // Challenge Problem 2
        }
    }
}
