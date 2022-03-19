using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Button))]
public class Applay : MonoBehaviour
{
    public Button SettingApplaye => _applay;
    [SerializeField] private Button _applay;
    public void Show()
    {
        _applay.gameObject.SetActive(true);
    }
    public void Close()
    {
        _applay.gameObject.SetActive(false);
    }
}
