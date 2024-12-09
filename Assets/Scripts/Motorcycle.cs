using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Motorcycle : Vehicle
{
    [SerializeField] GameObject centerOfMass;

    float maxLeanAngle = 40f;
    float leaningForce = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
        steering = leaningForce;
        horsePower = 5f;
    }

    private void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");
        steering = leaningForce;
        Telemotry();
    }

    void FixedUpdate()
    {
        MoveVehicle();
        if(horizontalInput != 0f)
        {
            TurnVehicle();
        }
        
    }

    protected override void TurnVehicle()
    {
        //base.TurnVehicle();

        //check if within max lean angle
        if(transform.rotation.eulerAngles.z >= maxLeanAngle || transform.rotation.eulerAngles.z <= 360 - maxLeanAngle)
        {
            //if outside max lean zone only lean to be within the max lean angle
            if(transform.rotation.eulerAngles.z - horizontalInput <= maxLeanAngle 
                || transform.transform.eulerAngles.z - horizontalInput >= 360 - maxLeanAngle)
            {
                transform.Rotate(-Vector3.forward * Time.deltaTime * steering * horizontalInput);
            }
        }
        else
        {
            transform.Rotate(-Vector3.forward * Time.deltaTime * steering * horizontalInput);
        }
        
        //follow curve based on lean angle
        transform.Rotate(-Vector3.up * transform.rotation.z * Time.deltaTime * leaningForce);
    }

    protected override void MoveVehicle()
    {
        //Move vehicle forward
        base.MoveVehicle();
    }
}
