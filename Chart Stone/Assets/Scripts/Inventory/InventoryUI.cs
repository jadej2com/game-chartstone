using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUI;
    public GameObject otherCanvas;
    public Transform itemParent;
    Inventory inventory;
    private void Start()
    {
        inventory = Inventory.instance;
        inventory.OnItemChangedCallback += UpdateUI;
    }
    private void Update()
    {

        UpdateUI();
    }

    public void OpenInventory()
    {
        inventoryUI.SetActive(true);
        otherCanvas.SetActive(false);
    }

    public void CloseInventory()
    {
        otherCanvas.SetActive(true);
        inventoryUI.SetActive(false);
    }

    public void UpdateUI()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();

        int i = 0 ;
        foreach ( var item in inventory.Dictionaryitems)
        {
            if(i < slots.Length)
            {
                    slots[i].AddItem(item.Key);
                    slots[i].AddQuantity(item.Value);
                    i++;

            }
        }

        
        
        for (int c = 0; c < slots.Length; c++)
        {
            if (c >= inventory.Dictionaryitems.Count)
            {
                 slots[c].ClearSlot();
            }
        }
    }
}
