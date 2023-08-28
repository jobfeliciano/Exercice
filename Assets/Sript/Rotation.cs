using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 10;
    [SerializeField] private float _changeScaleSpeed = 1;

    private float _Angle;

    private void Update()
    {
        ControlRotation();
        ControlSize();
    }

    private void ControlRotation()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, 0, _rotationSpeed)*Time.deltaTime;
            transform.Rotate( new Vector3(0, 0, _rotationSpeed) * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, 0, _rotationSpeed)*Time.deltaTime;
        }

    }

    private void ControlSize()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localScale += new Vector3(1, 1, 1)*_changeScaleSpeed*Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.localScale -= new Vector3(1, 1, 1) * _changeScaleSpeed * Time.deltaTime;
        }
    }
}
