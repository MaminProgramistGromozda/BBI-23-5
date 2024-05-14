using System;
struct Results
{
    private string _secondname;
    private int _group;
    private string _prepodsecname;
    private int _rez;
    private static int _k;
    public static double time;
    public int Group
    {
        get { return _group; }
        set { _group = value; }
    }
    public int Rez
    {
        get { return _rez; }
        set { _rez = value; }
    }
    public static int Kop
    {
        get { return _k; }
        set { _k = value; }
    }
    public Results(string sc, int g, string psc, int r)
    {
        _secondname = sc;
        _group = g;
        _prepodsecname = psc;
        _rez = r;
    }


    public void Print()
    {
        if (time < _rez)
        {
            Console.WriteLine(_secondname + " " + _group + " " + _prepodsecname + " " + _rez + " " + "не сдал");
        }
        else
        {
            Console.WriteLine(_secondname + " " + _group + " " + _prepodsecname + " " + _rez + " " + "сдал");
            _k++;
        }
    }
}
class Program
{
    static void Main()
    {
        Results.time = System.Convert.ToDouble(Console.ReadLine());
        Results ivanova2 = new Results("Иванова2", 2, "Тренерова2", 7);
        
        Results[] uchastniki = new Results[]
        {
            new Results("Иванова2", 5, "Тренерова2", 8),
            new Results("Иванова3", 4, "Тренерова3", 12),
            new Results("Иванова4", 8, "Тренерова4", 7),
            new Results("Иванова5", 6, "Тренерова5", 5),
        };
            Sort(uchastniki);
        foreach (Results rezultati in uchastniki)
        {
            rezultati.Print();
        }
        Console.WriteLine(Results.Kop);
    }
    static void Sort(Results[] uchastniki)
    {
        int i = 0, j = 1;
        while(j < uchastniki.Length - 1)
        {
            if(i < 0 || uchastniki[i].Rez >= uchastniki[i + 1].Rez)
            {
                i = j;
                j++;
            }
            while(i >= 0 && uchastniki[i].Rez < uchastniki[i + 1].Rez)
            {
                Results temp = uchastniki[i];
                uchastniki[i] = uchastniki[i+1];
                uchastniki[i + 1] = temp;            
            }
        }
    }
}