 class Trainer
{
    private string name;
    private int badges;
    private List<string> pokemon;
    //•	Name
    //•	Number of badges
    //•	A collection of pokemon

    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> Pokemons { get; set; }
    public Trainer(string name)
    {
        Name = name;
        Badges = badges;
        Pokemons = new List<Pokemon>();
    }
}

