using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectFormInventory : MonoBehaviour
{
    private float lastClicktime;
    [SerializeField]private const float DOUBLE_CLICK_TIME = 0.2f;
    InventorySlot inventorySlot;
    [SerializeField] private Canvas area;
    Transform _tranform;
    UIC_Manager _uicManager;
    private void Awake()
    {
        inventorySlot = GetComponent<InventorySlot>();
        _tranform = GetComponent<Transform>();
        _uicManager = GetComponentInParent<UIC_Manager>();
    }
    

    public void GetClick()
    {
        float timeSinelastClick = Time.time -lastClicktime;
        if(timeSinelastClick <= DOUBLE_CLICK_TIME)
        {
           if(inventorySlot.item != null)
            {
                if(inventorySlot.item.name == "Function Unlock")
                {
                    //var clone = Instantiate(FlowchartAtive.instance.Function_Unlock, FlowchartAtive.instance.parent.transform);
                   // clone.transform.position = new Vector3(FlowchartAtive.instance.Function_Unlock.transform.position.x, _tranform.position.y);
                    //clone.name = inventorySlot.item.name;
                    Vector3 vector3 = new Vector3(FlowchartAtive.instance.Function_Unlock.transform.position.x, _tranform.position.y);
                    _uicManager.InstantiateEntityAtPosition(FlowchartAtive.instance.Function_Unlock , vector3);

                    Inventory.instance.SubItem(inventorySlot.item);
                }
            }
            //Debug.Log(_tranform.position.y);
            
        }
        
        lastClicktime = Time.time;
       
    }



}
