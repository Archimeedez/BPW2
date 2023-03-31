using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private Transform PickUpPoint;
    private Transform player;
    private Transform storage;

    public float pickupDistance;
    public float forceMulti;

    public bool readyToThrow;
    public bool itemIsPicked;

    private Rigidbody rb;
        
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player").transform;
        PickUpPoint = GameObject.Find("PickUpPoint").transform;
        storage = GameObject.Find("Items").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E) && itemIsPicked == true && readyToThrow)
        {
            forceMulti += 300 * Time.deltaTime;
        }

        pickupDistance = Vector3.Distance(player.position, transform.position);

        if(pickupDistance <= 4)
        {
            if(Input.GetKeyDown(KeyCode.E) && itemIsPicked == false && PickUpPoint.childCount < 1)
            {
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<BoxCollider>().enabled = false;
                this.transform.position = PickUpPoint.position;
                this.transform.parent = GameObject.Find("PickUpPoint").transform;

                itemIsPicked = true;
                forceMulti = 0;
            }
        }

        if(Input.GetKeyDown(KeyCode.E) && itemIsPicked == true)
        {
            readyToThrow = true;

            if(forceMulti >= 1)
            {
                rb.AddForce(player.transform.forward * forceMulti);
                this.transform.parent = GameObject.Find("Items").transform;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<BoxCollider>().enabled = true;
                itemIsPicked = false;

                forceMulti = 0;
                readyToThrow = false;
            }

            forceMulti = 0;
            
        }


    }
}
