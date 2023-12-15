using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();

        // GPS
        Debug.Log(Input.location.lastData.latitude);  
        Debug.Log(Input.location.lastData.longitude);
        Debug.Log(Input.location.lastData.altitude);

        // Acelerómetro
        Debug.Log(Input.acceleration);

        // Velocidad angular
        Debug.Log(Input.gyro.rotationRate);

        // Brujula
        Debug.Log(Input.compass.trueHeading);

        Input.location.Stop();
    }

    // Update is called once per frame
    void Update()
    {

        // Orientacion del samurai?
        /*
        Quaternion attitude = AttitudeSensor.current.attitude.ReadValue();

        rotator.rotation = attitude;
        rotator.Rotate(0f, 0f, 180f, Space.Self);
        rotator.Rotate(90f, 180f, 0f, Space.World);

        transform.rotation = Quaternion.Euler(0, -Input.compass.trueHeading, 0);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotator.rotation, smoothing);
        */
        // Velocidad del samurai
        //Input.acceleration.z;
    }
}
