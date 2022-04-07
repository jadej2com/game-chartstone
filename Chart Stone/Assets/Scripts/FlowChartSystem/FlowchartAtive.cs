using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowchartAtive : MonoBehaviour
{
    public UIC_Entity Function_Unlock;
    public GameObject  parent;
    public static FlowchartAtive instance;

    private void Awake()
    {
        instance = this;
    }
    

}
