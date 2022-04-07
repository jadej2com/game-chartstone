using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiButtons : MonoBehaviour
{
    public void OnButtonA()
    {
        int random = PopUpFlowchart.instance.randomNumber;
        if (PopUpFlowchart.instance.AnsA[random] == PopUpFlowchart.instance.Ans[random])
        {
            PopUpFlowchart.instance.RandomItem();

        }
        else
        {
            PopUpFlowchart.instance.Destroy();

        }


    }

    public void OnButtonB()
    {
        int random = PopUpFlowchart.instance.randomNumber;
        if (PopUpFlowchart.instance.AnsB[random] == PopUpFlowchart.instance.Ans[random])
        {
            PopUpFlowchart.instance.RandomItem();

        }
        else
        {
            PopUpFlowchart.instance.Destroy();

        }
    }
}
