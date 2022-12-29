using PlanBuilderPattern.Builders;

namespace PlanBuilderPattern.Directors;

public interface IPlanDirector
{
    void SetPlanBuilder(IPlanBuilder builder);
    void BuildPlan();
}
