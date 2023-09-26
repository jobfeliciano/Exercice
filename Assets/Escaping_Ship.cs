using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Compilation;
using UnityEngine;
using UnityEngine.UI;

public class Escaping_Ship : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;
    [SerializeField] private GameObject _prefab;
    private Ship_Remaining _shipRemaining;


    public void InitializedVelocity()
    {
        
        GetComponent<Rigidbody2D>().velocity = transform.right*_speed;

        Destroy(gameObject,38f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name!= "Collider")
        {
            _shipRemaining.DestroyedShip();
            GameObject newGameObject = Instantiate(_prefab, transform.position, Quaternion.identity);
            Destroy(newGameObject, 3);
            Destroy(gameObject);
        }

    }

    public void SetRemainingShip(Ship_Remaining ship_Remaining)
    {
        _shipRemaining = ship_Remaining;
    }
}
