using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour {

    [SerializeField]
    private GameObject inventoryMenuPanel;

    private bool IsMenuOpen
    {
        get
        {
            return inventoryMenuPanel.activeSelf;
        }
    }

	// Use this for initialization
	void Start ()
    {
        HideMenu();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        HandleInput();	
	}

    private void HandleInput()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (IsMenuOpen)
                HideMenu();
            else
                ShowMenu();
        }
    }

    private void ShowMenu()
    {
        inventoryMenuPanel.SetActive(true);
        UpdateCursor();
    }

    private void HideMenu()
    {
        inventoryMenuPanel.SetActive(false);
        UpdateCursor();
    }

    private void UpdateCursor()
    {
        if (IsMenuOpen)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
