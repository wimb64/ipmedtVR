using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoor : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    //void Update()
    //{
       
    //}

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            animator.SetTrigger("open");
        }
         
    }

}
