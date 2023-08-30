using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAvecRigiBody : MonoBehaviour
{
    [SerializeField] private float _speed;



    private Vector3 _direction = new Vector3(0, 0, 0);
    [SerializeField] private Rigidbody rigidbody;




    // Update is called once per frame
    void Update()
    {
        float x_direction = 0;
        float z_direction = 0;



        if (Input.GetKey(KeyCode.W))
        {
            z_direction = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z_direction = -1;
        }
        else
        {
            z_direction = 0;
        }



        if (Input.GetKey(KeyCode.D))
        {
            x_direction = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            x_direction = -1;
        }
        else
        {
            x_direction = 0;
        }

        _direction = new Vector3(x_direction, 0, z_direction).normalized;
        rigidbody.velocity = _direction * _speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On Collison Enter");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Oncollision Exit");
    }



    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Debug.Log("OnTriggerEnter");
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OntriggerExit");
    }
}
