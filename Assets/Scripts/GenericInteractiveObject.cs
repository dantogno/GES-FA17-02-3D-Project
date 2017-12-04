using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInteractiveObject : MonoBehaviour, IActivatable
{
    [SerializeField]
    private string nameText;
    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        Debug.Log(transform.name + " was activated!");
    }

    // Use this for initialization
    void Start ()
    {
  
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
