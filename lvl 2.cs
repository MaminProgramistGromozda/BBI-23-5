using System;
struct Sessia
{
    private int _pred1;
    private int _pred2;
    private int _pred3;
    private int _pred4;
    private string _name;
    private double _sr;
    public int Pred1
    {
        get { return _pred1; }
        set { _pred1 = value; }
    }
    public int Pred2
    {
        get { return _pred2; }
        set { _pred2 = value; }
    }
    public int Pred3
    {
        get { return _pred3; }
        set { _pred3 = value; }
    }
    public int Pred4
    {
        get { return _pred4; }
        set { _pred4 = value; }
    }
    public double Sredn
    {
        get { return _sr; }
        set { _sr = value; }
    }
    public Sessia(string nm, int p1, int p2, int p3, int p4)
    {
        _pred1 = p1;
        _pred2 = p2;
        _pred3 = p3;
        _pred4 = p4;
        _name = nm;
        _sr = getsred();
    }
    private double getsred()
    {
        return (_pred1 + _pred2 + _pred3 + _pred4) / 4;
    }
    public void Print()
    {
        if (_sr >= 4)
        {
            Console.WriteLine(_name + ": " + _pred1 + " " + _pred2 + " " + _pred3 + " " + _pred4 + " Sred: " + _sr);
        }
        else
        {
            Console.WriteLine(_name + ": " + _pred1 + " " + _pred2 + " " + _pred3 + " " + _pred4 + " Sred: " + _sr + " Не прошел по баллам");
        }
        
    }
}
class Program
{
    static void Main()
    {
        Sessia smert = new Sessia("Иванов1", 4, 3, 5, 4);
        Sessia[] ocenki = new Sessia[]
        {
            new Sessia("Иванов1", 4, 5, 3, 4),
            new Sessia("Иванов2", 5, 5, 5, 3),
            new Sessia("Иванов3", 3, 3, 5, 2),
            new Sessia("Иванов4", 5, 5, 5, 5),
        };
        Sort(ocenki);
        foreach(Sessia rezultati in ocenki)
        {
            rezultati.Print();
        }
    }
    static void Sort(Sessia[] ocenki)
    {
        int i = 0;
        int j = 1;
        while(j < ocenki.Length - 1)
        {
            if (i < 0 || ocenki[i].Sredn >= ocenki[i + 1].Sredn)
            {
                i = j;
                j++;
            }
            while (i >= 0 && ocenki[i].Sredn < ocenki[i + 1].Sredn)
            {
                Sessia temp = ocenki[i];
                ocenki[i] = ocenki[i + 1];
                ocenki[i + 1] = temp;
                i--;
            }
        }
    }
}