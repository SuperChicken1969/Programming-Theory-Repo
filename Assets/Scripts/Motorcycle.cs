using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Motorcycle : Vehicle
{
    [SerializeField] GameObject centerOfMass;
    [SerializeField] Text speedoText;
    [SerializeField] Text rpmText;

    public float speed { get; private set; } = 0f;
    public float rpm { get; private set; } = 0f;

    public float maxLeanAngle = 30f;
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
        speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
        speedoText.text = speed + " MPH";
        rpm = Mathf.Round((speed % 30) * 40) + 1200;
        rpmText.text = rpm + " RPM";

        Debug.Log(transform.rotation.eulerAngles.z);
    }

    void FixedUpdate()
    {
        MoveVehicle();
        if(horizontalInput != 0f)
        {
            TurnVehicle();
        }
        if (transform.rotation.z != 0f)
        {
            transform.Rotate(-Vector3.up * transform.rotation.z * Time.deltaTime * leaningForce);
        }
        
    }

    protected override void TurnVehicle()
    {
        //base.TurnVehicle();
        if(transform.rotation.eulerAngles.z >= maxLeanAngle || transform.rotation.eulerAngles.z <= 360 - maxLeanAngle)
        {
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
    }

    protected override void MoveVehicle()
    {
        //Move vehicle forward
        base.MoveVehicle();
    }
}
