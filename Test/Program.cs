using System.Linq;
class Program
{
    static void Main()
    {
        int result = Algorithm(new int[] {0, 4, 5, 3, 1 });
        Console.WriteLine(result);
    }
    
    public static int Algorithm(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                return i;
            }
        }
        return 0;
    }

}
