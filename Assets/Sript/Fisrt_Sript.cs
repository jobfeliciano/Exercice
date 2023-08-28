using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisrt_Sript : MonoBehaviour
{
    /* private float _timer;
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Update is called once per frame
    void Start()
    {
        Debug.Log("Start");
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        Debug.Log(_timer);

    }*/
    //
    private void Update()
    {
        Debug.Log("Position: "+GetComponent<Transform>().position);
        Debug.Log("Rotation: " +GetComponent<Transform>().eulerAngles);
        Debug.Log("Scale: " + transform.localScale);
    }


}
