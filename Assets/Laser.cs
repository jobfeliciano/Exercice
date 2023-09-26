using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;

    public void InitializeVelocity()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * _speed;
        Destroy(gameObject, 20f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
