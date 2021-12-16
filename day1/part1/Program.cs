/* using System; */
/* using System.IO; */

class Test
{
    public static void Main()
    {
        try
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}/test_input.txt", path);

            int[] text = System.IO.File.ReadAllLines($"{@path}/test_input.txt").Select(t => Convert.ToInt32(t)).ToArray();

            int measurements = 0;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] > text[i - 1])
                {
                    measurements++;
                }
            }

            Console.WriteLine("Total measurements larger than the last: {0}", measurements);
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
            throw;
        }
    }
}
