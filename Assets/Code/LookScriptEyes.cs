using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScriptEyes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector2 turn;

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y -= Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        if (turn.x < -6)
        {
            turn.x = -6;
        }
        if (turn.x > 6)
        {
            turn.x = 6;
        }

        if (turn.y < -6)
        {
            turn.y = -6;
        }
        if (turn.y > 6)
        {
            turn.y = 6;
        }
    }
}
