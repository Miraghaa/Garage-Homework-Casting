namespace Garage_Homework_Casting;

public static class Extention
{
    public static void GetAnimals(this Animal[] animals)
    {
        foreach (Animal item in animals)
        {
            if(item is Eagle)
            {
                Eagle eagle = (Eagle)item;
                if(eagle.Age > 40)
                {
                    Console.WriteLine($"Eagle age: {eagle.Age}");
                }
            }
            else if(item is Snake) 
            {
                Snake snake = (Snake)item;
                if(snake.Length > 10)
                {
                    Console.WriteLine($"Snake length: {snake.Length}");
                }
            }
        }
    }
}
