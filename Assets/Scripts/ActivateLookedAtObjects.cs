using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLookedAtObjects : MonoBehaviour
{
    // This script MUST go on the first person controller's camera
    // game object.
    [SerializeField]
    private float maxDistanceToCheckForObjects = 4.0f;

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * maxDistanceToCheckForObjects, Color.red);

        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, transform.forward, 
            out raycastHit, maxDistanceToCheckForObjects))
        {
            Debug.Log(raycastHit.transform.name + " is being looked at!!!!");

            IActivatable lookedAtObject = raycastHit.transform.GetComponent<IActivatable>();

            if (lookedAtObject != null && Input.GetButtonDown("Activate"))
            {
                Debug.Log("This is an IActivatable!");
                lookedAtObject.DoActivate();
            }
        }
    }



}
