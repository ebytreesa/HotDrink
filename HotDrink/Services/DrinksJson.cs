
public class DrinksJson
{
    public Hotdrink[] HotDrinks { get; set; }
}

public class Hotdrink
{
    public string name { get; set; }
    public string[] strength { get; set; }
    public string[] Sweetner { get; set; }
    public string[] Extra { get; set; }
    public int AvailableMonthStart { get; set; }
    public int AvailableMonthEnd { get; set; }
}
