using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private Vector3 _direction = new Vector3(0, 0, 0);
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
       


        transform.position += _direction * _speed * Time.deltaTime;
    }
}
