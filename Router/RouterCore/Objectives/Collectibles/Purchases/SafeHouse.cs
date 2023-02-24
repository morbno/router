namespace RouterCore.Objectives.Collectibles.Purchases;

public record SafeHouse
(
    string Name, 
    string ImageB64,
    int Cost
) : IPurchasable;