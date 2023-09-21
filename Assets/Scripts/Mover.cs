using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction = new Vector3(1, 0);
    private float _minDistance = 0f;
    private float _maxDistance = 5f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
        SetDirection();
    }

    private void SetDirection()
    {
        if(transform.position.x <= _minDistance || transform.position.x >= _maxDistance)
        {
            Vector3 direction = -_direction;
            _direction = direction;
        }
    }
}
