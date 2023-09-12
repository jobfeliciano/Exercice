using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeVaisseau : MonoBehaviour
{
    [SerializeField] private float _acceleration = 0.5f;
    [SerializeField] private float _maxSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 30f;

    [SerializeField] private Rigidbody2D _rigidbody;
    private Vector3 _rotationVector;
    [SerializeField]  private float _speed;

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.UpArrow)) && (_speed < _maxSpeed))
        {
                _speed += _acceleration*Time.deltaTime;            
        }
        else if((Input.GetKey(KeyCode.DownArrow)) && (_speed > 0))
        {
                _speed -= _acceleration*Time.deltaTime;        
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rotationVector = new Vector3(0, 0, (-_rotationSpeed)) * Time.deltaTime;
            transform.Rotate(_rotationVector);
            
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rotationVector = new Vector3(0, 0, _rotationSpeed) *Time.deltaTime;
            transform.Rotate(_rotationVector);
        }

        _rigidbody.velocity = transform.up * _speed;
    }
}
