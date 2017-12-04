﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateLookedAtObjects : MonoBehaviour
{
    // This script MUST go on the first person controller's camera
    // game object.
    [SerializeField]
    private float maxDistanceToCheckForObjects = 4.0f;

    [SerializeField]
    private Text lookedAtObjectText;


    private IActivatable lookedAtObject;

    private void Update()
    {
        UpdateLookedAtObject();
        HandleInput();
    }

    private void UpdateLookedAtObject()
    {
        Debug.DrawRay(transform.position, transform.forward * maxDistanceToCheckForObjects, Color.red);

        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, transform.forward,
            out raycastHit, maxDistanceToCheckForObjects))
        {
            Debug.Log(raycastHit.transform.name + " is being looked at!!!!");

            lookedAtObject = raycastHit.transform.GetComponent<IActivatable>();

            // TODO: change looked at object text to reflect what we are looking at!

           
        }
    }

    private void HandleInput()
    {
        if (lookedAtObject != null && Input.GetButtonDown("Activate"))
        {
            Debug.Log("This is an IActivatable!");
            lookedAtObject.DoActivate();
        }
    }
}
