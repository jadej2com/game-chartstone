using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button removeButton;
    public TextMeshProUGUI Text;
    public TextMeshProUGUI work;
    [HideInInspector] public Item item;
    [HideInInspector] public int stock;

    private void Start()
    {
        Text.text = "";
    }
    public void AddItem(Item newItem)
    {
      
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
        work.text = item.process;
       
    }
    public void  AddQuantity(int value)
    {
        if(value > 1)
        {
            stock = value;
            Text.text = stock.ToString();
        }
        else
        {
            Text.text = "";
        }
        
    }


    public void ClearSlot()
    {
        item = null;
        icon.enabled = false;
        removeButton.interactable = false;
        Text.text = "";
        work.text = "";
    }

    public void RemoveItemFromIventory()
    {
        ConfirmRemove.instance.items(item , stock);
        ConfirmRemove.instance.OnGUIna();


    }

    
    
    
    public void UseItem()
    {
        if(item!= null)
        {
            item.Use();
        }
    }
}
