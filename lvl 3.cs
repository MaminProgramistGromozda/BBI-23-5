using System;
struct Football
{
    private string _teams;
    private bool _score;

    public bool Score
    {
        get { return _score; }
        set { _score = value; }
    }
    public Football(string tm, bool sc)
    {
        _teams = tm;
        _score = sc;
    }
    public void Print()
    {
        if (_score == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_teams + ": " + "Поражение" + " " + "Команда проиграла и не прошла в следующий этап");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_teams + ": " + "Победа" + " " + "Поздравляем! Команда прошла в следующий этап!");
            Console.ResetColor();
        }
    }
    public void WinPrint()
    {
        if (_score == true)
        {
            Console.WriteLine(_teams + ": " + "Прошли в следующий тур");
        }
    }
}
class Program
{
    static void Main()
    {
        Football Tims = new Football("Команда0", true);
        Football[] komandi = new Football[]
        {
            new Football("Команда1", false),
            new Football("Команда2", true),
            new Football("Команда3", false),
            new Football("Команда4", false),
            new Football("Команда5", true),
            new Football("Команда6", true),
        };
        Sort(komandi);
        Console.WriteLine("Сетка определяется следующим образом. Каждая команда играет с противоположной по счету: 1-12, 2-11, 3-10, 4-9, 5-8, 6-7. Если рядом с командой стоит 0 - команда проиграла и не прошла. Если 1 - команда вышла во второй тур");
        foreach(Football rezultati in komandi)
        {
            rezultati.Print();
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Список прошедших команд:");
        Console.ResetColor();
        foreach (Football rezultati in komandi)
        {
            rezultati.WinPrint();
        }
    }
    static void Sort(Football[] komandi)
    {
        int i = 1;
        while (i < komandi.Length)
        {
            if (i == 0 || komandi[i - 1].Score || !komandi[i].Score)
            {
                i++;
            }
            else
            {
                Football temp = komandi[i - 1];
                komandi[i - 1] = komandi[i];
                komandi[i] = temp;
                i--;
            }
        }
    }
}