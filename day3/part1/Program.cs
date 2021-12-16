string path = Directory.GetCurrentDirectory();
string[] text = File.ReadAllLines($"{path}/text.txt");
int length_of_row = text[0].Length;
int[] counter = new int[length_of_row];
int length_of_input = text.Length;

for (int i = 0; i < text.Length; i++)
{
    for (int j = 0; j < text[i].Length; j++)
    {
        if (text[i][j] == '1')
        {
            counter[j]++;
        }
    }
}

int[] gamma_arr = new int[length_of_row];
int[] epsilon_arr = new int[length_of_row];

for (int i = 0; i < counter.Length; i++)
{
    if ((length_of_input / 2) > counter[i])
    {
        gamma_arr[i] = 0;
        epsilon_arr[i] = 1;
    }
    else
    {
        gamma_arr[i] = 1;
        epsilon_arr[i] = 0;
    }
}

int gamma = Convert.ToInt32(string.Join("", gamma_arr), 2);
int epsilon = Convert.ToInt32(string.Join("", epsilon_arr), 2);
int power_consumption = gamma * epsilon;

Array.ForEach(gamma_arr, Console.Write);
Console.WriteLine(" gamma: {0}", gamma);
Array.ForEach(epsilon_arr, Console.Write);
Console.WriteLine(" epsilon: {0}", epsilon);
Console.WriteLine("power consumption: {0}", power_consumption);