using System;
using UnityEngine;
using UnityEngine.UI;

public class SetParameters : MonoBehaviour, ISubscribe
{
    public event Action< ParmentrsSpawn> ChangeDataEvent;

    private Dicraction _diraction = Dicraction.Default;
  
    [SerializeField] private Applay _applay;
    [SerializeField] private InputField _distance;
    [SerializeField] private InputField _speed;
    [SerializeField] private InputField _timeRepaet;

    public void SetDiraction(int diraction)
    {
        _diraction = (Dicraction)diraction;
    }
    private void Init()
    {
        _distance.contentType = InputField.ContentType.IntegerNumber;
        _speed.contentType = InputField.ContentType.IntegerNumber;
        _timeRepaet.contentType = InputField.ContentType.IntegerNumber;
    }
    public void Subscribe()
    {
        Init();
        _applay.SettingApplaye.onClick.AddListener(()=>
        {
            ApplayParameters();
        });
    }

    public void UnSubscribe()
    {
        _applay.SettingApplaye.onClick.RemoveListener(() =>
        {
            ApplayParameters();
        });
    }
    private void ApplayParameters()
    {
        float? dist = float.Parse(_distance.text);
        float? speed = float.Parse(_speed.text);
        float? time = float.Parse(_timeRepaet.text);
        if (speed == 0 || dist == 0 | time == 0)//????????
            return;
        ParmentrsSpawn spawn = new ParmentrsSpawn((float)dist, (float)speed, (float)time,_diraction);
        ChangeDataEvent?.Invoke(spawn);
    }
}
