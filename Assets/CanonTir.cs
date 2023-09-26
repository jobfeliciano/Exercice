using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanonTir : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _victoire;

    [SerializeField] private float _randomDelayMax = 2f;

    private float _timer;
    private float _delay = 3f;
    private float _angle = -60;
    private float _rotationSpeed = 30f;
    private float _direction=1;

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
        if ((_angle > -10))
        {
            _direction = -1;
        }
        else if (_angle < -110)
        {
            _direction = 1;
        }

        _angle += _rotationSpeed*_direction*Time.deltaTime;
        transform.eulerAngles = (new Vector3(0, 0, _angle));

        if (_victoire.activeInHierarchy)
            gameObject.SetActive(false);
    }
}
