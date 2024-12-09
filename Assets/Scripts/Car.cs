using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        steering = 5f;
        horsePower = 10f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");
        Telemotry();
    }

    private void FixedUpdate()
    {
        MoveVehicle();
        if(horizontalInput != 0f)
        {
            TurnVehicle();
        }
    }

    protected override void MoveVehicle()
    {
        playerRb.AddRelativeForce(Vector3.forward * Time.deltaTime * horsePower * verticalInput);
    }

    protected override void TurnVehicle()
    {
        base.TurnVehicle();
    }
}
