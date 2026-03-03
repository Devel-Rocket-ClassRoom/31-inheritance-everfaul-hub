using System;

class Program
{
    static void Main(string[] args)
    {
        Animal[] zoo = new Animal[]
        {
        new Lion("시바", 5),
        new Elephant("덤보", 10),
        new Penguin("뽀로로", 3)
        };

        Console.WriteLine("=== 동물원에 오신 것을 환영합니다! ===");
        Console.WriteLine();
        Console.WriteLine("[동물 정보]");
        foreach (var animal in zoo) animal.DisplayInfo();
        Console.WriteLine();
        Console.WriteLine("[동물 소리]");
        foreach (var animal in zoo) animal.MakeSound();
        Console.WriteLine();
        Console.WriteLine("[동물 행동]");
        foreach (var animal in zoo)
        {
            animal.Eat();

            if (animal is Lion lion) lion.Hunt();
            if (animal is Elephant elephant) elephant.SprayWater();
            if (animal is Penguin penguin) penguin.Swim();



        }
    }
}