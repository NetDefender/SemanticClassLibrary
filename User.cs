namespace SemanticClassLibrary;

public sealed class User
{
    public string Name { get; set; } = "";
    public string FullName {get;set;} = default!;
    public int Age { get; set; } = 100;
    public DateTime Created { get; set; } = DateTime.Now;
    public int Balance { get; set; }
}