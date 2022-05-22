using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin50 : PickUpItem
{
   
    [SerializeField] float coinValue = 0;
    protected override void OnTriggerEnter(Collider other)
    {
        GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore += coinValue;
        base.OnTriggerEnter(other);
    }
   
}
