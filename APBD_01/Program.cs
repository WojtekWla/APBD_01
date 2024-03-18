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
        int[] nums = new int[] {1,2,4,4,5};
        Console.WriteLine(average(nums));
        

    }

    public static float average(int[] nums)
    {
        float result = 0f;
        for (int i = 0; i < nums.Length; i++)
        {
            result += nums[i];
        }

        return result / nums.Length;
    }
    
}

