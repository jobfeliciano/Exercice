using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devoir_Collision : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    public GameObject sortie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    private void OnTriggerEnter(Collider other)
    {
        sortie.SetActive(false);
    }

}
