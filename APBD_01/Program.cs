// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        //Task 1
        // int num1, num2;
        // num1 = Convert.ToInt32(Console.ReadLine());
        // num2 = Convert.ToInt32(Console.ReadLine());
        //
        // Console.WriteLine(num1 + num2);
        // Console.WriteLine(num1 - num2);

        //Task 2
        // int[] nums = new int[] { 1, 2, 4, 4, 5 };
        // Console.WriteLine(average(nums));
        
        //Task 3
        int[] nums = new int[] { 5, 4, 1, 2 };
        Console.WriteLine(max(nums));

    }

    public static float average(int[] another_numbers)
    {
        float result = 0f;
        for (int i = 0; i < another_numbers.Length; i++)
        {
            result += another_numbers[i];
        }

        return result / another_numbers.Length;
    }

    public static int max(int[] nums)
    {
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max) max = nums[i];
        }

        return max;
    }


}

