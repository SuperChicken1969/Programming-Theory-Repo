using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text speedoText;
    [SerializeField] Text rpmText;

    [SerializeField] Vehicle vehicle;
    [SerializeField] float speed;
    [SerializeField] float rpm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = vehicle.speed;
        rpm = vehicle.rpm;
    }

    void DisplaySpeed()
    {
        speedoText.text = speed + " mph";
    }

    void DisplayRpm()
    {
        rpmText.text = rpm + " rpm";
    }
}
