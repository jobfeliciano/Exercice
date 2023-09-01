using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solair : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    private Vector3 _rot = new Vector3(0,0,0);
    private float _yAngleAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, _speed, 0) * Time.deltaTime*30);
    }
}
