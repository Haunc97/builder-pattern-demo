using PlanBuilderPattern.Models;

namespace PlanBuilderPattern.Builders;

public class BasicPlanBuilder : IPlanBuilder
{
    private Plan Plan { get; set; }

    public BasicPlanBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        Plan = new Plan() { Name = "Basic", Price = 19 };
    }

    public void BuildDiskSpaceFeature()
    {
        Plan.AddFeature(new Feature() { Title = "Disk Space", Value = "1 GB" });
    }

    public void BuildDatabaseFeature()
    {
        Plan.AddFeature(new Feature() { Title = "Database Size", Value = "5 GB" });
    }

    public void BuildBandwidthFeature()
    {
        Plan.AddFeature(new Feature() { Title = "Bandwidth", Value = "10 GB" });
    }

    public void BuildSslFeature()
    {
        Plan.AddFeature(new Feature() { Title = "SSL", Value = "Not Free" });
    }

    public Plan GetPlan()
    {
        var result = Plan;

        this.Reset();

        return result;
    }
}
