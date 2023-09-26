using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldLookAt : MonoBehaviour
{

    [SerializeField] private SpriteRenderer _renderer;
    private float _delay = 5f;

    public void ShieldFadeOut(float shieldTimer)
    {
        if (shieldTimer <= _delay)
        {
            _renderer.color = new Color(1f, 1f, 1f, 1 - shieldTimer / _delay);
        }  
    }

    public void LookAt(Transform target)
    {
        transform.up = target.position - transform.position;

    }
}
