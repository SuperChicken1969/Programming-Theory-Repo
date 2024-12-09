using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text speedoText;
    [SerializeField] Text rpmText;

    [SerializeField] Vehicle vehicle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplaySpeed();
        DisplayRpm();
    }

    void DisplaySpeed()
    {

        speedoText.text = vehicle.speed + " mph";
    }

    void DisplayRpm()
    {
        rpmText.text = vehicle.rpm + " rpm";
    }
}
