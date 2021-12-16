try
{
    string path = Directory.GetCurrentDirectory();
    int[] text = File.ReadAllLines($"{@path}/text_input.txt").Select(t => Convert.ToInt32(t)).ToArray();

    int measurements = 0;

    for (int i = 0; i < text.Length - 3; i++)
    {
        int j = i + 1;
        int window1 = text[i] + text[i + 1] + text[i + 2];
        int window2 = text[j] + text[j + 1] + text[j + 2];

        if (window2 > window1)
        {
            measurements++;
        }
    }

    Console.WriteLine("Total increases: {0}", measurements);
}
catch (Exception e)
{
    Console.WriteLine("The process failed: {0}", e.ToString());
    throw;
}