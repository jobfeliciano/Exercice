using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    private Vector3 _direction;
    private Boolean _isCollide = true;
    // Update is called once per frame
    void Update()
    {
        float x_direction = 0;
        float y_direction = _rigidbody.velocity.y;
        float force = 0;
        float y_rotation = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            y_rotation = 0;
            x_direction = 1;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            y_rotation = 180;
            x_direction = -1;
        }
        
        else if (Input.GetKeyDown(KeyCode.UpArrow)&&(_isCollide == true))
        {
               force = 400;
        }

        _rigidbody.AddForce(new Vector3(0, force,0));
        _direction = new Vector3(x_direction, 0, 0).normalized;
        transform.Rotate(0, y_rotation, 0);
        _rigidbody.velocity = _direction * _speed + new Vector3(0,y_direction,0);

      
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        _isCollide = true;
        Debug.Log("Collision");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isCollide = false;
        Debug.Log(" No Collision");
    }

}
