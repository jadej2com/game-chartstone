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

    //����������� item
    public void Use()
    {
        ShowDetaill.instance.name.text = name;
        ShowDetaill.instance.icon.sprite = icon;
        if (type.ToString() == "flowchart")
        {
            if (name.Equals("Function Unlock"))
            {
                ShowDetaill.instance.work.text = process;
                ShowDetaill.instance.detail.text = "������Ŵ��ͤ��ҹ ����������� ��觨зӧҹ����Ͷ١���¡��";
            }else if(name.Equals("Process A+B"))
            {
                ShowDetaill.instance.work.text = process;
                ShowDetaill.instance.detail.text = "�繡�кǹ��äӹǹ ����� A �ǡ�Ѻ ����� B ";
            }
        }
        else
        {
            if (name.Equals("Electric"))
            {   
                ShowDetaill.instance.work.text = "";
                ShowDetaill.instance.detail.text = "����������ѧ�ҹ俿�� �������������ö�������������վ�ѧ�ҹ俿�ҹ��¡��� 100";
            }
        }
       
       
        ShowDetaill.instance.showDetail();



    }

    public void RemoveItemFromIventory()
    {
        Inventory.instance.Remove(this);
    }

}
