namespace Software2KnowledgeCheck1;


public class ConstructionDept
{

    public bool CreateBuilding<T>(City city, T building) where T : Building
    {
        var materialRepo = new MaterialsRepo();
        var materialsNeeded = materialRepo.GetMaterials();

        var permitRepo = new ZoningAndPermitRepo();

        var buildingWasMade = ConstructBuilding<T>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

        if (buildingWasMade)
        {
            city.Buildings.Add(building);
            return true;
        }

        return false;
    }

    public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T : Building
    {
        if (permit && zoning)
        {
            foreach (var material in materials)
            {
                if (material == "concrete")
                {
                    // start laying foundation
                }
                else if (material == "Steel")
                {
                    // Start building structure
                }
                // etc etc...

            }
            return true;
        }
        else
        {
            return false;
        }
    }
}