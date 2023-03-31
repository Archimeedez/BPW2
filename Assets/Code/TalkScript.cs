using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkScript : MonoBehaviour
{
    Animator anim;
    private Transform PickUpPoint;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isTalking = anim.GetBool("IsTalking");
        bool isAngry = anim.GetBool("IsAngry");

        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetBool("IsTalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.V))
        {
            anim.SetBool("IsTalking", false);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetBool("IsAngry", true);
            //isAngry = true;
        }
        else if (Input.GetKeyUp(KeyCode.C) && (isAngry == true))
        {
            anim.SetBool("IsAngry", false);
        }
    }
}
