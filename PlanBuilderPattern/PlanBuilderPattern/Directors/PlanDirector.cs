using PlanBuilderPattern.Builders;

namespace PlanBuilderPattern.Directors;

public class PlanDirector : IPlanDirector
{
    public IPlanBuilder _builder { get; set; }
    public void SetPlanBuilder(IPlanBuilder builder)
    {
        _builder = builder;
    }
    public void BuildPlan()
    {
        if (_builder is BasicPlanBuilder)
        {
            BuildBasicPlan();
        }
        else if (_builder is EnterprisePlanBuilder)
        {
            BuildEnterprisePlan();
        }
    }

    private void BuildBasicPlan()
    {
        _builder.BuildDiskSpaceFeature();
        _builder.BuildDatabaseFeature();
        _builder.BuildBandwidthFeature();
    }

    private void BuildEnterprisePlan()
    {
        _builder.BuildDiskSpaceFeature();
        _builder.BuildDatabaseFeature();
        _builder.BuildBandwidthFeature();
        _builder.BuildSslFeature();
    }
}
