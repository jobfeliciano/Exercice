using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defaite : MonoBehaviour
{
    [SerializeField] private GameObject _defaite;
    [SerializeField] private GameObject _victoire;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name.Equals("Escaping_ship(Clone)"))
        {
            _defaite.SetActive(true);
            _victoire.SetActive(false);
        }
    }
}
