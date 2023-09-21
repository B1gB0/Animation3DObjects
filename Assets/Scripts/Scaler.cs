using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _maxScale = new Vector3(3f, 3f, 3f);
    private Vector3 _minScale = new Vector3(1f, 1f, 1f);
    private bool _isIncrease = true;

    private void Update()
    {
        SetScale();
    }

    private void SetScale()
    {
        if (_isIncrease)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, _maxScale, _speed * Time.deltaTime);

            if (transform.localScale == _maxScale)
                _isIncrease = false;
        }

        if (!_isIncrease)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, _minScale, _speed * Time.deltaTime);

            if (transform.localScale == _minScale)
                _isIncrease = true;
        }
    }
}
