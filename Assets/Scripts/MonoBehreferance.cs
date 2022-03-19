using UnityEngine;

public class MonoBehreferance : MonoBehaviour
{
    public MBReferanceUI UI => _ui;
    public MBReferanceGame Game => _game;

    [SerializeField] private MBReferanceUI _ui;
    [SerializeField] private MBReferanceGame _game;
}
