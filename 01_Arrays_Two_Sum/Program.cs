namespace _01_Arrays_Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1];
            int target = 11;

            Console.WriteLine(string.Join(", ", TwoNumberSum(nums, target)));
        }

        public static int[] TwoNumberSum(int[] nums, int target)
        {
            Dictionary<int, int> numberIndexPairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];
                int difference = target - currentNumber;

                if (numberIndexPairs.TryGetValue(difference, out int value))
                {
                    return [i, value];
                }
                else numberIndexPairs.TryAdd(currentNumber, i);
            }

            return [];
        }
    }
}