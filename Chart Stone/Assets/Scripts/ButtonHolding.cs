using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHolding : MonoBehaviour
{
    public bool holding;
    public static ButtonHolding instance;
    void Start()
    {
        instance = this;
    }

   

    public void OnButtonDown()
    {
        holding = true;
    }

    public void OnButtonUp()
    {
        holding = false;
    }
}
