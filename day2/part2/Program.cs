string path = Directory.GetCurrentDirectory();
string[] text = File.ReadAllLines($"{path}/text_input.txt");

int x = 0;
int aim = 0;
int y = 0;
for (int i = 0; i < text.Length; i++)
{
    if (text[i].Contains("forward"))
    {
        int value = text[i].Last() - '0';

        x = x + value;

        if (aim != 0)
        {
            y = y + (aim * value);
        }
    }
    if (text[i].Contains("down"))
    {
        int value = text[i].Last() - '0';
        aim = aim + value;
    }
    if (text[i].Contains("up"))
    {
        int value = text[i].Last() - '0';
        aim = aim - value;
    }
}
Console.WriteLine("x * y = {0}", x * y);