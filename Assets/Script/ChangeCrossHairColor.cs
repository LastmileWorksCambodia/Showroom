using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCrossHairColor : MonoBehaviour
{
    [SerializeField] Image crossHair;
    [SerializeField] Color baseColor;
    [SerializeField] Color hoverColor;
    [SerializeField] float rayDistance = 20f;
    [SerializeField] LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        baseColor.a = 1;
        hoverColor.a = 1;
        crossHair.color = baseColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, rayDistance, layerMask))
            {
                if (hitInfo.collider.gameObject.tag == "Door" || hitInfo.collider.gameObject.tag == "Lamp")
                {
                    crossHair.color = hoverColor;
                }

                else
                {
                    crossHair.color = baseColor;
                }
            }
    }
}
