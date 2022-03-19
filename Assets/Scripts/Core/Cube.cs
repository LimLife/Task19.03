using UnityEngine;

public class Cube : MonoBehaviour
{
    private float _speed;
    private float _distance;

    private Vector3 _diraction;
    public void Init(float speed,float distanse, Dicraction dicraction)
    {
        _speed = speed;
        _distance = distanse;
        switch (dicraction)
        {
            case Dicraction.Right:
                _diraction = Vector3.right;
                break;
            case Dicraction.Left:
                _diraction = Vector3.left;
                break;
            case Dicraction.Down:
                _diraction = Vector3.down;
                break;
            case Dicraction.Forward:
                _diraction = Vector3.forward;
                break;
            case Dicraction.Default:
                _diraction = Vector3.forward;
                break;           
        }
    }
    private void Move()
    {            
        transform.Translate(_speed * Time.deltaTime  * _diraction,Space.World);
        if (transform.position.z >= _distance)
            Destroy(gameObject);
    }
    private void Update()
    {
        Move();
    }

}
