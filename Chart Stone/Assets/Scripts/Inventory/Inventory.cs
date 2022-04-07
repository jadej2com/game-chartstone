using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int space = 18;
    [SerializeField]public Dictionary<Item, int> Dictionaryitems = new Dictionary<Item, int>();
    public static Inventory instance;


    private void Awake()
    {
        instance = this;
       
    }

    public delegate void OnItemChanged();
    public OnItemChanged OnItemChangedCallback;
    public void Add(Item item)
    {
        if (item.showIntenvory)
        {

           
            if (Dictionaryitems.Count >= space)
            {
                Debug.Log("Not enough room. " + Dictionaryitems.Count);
                return;
            }
            if (Dictionaryitems.ContainsKey(item))
            {
                Dictionaryitems[item]++;

            }
            else
            {
                Dictionaryitems.Add(item , 1);
            }



            if (OnItemChangedCallback != null)
            {
                OnItemChangedCallback.Invoke();
            }
        }
    }

    public void Remove(Item item)
    {
        Dictionaryitems.Remove(item);
    }

    public void SubItem(Item item)
    {
        Dictionaryitems[item]-=1;
       foreach (var item1 in Dictionaryitems)
        {

          
           if(item1.Value == 0)
            {
                Remove(item);
                return;
            }
        }
    }
   
}
