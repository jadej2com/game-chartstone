using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    public void OnButtonA()
    {
        int random = PopUpController.instance.randomNumber;
        if (PopUpController.instance.AnsA[random] == PopUpController.instance.Ans[random])
        {
          
            PopUpController.instance.RandomItem();

        }
        else
        {
            PopUpController.instance.Destroy();

        }


    }

    public void OnButtonB()
    {
        int random = PopUpController.instance.randomNumber;
        if (PopUpController.instance.AnsB[random] == PopUpController.instance.Ans[random])
        {
            PopUpController.instance.RandomItem();

        }
        else
        {
            PopUpController.instance.Destroy();

        }
    }
}
