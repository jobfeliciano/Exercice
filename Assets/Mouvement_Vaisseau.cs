using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement_Vaisseau : MonoBehaviour
{
    [SerializeField] private float _acceleration = 10f;
    [SerializeField] private float _maxSpeed = 7f;
    [SerializeField] private float _rotationSpeed = 45f;

    [SerializeField] private Rigidbody2D _rigidbody;
    private Vector3 _rotationVector;
    [SerializeField]  private float _speed = 0f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.UpArrow)) && (_speed < _maxSpeed))
        {
            _speed += _acceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _speed -= _acceleration * Time.deltaTime;
            if(_speed < 0 ) 
                _speed= 0; 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rotationVector = new Vector3(0, 0, (-_rotationSpeed)) * Time.deltaTime;
            transform.Rotate(_rotationVector);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rotationVector = new Vector3(0, 0, _rotationSpeed) * Time.deltaTime;
            transform.Rotate(_rotationVector);
        }

        _rigidbody.velocity = transform.up * _speed;
    }
}
