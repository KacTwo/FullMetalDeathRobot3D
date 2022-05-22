using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpItem : MonoBehaviour
{
   
     void Update()
    {

    }
    


    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // niszczy obiekt
        {
            FindObjectOfType<SoundManager_script>().Play("coinsfx");

            Destroy(gameObject);

        }
    }

}


