using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decompte : MonoBehaviour
{
    [SerializeField] private Text _text;
    private float increment = 0;
    public void Incrementation()
    {
        increment++;
        _text.text = increment.ToString();
    }
}
