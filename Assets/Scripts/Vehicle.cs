using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected Rigidbody playerRb;
    protected float horsePower;
    protected float verticalInput;
    protected float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void TurnVehicle() { }
    protected virtual void MoveVehicle() 
    {
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
    }
}
