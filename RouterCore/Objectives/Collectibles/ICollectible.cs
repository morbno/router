namespace RouterCore.Objectives.Collectibles;

public interface ICollectible : IObjective
{
    public string ImageB64 { get; init; }
}