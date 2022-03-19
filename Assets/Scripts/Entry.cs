using System.Collections.Generic;
using UnityEngine;

public class Entry : MonoBehaviour
{
    [SerializeField] private MonoBehreferance _refaranse;

    private Data _data;
    private List<IUpDate> _update;
    private List<ISubscribe> _subscribes;
    private Spawner _spawner;
         
    private void Awake()
    {
        _update = new List<IUpDate>();
        _subscribes = new List<ISubscribe>();
        _data = new Data(_refaranse);
        _spawner = new Spawner(_data);
        Init();
    }

    private void Init()
    {
        UpdateComponetns();
        Subscribe();
        foreach (var item in _subscribes)
        {
            item.Subscribe();
        }
    }
    private void UpdateComponetns()
    {
        _update.Add(_spawner);
    }
    private void Subscribe()
    {
        _subscribes.Add(new InputUI(_data));
        _subscribes.Add(_spawner);
    }
    private void Update()
    {
        foreach (var item in _update)
        {
            item.Execute();
        }
    }
}
