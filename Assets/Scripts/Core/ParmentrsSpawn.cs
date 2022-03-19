public struct ParmentrsSpawn
{
    public float Distance { get; private set; }
    public float Speed { get; private set; }
    public float TimeRepeat { get; private set; }
    public Dicraction Dicraction { get; private set; }
    public ParmentrsSpawn(float distanse, float speed, float timeRepeat, Dicraction dicraction)
    {
        Distance = distanse;
        Speed = speed;
        TimeRepeat = timeRepeat;
        Dicraction = dicraction;
    }
}
