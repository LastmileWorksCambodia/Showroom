using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    [SerializeField] float rayDistance = 20f;
    [SerializeField] LayerMask layerMask;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, rayDistance, layerMask))
            {
                if (hitInfo.collider.gameObject.tag == "Lamp")
                {
                    if (hitInfo.collider.TryGetComponent<Lamp>(out Lamp lamp))
                    {
                        lamp.TurnOnOffLight();
                    }

                    Debug.Log("hit Lamp");
                }

                if (hitInfo.collider.gameObject.tag == "Door")
                {
                    if (hitInfo.collider.TryGetComponent<Door>(out Door door))
                    {
                        if (door.IsOpen)
                        {
                            door.Close();
                        }
                        else
                        {
                            door.Open(transform.position);
                        }
                    }
                    Debug.Log("hit Door");
                }

                else
                {
                    return;
                }
            }

            else
            {
                Debug.Log("hit nothing");
            }
        }
    }
}
