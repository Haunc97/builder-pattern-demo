using PlanBuilderPattern.Models;

namespace PlanBuilderPattern.Builders;

public interface IPlanBuilder
{
    void BuildDiskSpaceFeature();
    void BuildDatabaseFeature();
    void BuildBandwidthFeature();
    void BuildSslFeature();

    Plan GetPlan();
}
