namespace RouterCore.Objectives;

//see: https://docs.google.com/spreadsheets/d/1nfhiojo6bTaSVzm-37X13PV7umr_bpZfQVaK87yC2G4/edit#gid=19888316
public record PhoneCall
(
    int Id, 
    string Name, 
    int Priority, 
    int[] RequiredParentMissionsId,
    int[]? OptionalParentMissionsId = null,
    int? OptionalMissionsCount = null,
    int? ParentPhoneCallId = null
) : IObjective;