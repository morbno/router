namespace RouterCore.Objectives.Collectibles.Purchases;

public record Asset
(
    int Id, 
    string Name,
    string ImageB64,
    int Cost, 
    int Revenue
) : IPurchasable;
