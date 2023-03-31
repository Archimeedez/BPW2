using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBody : MonoBehaviour
{
    Animator anim;
    private Transform PickUpPoint;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        PickUpPoint = GameObject.Find("PickUpPoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        bool isrunning = anim.GetBool("IsRunning");
        bool isholding = anim.GetBool("IsHolding");
        


        //forward
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("IsRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("IsRunning", false);
        }

        //turning left
        if (Input.GetKeyDown(KeyCode.A) && (isrunning == false))
        {
            anim.SetBool("TurningLeft", true);
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("TurningLeft", false);
        }

        //turning right
        if (Input.GetKeyDown(KeyCode.D) && (isrunning == false))
        {
            anim.SetBool("TurningRight", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("TurningRight", false);
        }

        //going backwards
        if (Input.GetKeyDown(KeyCode.S) && (isrunning == false))
        {
            anim.SetBool("IsBack", true);
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("IsBack", false);
        }

        //holding
        if (PickUpPoint.childCount == 1)
        {
            anim.SetBool("IsHolding", true);
        }

        if (PickUpPoint.childCount == 0)
        {
            anim.SetBool("IsHolding", false);
        }
        //if (Input.GetKeyUp(KeyCode.E) && (isholding == true))
        //{
        //    anim.SetBool("IsHolding", false);
        //}


    }
}
