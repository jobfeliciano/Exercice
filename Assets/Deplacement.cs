using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public float _amplitude = 5f;
    public float _speed = 1f;



    private float _startPosY;
    private Vector3 _newPos;
    // Start is called before the first frame update
    void Start()
    {
        _startPosY = transform.position.y;
    }



    // Update is called once per frame
    void Update()
    {
        _newPos.y = _startPosY + _amplitude * Mathf.Sin(_speed * Time.time);
        transform.position = _newPos;
    }
}
