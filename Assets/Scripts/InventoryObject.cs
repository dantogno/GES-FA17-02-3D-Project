using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable
{
    [SerializeField]
    private string nameText;

    private InventoryMenu inventoryMenu;
    private MeshRenderer meshRenderer;
    private Collider collider;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        // Add this object to the inventory list
        inventoryMenu.PlayerInventory.Add(this);

        // hide it and remove collider so player cannot repeat
        // collect this object!
        collider.enabled = false;
        meshRenderer.enabled = false;
    }

    // Use this for initialization
    void Start ()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
        inventoryMenu = FindObjectOfType<InventoryMenu>();
	}
}
