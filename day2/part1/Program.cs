try
{
    string path = Directory.GetCurrentDirectory();
    string[] text = File.ReadAllLines($"{path}/text_input.txt");

    int x = 0;
    int y = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Contains("forward"))
        {
            int value = text[i].Last() - '0';
            x = x + value;
        }
        if (text[i].Contains("down"))
        {
            int value = text[i].Last() - '0';
            y = y + value;
        }
        if (text[i].Contains("up"))
        {
            int value = text[i].Last() - '0';
            y = y - value;
        }
    }

    Console.WriteLine("x = {0}, y = {1}, xy = {2}", x, y, x*y);
}
catch (Exception e)
{
    Console.WriteLine("Error: {0}", e.ToString());
    throw;
}