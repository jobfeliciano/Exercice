using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private GameObject _prefabBonus1;
    [SerializeField] private GameObject _prefabBonus2;
    private float _randomYPosition;
    private float _randomXPosition;

    private float _timerBonus;
    private float _delay = 5f;
  

    void Update()
    {
        _timerBonus += Time.deltaTime;
        _randomXPosition = Random.Range(-8f, 8f);
        _randomYPosition = Random.Range(-5f, 8f);
        if ((_timerBonus > _delay) && (_timerBonus <= 15))
        {
            _delay = Random.Range(10f, 15f);
            GameObject newGameObject = Instantiate(_prefabBonus1, new Vector3(_randomXPosition,_randomYPosition,0), Quaternion.identity);
            newGameObject.GetComponent<Transparence>().DestroyedObject();
            _timerBonus = 15;

        }
        else if(_timerBonus > 30)
        {
            GameObject newGameObject = Instantiate(_prefabBonus2, new Vector3(_randomXPosition, _randomYPosition, 0), Quaternion.identity);
            newGameObject.GetComponent<Transparence>().DestroyedObject();
            _timerBonus = 0;
        }
    }
}
