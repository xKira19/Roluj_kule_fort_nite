using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

    bool buttonOn = false;
    public Transform thisbutton;
    public Rigidbody trap;
    Vector3 buttonStartPosition;
    Vector3 trapStartPosition;

    void Start()
    {
        buttonStartPosition = thisbutton.position;
        trapStartPosition = trap.position;
    }
    void Update()
    {
        Vector3 buttonNewPosition;
        Vector3 trapNewPosition;
        if (buttonOn == true)
        {
            buttonNewPosition = buttonStartPosition - Vector3.up * 0.10f;
            trapNewPosition = trapStartPosition + Vector3.back * 2.5f;
        }
        else
        {
            buttonNewPosition = buttonStartPosition;
            trapNewPosition = trapStartPosition;
        }
        thisbutton.position = Vector3.Lerp(thisbutton.position, buttonNewPosition, Time.deltaTime * 8f);
        trap.position = Vector3.Lerp(trap.position, trapNewPosition, Time.deltaTime * 8f);
    }

    void FixedUpdate()
    {
        buttonOn = false;
    }

    void OnTriggerStay(Collider collision)
    {
        Debug.Log("bang");
        buttonOn = true;
    }



}
