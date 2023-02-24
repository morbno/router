namespace RouterCore.Objectives;

public record Mission
(
    int Id, 
    string Name, 
    string Note,
    int Reward,
    int? ParentAssetId = null,
    int? ParentPhoneCallId = null,
    int[]? ParentMissionsId = null
) : IContinuousObjective;