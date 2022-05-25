using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAnimationController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();




    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("IsShooting", true);
        }

        if (!Input.GetButton("Fire1"))
        {
            animator.SetBool("IsShooting", false);
        }




    }
}
