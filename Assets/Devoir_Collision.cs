using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devoir_Collision : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    public GameObject sortie;
 
    private void OnTriggerEnter(Collider other)
    {
        sortie.SetActive(false);
    }

}
