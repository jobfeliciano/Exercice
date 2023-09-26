using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nbEnnemis : MonoBehaviour
{
   [SerializeField] private Text _ennemis ;
   [SerializeField] private GameObject _prefab;
    private float _nbEnnemis = 15;
    void Start()
    {
        _ennemis.text = _nbEnnemis.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
