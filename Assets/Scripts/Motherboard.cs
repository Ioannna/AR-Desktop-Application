using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motherboard : MonoBehaviour
{
    public float turnspeed = 100f;
    public float movespeed = 1f;

    // Update is called once per frame
    void Update()
    {
        //spin from keyboard(left, right)
        transform.Rotate(
            Vector3.up
            * turnspeed
            //for getting the input from keyboard(left or right)
            * (-Input.GetAxis("Horizontal")
            * Time.deltaTime)
        );

        //move from keyboard(up, down)
        transform.Translate(0f, 0f,
            movespeed
            //for getting the input from keyboard(up or down)
            * Input.GetAxis("Vertical")
            * Time.deltaTime
        );
    }
}
