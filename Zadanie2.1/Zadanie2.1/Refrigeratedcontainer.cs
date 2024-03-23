namespace Zadanie2._1;

public class Refrigeratedcontainer : Container
{
    
    public static Dictionary<string, double> map = new Dictionary<string, double>();
    public double temperature;
    public string type;
    public Refrigeratedcontainer(double weight, double height, double containerWeight, double depth, double maxAcceptableWeight, double temperature, string type) : base(weight, height, containerWeight, depth, maxAcceptableWeight)
    {
        map["Bananas"] = 13.3; 
        map["Chocolate"] = 18;
        map["Fish"] = 2;
        map["Meat"] = -15;
        map["Ice cream"] = -18;
        map["Frozen pizza"] = -30; 
        map["Cheese"] = 7.2;
        map["Sausages"] = 5;
        map["Butter"] = 20.5;
        map["Eggs"] = 19;
        this.type = type;
        this.temperature = temperature;
        if (map[type] < this.temperature)
        {
            this.type = "pusty";
        }
        this.serialNumber = "KON-R-" + number;

    }

    public override string ToString()
    {
        return base.ToString() + "\nTemperatura kontenera: " + temperature + "\nTyp produktu: " + type;
    }
}

    
