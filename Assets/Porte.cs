using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour
{
    public float _amplitude = 5f;
    public float _changeScaleSpeed = 1f;

    private Vector3 _newScale;
    private float _startScaleY;

    // Start is called before the first frame update
    void Start()
    {
        _startScaleY = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        _newScale.y = _startScaleY + _amplitude * Mathf.Sin(_changeScaleSpeed * Time.time);
        transform.localScale = _newScale;
    }
}
