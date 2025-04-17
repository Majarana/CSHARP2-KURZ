namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.SetColor("blue");

        int rectangleArea = Rectangle.Calculate(6, 8);
    }
}

//třída Car a metoda, která nastavuje jeho barvu
class Car
{
    private string color;

    public void SetColor(string color){
        this.color = color;
    }
}

//we want a method that calculates area of rectangle without an instance of class Rectangle

class Rectangle
{
    public static int Calculate(int a, int b)
    {
      return a*b;
    }
}