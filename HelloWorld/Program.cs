namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {

        Car car = new Car();
        car.SetColor("blue");
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