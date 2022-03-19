using System;

public class Data
{
    public event Action<ParmentrsSpawn> DataUpdata;

    public readonly MonoBehreferance _referance;
    public Data(MonoBehreferance referance)
    {
        _referance = referance;
    }
    public void DataUpDate(ref ParmentrsSpawn parmentrs)
    {
        DataUpdata?.Invoke(parmentrs);
    }
}
