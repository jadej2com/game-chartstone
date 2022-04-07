using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryFlowGUI : MonoBehaviour
{
    public GameObject inventoryUI;
    public Transform itemParent;
    Inventory inventory;
    void Start()
    {
        inventory = Inventory.instance;
        inventory.OnItemChangedCallback += UpdateUI;
    }

    private void Awake()
    {
        Controller.instane.time1 = Time.time;

    }
    private void Update()
    {

        UpdateUI();
    }

    public void OpenInventory()
    {
        inventoryUI.SetActive(true);


    }

   
    public void CloseInventory()
    {
       
        inventoryUI.SetActive(false);
    }

    public void UpdateUI()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();

        int i = 0;
        foreach (var item in inventory.Dictionaryitems)
        {
            if (i < slots.Length)
            {
                if(item.Key.type.ToString() == "flowchart")
                {
                    slots[i].AddItem(item.Key);
                    slots[i].AddQuantity(item.Value);
                    i++;
                }
                
               

            }
        }



        for (int c = 0; c < slots.Length; c++)
        {
            if (c >= inventory.Dictionaryitems.Count-1)
            {
               
                slots[c].ClearSlot();

                
            }
        }
    }


}
