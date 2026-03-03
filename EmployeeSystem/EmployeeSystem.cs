using System;


class Employee
{
    protected string _name;
    protected int _baseSalary;

    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }
    public string GetName() => _name;
    public int GetBaseSalary() => _baseSalary;

    public int CalculatePay()
    {
        return _baseSalary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"이름: {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
    }
}