using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour {
    #region editor fields
    [SerializeField]
    private GameObject inventoryMenuPanel;
    #endregion

    #region private fields
    private List<InventoryObject> playerInventory;
    #endregion

    #region properties
    public List<InventoryObject> PlayerInventory
    {
        get
        {
            return playerInventory;
        }
    }
    private bool IsMenuOpen
    {
        get
        {
            return inventoryMenuPanel.activeSelf;
        }
    }

    #endregion

    // Happens before start.
    // Need to initialize inventory list early
    // so other things can access it in Start
    private void Awake()
    {
        playerInventory = new List<InventoryObject>();
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
