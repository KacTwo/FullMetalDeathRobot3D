using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionGreen : PickUpItem
{
  /* do naprawy
    
    [SerializeField] float timeValue = 0;
    protected override void OnTriggerEnter(Collider other)
    {
        GameObject.Find("CountDownTimer").GetComponent<CountDownTimer>().currentTime += timeValue;
        base.OnTriggerEnter(other);
    }
  */
}
