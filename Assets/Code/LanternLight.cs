using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternLight : MonoBehaviour
{
    public bool IsNight = true;

    public Material On;
    public Material Off;
    //public GameObject Lantern;

    Renderer rend;

    //public GameObject Object;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = On;
        //On.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsNight == true && (Input.GetKeyDown(KeyCode.P)))
        {
            IsNight = false;
            rend.sharedMaterial = Off;

        }

        else if (IsNight == false && (Input.GetKeyDown(KeyCode.P)))
        {
            IsNight = true;
            rend.sharedMaterial = On;
        }
    }
}
