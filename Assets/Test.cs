using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _acceleration = 0.5f;
    [SerializeField] private Rigidbody2D _rigidbody;
    private Vector3 _rotationVector;
    [SerializeField] private float _speed;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.RightArrow)) && (_speed < 2))
        {
            _speed += _acceleration;
        }
        else if ((Input.GetKey(KeyCode.DownArrow)) && (_speed > 0))
        {
            _speed -= _acceleration;
        }

        _rigidbody.velocity = transform.right * _speed;
    }
}

