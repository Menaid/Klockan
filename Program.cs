
int times = 0;

for (int h = 0; h < 24; h++)
{
    for (int m = 0; m < 60; m++)
    {
        for (int s = 0; s < 60; s++)
        {
            Console.WriteLine(formatTime(h) + ":" + formatTime(m) + ":" + formatTime(s));
            times++;
        }

    }

}


Console.WriteLine(times);





string formatTime(int number)
{
    if (number <= 9)
    {
        return "0" + number;
    }
    else
    {
        return number.ToString();
    }
}