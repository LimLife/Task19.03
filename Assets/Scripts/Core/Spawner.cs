using UnityEngine;
public class Spawner : ISubscribe, IUpDate
{
    private Cube _prefab => _data._referance.Game.Cube;
    private float _repeatTime;
    private float _speed;
    private float _distance;
    private float _timeRepaet;
    private float _oneSeceond;
    private Dicraction _diraction;
    private readonly Data _data;

    public Spawner(Data data)
    {
        _data = data;
    }
    public void Execute()
    {
        if (_repeatTime == 0)
            return;
        Timer();
    }


    public void Subscribe()
    {
        _data.DataUpdata += Settings;
    }
    public void UnSubscribe()
    {
        _data.DataUpdata -= Settings;
    }

    private void Timer()
    {
        var deltaTime = Time.deltaTime;
        _oneSeceond += deltaTime;

        if (_oneSeceond >= 1f)
        {
            _oneSeceond -= 1;
            _timeRepaet -= 1;
        }
        if (_timeRepaet <= 0)
        {
            Spawn();
            _timeRepaet = _repeatTime;
        }
    }
    private void Spawn()
    {
        var cube = Object.Instantiate(_prefab, new Vector3(0, 0, 0), Quaternion.identity);
        cube.Init(_speed, _distance, _diraction);
    }
    private void Settings(ParmentrsSpawn parametrs)
    {
        _repeatTime = parametrs.TimeRepeat;
        _distance = parametrs.Distance;
        _speed = parametrs.Speed;
        _diraction = parametrs.Dicraction;
    }
}
