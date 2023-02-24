using RouterCore.Misc;

namespace RouterCore.Objectives.Collectibles;

public record Rampage
(
    string Name, 
    WeaponType Weapon
): IContinuousObjective;