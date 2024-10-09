namespace ConsoleFun;

public class Employee
{
    private string name;
    
    private int age;

    private int Id;
    


    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    // public int Age
    // {
    //     get => age;
    //     set => if age;
    // }

    public int Id1
    {
        get => Id;
        set => Id = value;
    }


    // public int Id {
    //     get;
    //     // set;
    // }
    //
    // public string Name { get; set; }
    // public int Age { get; set; }


    // public string Name
    // {
    //     get { return name; }
    //     set { name = value; }
    // }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18) throw new ArgumentException("Age must be greater than 18", nameof(value));
            age = value;
        }
    }
    
    public double CalculateSalary(int hours)
    {
        return 1000;
    }
    // method signature
    public virtual double CalculateSalary(string hours)
    {
        return 100;
    }

}

class CasualEmployee : Employee
{
    // method signature
    public override double CalculateSalary(string hours)
    {
        int tax = 100;
        return tax;
    }
}



