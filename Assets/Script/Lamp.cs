using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField] Light pointLight;
    [SerializeField] Light lightAmbient;
    
   public void TurnOnOffLight()
   {
        bool lightStatus = pointLight.enabled;
        if(lightStatus)
        {
            pointLight.enabled = false;
            lightAmbient.enabled = false;
        }
        else
        {
            pointLight.enabled = true;
            lightAmbient.enabled = true;
        }
   }
}
