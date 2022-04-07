using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScreenKeyboadGetValue : MonoBehaviour
{
    [HideInInspector] public bool isActive;
    [HideInInspector] public int _value = -9999;
    [HideInInspector] public int[] _value_;
    [HideInInspector] public bool isVariableAactive;
    [HideInInspector] public bool isVariableBactive;
    [HideInInspector] public bool isVariableCactive;
    [HideInInspector] public bool isVariableDactive;
    
    //ปุ่ม Enter ที่ on screen keyboard


    private void Start()
    {
        _value_ = new int[4];
        _value_[0] = -9999;
        _value_[1] = -9999;
        _value_[2] = -9999;
        _value_[3] = -9999;
    }

    public void OnGUIEnter()
    {
        isActive = false;
        _value = gameObject.GetComponentInChildren<OnScreenKeyboad>().value;

        gameObject.SetActive(false);
       if (isVariableAactive)
        {
            _value_[0] = _value;
            //_useVariableA = false;
            isVariableAactive = false;
           
        }
        if (isVariableBactive)
        {

            _value_[1] = _value;
            //_useVariableB = false;
            isVariableBactive = false;
        }
        if (isVariableCactive)
        {
            _value_[2] = _value;
           // _useVariableC = false;
            isVariableCactive = false;

        }
        if (isVariableDactive)
        {
            _value_[3] = _value;
            //_useVariableD = false;
            isVariableDactive = false;

        }
    }
}
