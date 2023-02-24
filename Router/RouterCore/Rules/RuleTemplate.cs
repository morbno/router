using RouterCore.Objectives;

namespace RouterCore.Rules;

public record RuleTemplate
(
    string Name, 
    Dictionary<IObjective, bool> RuleSet
);