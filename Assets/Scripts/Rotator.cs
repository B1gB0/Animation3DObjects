using UnityEngine;


public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _rotation = new Vector3(0f, 1f, 0f);

    private void Update()
    {
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
