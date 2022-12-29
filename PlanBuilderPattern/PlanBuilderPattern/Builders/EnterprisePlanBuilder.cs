using PlanBuilderPattern.Models;

namespace PlanBuilderPattern.Builders;

public class EnterprisePlanBuilder : IPlanBuilder
{
    private Plan Plan { get; set; }

    public EnterprisePlanBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        Plan = new() { Name = "Enterprise", Price = 49 };
    }

    public void BuildDiskSpaceFeature()
    {
        Plan.AddFeature(new Feature { Title = "Disk Space", Value = "100 GB" });
    }

    public void BuildDatabaseFeature()
    {
        Plan.AddFeature(new Feature { Title = "Database Size", Value = "300 GB" });
    }

    public void BuildBandwidthFeature()
    {
        Plan.AddFeature(new Feature { Title = "Bandwidth", Value = "Unlimited" });
    }

    public void BuildSslFeature()
    {
        Plan.AddFeature(new Feature { Title = "SSL", Value = "Free" });
    }

    public Plan GetPlan()
    {
        var result = Plan;

        this.Reset();

        return result;
    }
}
