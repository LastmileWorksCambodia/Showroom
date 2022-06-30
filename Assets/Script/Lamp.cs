using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField] Light pointLight;
   public void TurnOnOffLight()
   {
        bool lightStatus = pointLight.enabled;
        if(lightStatus)
        {
            pointLight.enabled = false;
        }
        else
        {
            pointLight.enabled = true;
        }
   }
}
