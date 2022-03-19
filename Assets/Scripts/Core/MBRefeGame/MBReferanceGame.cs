using UnityEngine;

public class MBReferanceGame : MonoBehaviour
{
    public Cube Cube => _cube;
    [SerializeField] private Cube _cube;

}
