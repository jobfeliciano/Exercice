using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    private float _delay = 1;

    private float _changeScaleSpeed = 1;
    private float _timer;
    private float _timerFade;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer < _delay)
        {   
            transform.localScale += new Vector3(0.20f, 0.20f, 0) * _changeScaleSpeed * Time.deltaTime;
        }
       else if(_timer>=_delay)
        { _timerFade += Time.deltaTime;
            if( _timerFade <= 2)
            _renderer.color = new Color(1f, 1f, 1f, 1 - _timerFade / 2); }
         
    }
}
