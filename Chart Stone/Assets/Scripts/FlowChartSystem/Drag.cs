using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    public static Drag instance;
    public Item item;
    public bool isDrag;
    public void Awake()
    {
        instance = this;
    }

    public void OnDrag()
    {
        isDrag = true;
    }
    

}
