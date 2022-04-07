using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    UIC_Manager _uicManager;
    void Awake()
    {
        _uicManager = GetComponentInParent<UIC_Manager>();
       
    }
 
    public void OnDrop()
    {
        if (Drag.instance.isDrag)
        {
            Inventory.instance.Add(Drag.instance.item);

            for (int i = _uicManager.selectedUIObjectsList.Count - 1; i >= 0; i--)
            {
                _uicManager.selectedUIObjectsList[i].Remove();
            }

            Drag.instance.isDrag = false;
        }
        

    }


}
