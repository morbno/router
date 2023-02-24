using RouterCore.Misc;

namespace RouterCore.Objectives;

public record Replay
(
    string Name,
    ReplayType Type
) : IObjective;