using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonTir : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _earth;

    [SerializeField] private float _randomDelayMax = 3f;
    [SerializeField] private float _spawnSpeed = 3f;

    private float _timer;
    /*[SerializeField] private float _nbDeplacement=-1f;
    private float _deplacement = 1f;*/
    private float _delay = 3f;
    private float _rotationSpeed = 45f;

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _delay)
        {
            _delay = Random.Range(0f, _randomDelayMax);
            GameObject newGameObject = Instantiate(_prefab, transform.position, transform.rotation);
            newGameObject.GetComponent<Laser>().InitializeVelocity();
            _timer = 0;

            /* if (_nbDeplacement < 0)
             {

                 _deplacement = 1f;
             }
             else if(_nbDeplacement > 5) {
                 _nbDeplacement -= 1;
                 _deplacement = - 1f;
             }
             _nbDeplacement += _deplacement;
             transform.position = transform.position + new Vector3(0, 0.1f*_deplacement, 0);
             _earth.transform.position = _earth.transform.position + new Vector3(0, 0.05f*_deplacement, 0);*/

        }
    }
}
