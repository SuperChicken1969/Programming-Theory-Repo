using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected Rigidbody playerRb;

    public float speed { get; protected set; }
    public float rpm { get; protected set; }
    protected float steering; //how sharply verhicle turns

    protected float horsePower;
    protected float verticalInput;
    protected float horizontalInput;

    protected virtual void TurnVehicle() 
    {
        transform.Rotate(Vector3.up * steering * Time.deltaTime);
    }
    protected virtual void MoveVehicle() 
    {
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
    }

    protected void Telemotry()
    {
        speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
        rpm = Mathf.Round((speed % 30) * 40) + 1200;
    }
}
