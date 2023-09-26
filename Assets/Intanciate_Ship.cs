using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Intanciate_Ship : MonoBehaviour
{

    [SerializeField] GameObject _prefab;
    [SerializeField] private float _yPositionRange = 3f;
    [SerializeField] private float _timeRange = 15f;
    [SerializeField] private Ship_Remaining _shipRemaining;
    [SerializeField] private GameObject _defaite;
    [SerializeField] private GameObject _victoire;
    private float _timer;
    private float _spawnTime;
    private float _randomYPosition;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _spawnTime)
        { _spawnTime = Random.Range(0, _timeRange);
            _randomYPosition = Random.Range(-_yPositionRange,_yPositionRange);

            GameObject newObject = Instantiate(_prefab,transform.position+new Vector3(0,_randomYPosition,0),transform.rotation);
            newObject.GetComponent<Escaping_Ship>().InitializedVelocity();
            newObject.GetComponent<Escaping_Ship>().SetRemainingShip(_shipRemaining);
            _shipRemaining.ConditionVictoire(_victoire,_defaite);
            _timer = 0;
        }

        if (_victoire.activeInHierarchy)
            gameObject.SetActive(false);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position, new Vector3(0.5f, 2 * _yPositionRange, 0));
    }
}
