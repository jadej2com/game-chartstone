using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnScreenKeyboad : MonoBehaviour
{
    bool StratDrag;
    public Text text;
    string getText;
    public int value;
    public GameObject Pointer;
    //public GameObject ioFlow;

   
    void Update()
    {
        //ioFlow.GetComponent<InputOutput>().isGetActive = true;

        if (StratDrag)
        {
            transform.position = Input.mousePosition;
        }
        
        if(getText != null)
        {
            value = int.Parse(getText);
            text.text = value.ToString();

        }else if(getText == null){
            value = 0;
            text.text = value.ToString();
        }
       


    }

   public void DeleteText()
    {
        if(text.text != null)
        {
            getText = null;
            
        }
    }

    public void StartDrag()
    {
        StratDrag = true;
    }

    public void StopDrag()
    {
        StratDrag = false;
    }

   public void Button1()
    {
        getText = getText + "1";
    }
    public void Button2()
    {
        getText = getText + "2";
    }
    public void Button3()
    {
        getText = getText + "3";
    }
    public void Button4()
    {
        getText = getText + "4";
    }
    public void Button5()
    {
        getText = getText + "5";
    }
    public void Button6()
    {
        getText = getText + "6";
    }

    public void Button7()
    {
        getText = getText + "7";
    }
    public void Button8()
    {
        getText = getText + "8";
    }
    public void Button9()
    {
        getText = getText + "9";
    }
    public void Button0()
    {
        getText = getText + "0";
    }
}
