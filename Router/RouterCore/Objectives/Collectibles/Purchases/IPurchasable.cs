namespace RouterCore.Objectives.Collectibles.Purchases;

public interface IPurchasable : ICollectible
{
    public int Cost { get; init; }
}