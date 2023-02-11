using System.Diagnostics;

namespace Software2KnowledgeCheck1;

public class Building
{
    public string? Name { get; set; }
    public string? Street { get; set; }
    public int StreetNumber { get; set; }
    public Building()
    {
        Name = null;
    }
    public Building(string buildingName)
    {
        Name = buildingName;
    }
}