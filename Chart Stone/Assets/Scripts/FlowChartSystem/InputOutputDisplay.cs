using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputOutputDisplay : FlowChart
{
    public GameObject outputGUI;
    public GameObject inputGUI;
    public string Text;
    enum Show { ShowOutValue,ShowA,ShowB,ShowC,ShowD,ShowSum,ShowAverage };
    [Header("What do you want to show?")]
    [SerializeField] Show show;
    Text _text;
    protected void Awake()
    {
        base.Awake();
        _text = transform.GetChild(0).GetComponentInChildren<Text>();
    }

    void Update()
    {
        _text.text = Text;


    }
    public override void Solve()
    {
        base.Solve();
        if (inputs.Count > 0)
        {
            isDone = inputIsDone[0];
            isPlay = inputIsPlay[0];
            if (isPlay && inputGUI.activeSelf == false && outputGUI.activeSelf == false)
            {
                if (isPlayed == false)
                {
                    outputGUI.SetActive(true);
                   // transform.GetChild(0).GetComponentInChildren<Text>().text = _text;

                    outValue = inputs[0];
                    Average = inputsAverage[0];
                    Sum = inputsSum[0];
                    variableA = inputsVariableA[0];
                    variableB = inputsVariableB[0];
                    variableC = inputsVariableC[0];
                    variableD = inputsVariableD[0];
                    if (show.ToString() == "ShowOutValue"  )
                    {
                        outputGUI.transform.GetChild(0).GetChild(1).GetComponentInChildren<Text>().text = outValue.ToString();

                    }
                    else if (show.ToString() == "ShowA")
                    {
                        outputGUI.transform.GetChild(0).GetChild(1).GetComponentInChildren<Text>().text = variableA.ToString();
                    }
                    else if (show.ToString() == "ShowB")
                    {
                        outputGUI.transform.GetChild(0).GetChild(1).GetComponentInChildren<Text>().text = variableB.ToString();
                    }
                    else if (show.ToString() == "ShowC")
                    {
                        outputGUI.transform.GetChild(0).GetChild(1).GetComponentInChildren<Text>().text = variableC.ToString();
                    }
                    else if (show.ToString() == "ShowD")
                    {
                        outputGUI.transform.GetChild(0).GetChild(1).GetComponentInChildren<Text>().text = variableD.ToString();
                    }
                    else if (show.ToString() == "ShowSum")
                    {
                        outputGUI.transform.GetChild(0).GetChild(1).GetComponentInChildren<Text>().text = Sum.ToString();
                    }
                    else if (show.ToString() == "ShowAverage")
                    {
                        outputGUI.transform.GetChild(0).GetChild(1).GetComponentInChildren<Text>().text = Average.ToString();
                    }
                    isPlayed = true;
                    if (entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out).Count > 0)
                    {
                        entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].GetComponent<FlowChart>().isPlayed = false;
                        Debug.Log(entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].name);
                       

                    }
                }
              
               
            }
          
       
           
        }
        else
        {
            int x = -9999;
            outValue = -9999.99f;
            variableA = x;
            variableB = x;
            variableC = x;
            variableD = x; ;
        }


    }


   
}
