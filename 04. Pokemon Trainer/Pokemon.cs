class Pokemon
{
    // Pokemon have:
    //•	Name
    //•	Element
    //•	Health
    private string name;
    private string element;
    private string health ;
    
    public string Name { get; set; }
    public string Element { get; set; }
    public int Health { get; set; }
    public Pokemon (string name, string element, int health)
    {
        Name = name;
        Element = element;
        Health = health;
    }

}

