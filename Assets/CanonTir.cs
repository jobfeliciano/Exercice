using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonTir : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    [SerializeField] private float _randomDelayMax = 3f;
    [SerializeField] private float _spawnSpeed = 3f;

    private float _timer;
    private float _delay = 3f;

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _delay)
        {
            _delay = Random.Range(0f, _randomDelayMax);
            GameObject newGameObject = Instantiate(_prefab, transform.position, transform.rotation);
            newGameObject.GetComponent<Laser>().InitializeVelocity();
            _timer = 0;
        }
    }
}
