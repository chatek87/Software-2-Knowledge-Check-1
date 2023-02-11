using Software2KnowledgeCheck1;

City rockBottom = new()
{
    Name = "Rock Bottom",
    Population = 137,
    State = "The Deep"
};

Building theKrankyKrill = new() { Name = "The Kranky Krill" };

ConstructionDept constructionDept = new();

if(constructionDept.CreateBuilding(rockBottom, theKrankyKrill))
{
    Console.WriteLine($"{theKrankyKrill.Name} successfully added to {rockBottom.Name}.");
}
else
{
    Console.WriteLine("Sorry, no dice.");
}


