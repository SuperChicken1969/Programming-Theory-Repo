using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public float speed { get; private set; } = 0f;
    public float rpm { get; private set; } = 0f;

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
    }

    private void FixedUpdate()
    {
        MoveVehicle();
    }

    protected override void MoveVehicle()
    {
        base.MoveVehicle();
    }
}
