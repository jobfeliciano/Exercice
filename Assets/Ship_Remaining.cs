using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship_Remaining : MonoBehaviour
{
    [SerializeField] private Text _shiptxt;

    private int _valueShipLeft = 15;

   public void DestroyedShip()
    {
        _valueShipLeft--;
        if(_valueShipLeft <= 0 )
            _valueShipLeft = 0;
        _shiptxt.text = _valueShipLeft.ToString();
    }

    public void ConditionVictoire(GameObject victoire, GameObject defaite)
    {
        if( _valueShipLeft == 0)
        {
            defaite.SetActive(false);
            victoire.SetActive(true);
        }
    }
}
