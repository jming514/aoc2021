string path = Directory.GetCurrentDirectory();
string[] text = File.ReadAllLines($"{path}/text.txt");
int length_of_row = text[0].Length;

string[] func(int count, string[] array, string oxy_or_co2)
{
    if (count >= length_of_row || array.Length == 1)
    {
        return array;
    }

    int row_index = count;
    string[] text = array;
    List<string> sub_text = new List<string>();
    List<int> one = new List<int>();
    List<int> zero = new List<int>();

    for (int i = 0; i < text.Length; i++)
    {
        if ((text[i][row_index] - '0') == 1)
        {
            one.Add(i);
        }
        else
        {
            zero.Add(i);
        }
    }

    if (oxy_or_co2 == "oxy")
    {
        if (zero.Count <= one.Count)
        {
            for (int i = 0; i < one.Count; i++)
            {
                sub_text.Add(text[one[i]]);
            }
        }
        else
        {
            for (int i = 0; i < zero.Count; i++)
            {
                sub_text.Add(text[zero[i]]);
            }
        }
    }
    else
    {
        if (zero.Count > one.Count)
        {
            for (int i = 0; i < one.Count; i++)
            {
                sub_text.Add(text[one[i]]);
            }
        }
        else
        {
            for (int i = 0; i < zero.Count; i++)
            {
                sub_text.Add(text[zero[i]]);
            }
        }
    }

    row_index++;
    string[] new_text = sub_text.ToArray();

    string[] answer = func(row_index, new_text, oxy_or_co2);
    return answer;
}

string[] oxy_final = func(0, text, "oxy");
string[] co2_final = func(0, text, "co2");

int oxy = Convert.ToInt32(String.Join(",", oxy_final), 2);
int co2 = Convert.ToInt32(String.Join(",", co2_final), 2);

Console.WriteLine($"oxygen generator rating: {oxy}");
Console.WriteLine($"CO2 scrubber rating: {co2}");
Console.WriteLine($"life support rating: {co2 * oxy}");