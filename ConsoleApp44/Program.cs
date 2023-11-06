using System;


interface IParent
{
    string Info();
    void Metod();
}


class Child1 : IParent
{
    private string pole1; 
    private int pole2;    
    private string pole3; 

    public Child1(string name, string paperQuality)
    {
        pole1 = name;
        pole3 = paperQuality;
    }

    public string Info()
    {
        return $"Назва: {pole1}, Ціна: {pole2}, Якість паперу: {pole3}";
    }

    public void Metod()
    {
        pole2 = (pole3 == "high") ? 200 : 100;
    }
}


class Child2 : IParent
{
    private string pole1;  
    private int pole2;     
    private string pole4;  
    private int pole5;     

    public Child2(string name, string coverType, int pageCount)
    {
        pole1 = name;
        pole4 = coverType;
        pole5 = pageCount;
    }

    public string Info()
    {
        return $"Назва: {pole1}, Ціна: {pole2}, Тип обкладинки: {pole4}, Кількість сторінок: {pole5}";
    }

    public void Metod()
    {
        pole2 = (int)(pole5 * 0.2);
        if (pole4 == "hard")
        {
            pole2 += 15;
        }
        else
        {
            pole2 += 5;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int objectType = random.Next(2); 
            IParent obj;

            if (objectType == 0)
            {
                string paperQuality = (random.Next(2) == 0) ? "low" : "high";
                obj = new Child1("Журнал", paperQuality);
            }
            else
            {
                int pageCount = random.Next(100, 501); 
                string coverType = (random.Next(2) == 0) ? "soft" : "hard";
                obj = new Child2("Книга", coverType, pageCount);
            }

            obj.Metod();
            Console.WriteLine(obj.Info());
        }
    }
}
