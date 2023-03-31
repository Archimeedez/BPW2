using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthMovement : MonoBehaviour
{
    public AudioLoudnessDetection detector;
    public float loudnessSensibility = 100;
    public float threshold = 0.1f;

    Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool istalking = anim.GetBool("IsTalking");
        bool isangry = anim.GetBool("IsAngry");

        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;

        //if(loudnessSensibility <= threshold)
       // {
        //    anim.SetBool("IsTalking", false);
        //}
        if(loudness <= threshold)
        {
            anim.SetBool("IsTalking", false);
        }
        else if(loudness > threshold)
        {
            anim.SetBool("IsTalking", true);
        }
        //anim.SetBool("IsTalking", true);

        //int i = (int)loudness;
        //myTextObj.text = "loudness =" + i;

    }
    private void OnDisable()
    {
        anim.SetBool("IsTalking", false);
    }
}
