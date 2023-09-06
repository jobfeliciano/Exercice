using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMouvement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody.velocity = new Vector2(1,0)*_speed;
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = transform.right* _speed;  
    }
}
