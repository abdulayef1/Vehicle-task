
internal class Car : Vehicle
{	public string brand;
	public string model;
	public int  fuelCapacity;
	public int fuelFor1Km;
	public int currentFuel=0;
	int requestFuel = 0;

    public Car(int year,string brand,string model,int fuelCapacity,int fuelFor1Km) : base(year)
    {
		this.brand = brand;
		this.model = model;
		this.fuelCapacity = fuelCapacity;
		this.fuelFor1Km = fuelFor1Km;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Brand:{brand} \nModel:{model} \nCurrent fuel:{currentFuel} lt \nFuel for a km:{fuelFor1Km} lt");//bu melumatlari daha vacib gorrem diye tekce bulari capa verdim digerlerinide elave etmek olar telebata gore
    }


    public void Drive(int targetDistance)
	{
		if (targetDistance<=0)
		{
			throw new Exception("distance cannot less than zero");
		}
		requestFuel =targetDistance*fuelFor1Km;

		if (requestFuel>currentFuel)
		{
			Console.WriteLine("Is not exsist enough fuel !");
			Console.WriteLine($"Current fuel:{currentFuel}");
			//Console.WriteLine($"Total request fuel:{requestFuel}");
			//Console.WriteLine($"Current request fuel:{requestFuel - currentFuel}");

		}else if (requestFuel<=currentFuel)
		{
			Console.WriteLine("Arrived location.");
			currentFuel =currentFuel- requestFuel;
			Console.WriteLine($"Current fuel:{currentFuel}");
		}

	}

}
