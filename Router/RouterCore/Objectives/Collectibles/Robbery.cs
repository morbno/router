namespace RouterCore.Objectives.Collectibles;

public record Robbery
(
    string Name,
    string ImageB64
) : ICollectible;