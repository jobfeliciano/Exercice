using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exo_Collision3 : MonoBehaviour
{
    [SerializeField] private Collision2 sphereBlanche;
    [SerializeField] private Exo_Collision3 sphereNoire;

    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float _speed;
    private Vector3 _direction = new Vector3(0,0,0);
  
    
    // Update is called once per frame
    void Update()
    {
        float x_direction = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            sphereBlanche.enabled= false;
            sphereNoire.enabled= true;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            sphereBlanche.enabled= true;
            sphereNoire.enabled= false;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x_direction = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            x_direction = 1;
        }
        else { x_direction = 0; }

        _direction = new Vector3(x_direction, 0, 0).normalized;
        rigidbody.velocity = _direction * _speed;
    }
}
