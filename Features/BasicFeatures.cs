namespace Features
{
    public class BasicFeatures
    {
        public void PrintMessage()
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Name: {name} Age: {age} Height: {height} Salary: {salary}$");
        }

        public void CountPositiveNums()
        {
            int[] nums = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int result = 0;

            foreach(int num in nums)
            {
                if (num > 0)
                {
                    result += 1;
                }
            }

            Console.WriteLine($"Amount of Positive numbers in an array: {result}");
        }

        public void InvertArray()
        {
            int[] nums = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int arrLength = nums.Length;

            int middle = arrLength / 2;

            int temp = 0;

            for (int i = 0; i < middle; i++)
            {
                temp = nums[i];
                nums[i] = nums[arrLength - i - 1];
                nums[arrLength - i - 1] = temp;
            }

            foreach(int num in nums)
            {
                Console.WriteLine($"{num}\t");
            }
        }
    }
}
