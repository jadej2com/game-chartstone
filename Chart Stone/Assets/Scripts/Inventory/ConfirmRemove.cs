using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfirmRemove : MonoBehaviour
{
    [SerializeField] public GameObject ConfirmUI;
    [SerializeField] public Image icon;
    [SerializeField] public TextMeshProUGUI Text;
    [SerializeField] public TextMeshProUGUI work;

    public static ConfirmRemove instance;
    Item item1;
    int stock;
    void Start()
    {
        instance = this;
    }

    public void OnGUIna()
    {
        ConfirmUI.SetActive(true);
        icon.sprite = item1.icon;
        work.text = item1.process;
        if(stock > 1)
        {
            Text.text = stock.ToString();

        }
        else
        {
            Text.text = "";

        }


    }

    public void ConfirmRemoved()
    {
        Inventory.instance.Remove(item1);
       ConfirmUI.SetActive(false);
    }

    public void  items(Item item , int value)
    {
        item1 = item;
        stock = value;

    }


    public void CancelRemoved()
    {
       
        ConfirmUI.SetActive(false);
    }
}
