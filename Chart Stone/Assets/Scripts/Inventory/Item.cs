using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool showIntenvory = true;
    public enum Type {flowchart , other }
    [Header("Detail")]
    [SerializeField]public Type type;
    [SerializeField]public string process;

    //คำสั่งเวลาใช้ item
    public void Use()
    {
        ShowDetaill.instance.name.text = name;
        ShowDetaill.instance.icon.sprite = icon;
        if (type.ToString() == "flowchart")
        {
            if (name.Equals("Function Unlock"))
            {
                ShowDetaill.instance.work.text = process;
                ShowDetaill.instance.detail.text = "โปรแกรมปลดล็อคด่าน เป็นโปรแกรมย่อย ซึ่งจะทำงานเมื่อถูกเรียกใช้";
            }else if(name.Equals("Process A+B"))
            {
                ShowDetaill.instance.work.text = process;
                ShowDetaill.instance.detail.text = "เป็นกระบวนการคำนวน ตัวแปร A บวกกับ ตัวแปร B ";
            }
        }
        else
        {
            if (name.Equals("Electric"))
            {   
                ShowDetaill.instance.work.text = "";
                ShowDetaill.instance.detail.text = "กดใช้เพิ่มพลังงานไฟฟ้า ไอเท็มนี้จะสามารถใช้ได้ก็ต่อเมื่อมีพลังงานไฟฟ้าน้อยกว่า 100";
            }
        }
       
       
        ShowDetaill.instance.showDetail();



    }

    public void RemoveItemFromIventory()
    {
        Inventory.instance.Remove(this);
    }

}
