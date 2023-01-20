namespace EquelsExample;

public class Test2
{
    public string Name { get; set; }
    
    public string Id { get; set; }
    
    public string Title => Name + Id;
}