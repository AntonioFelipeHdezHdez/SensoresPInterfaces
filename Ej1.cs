using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ej1 : MonoBehaviour
{
    public TextMeshProUGUI puntuacionText;
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();

        // GPS
        Debug.Log(Input.location.lastData.latitude);  
        Debug.Log(Input.location.lastData.longitude);
        Debug.Log(Input.location.lastData.altitude);

        // Aceleracion
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

    }
}
