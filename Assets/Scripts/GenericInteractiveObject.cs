using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInteractiveObject : MonoBehaviour, IActivatable
{
    public void DoActivate()
    {
        Debug.Log(transform.name + " was activated!");
    }

    // Use this for initialization
    void Start ()
    {
        DoActivate();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
