using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparence : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    private float _bonusTimer;
    private float _delay = 10f;
    private float _rotation = 15;

    void Update()
    {
        _bonusTimer += Time.deltaTime;
        if (_bonusTimer <= _delay)
        {
            _renderer.color = new Color(1f, 1f, 1f, 1 - _bonusTimer / _delay);
        }
        else
            _bonusTimer = 0;

        transform.eulerAngles += new Vector3(0, 0, _rotation) * Time.deltaTime;
    }

    public void DestroyedObject()
    {
        Destroy(gameObject,10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
