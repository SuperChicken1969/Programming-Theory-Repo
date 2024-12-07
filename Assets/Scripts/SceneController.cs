using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    //changes
    int vehicleType;
    int sceneNumber = 0;

    private void Update()
    {
        sceneNumber = vehicleType;
    }

    public void SelectVehicle(int vehicleNumber)
    {
        vehicleType = vehicleNumber;
    }
    public void NewScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void ExitProgram()
    {
        Application.Quit();
    }
}
