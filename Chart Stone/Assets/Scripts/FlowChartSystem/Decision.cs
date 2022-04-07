using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decision : FlowChart
{
    [Header("Text Header")]
    public string Text;

    enum WorkType { AgreaterThanB, lessThan, equal }
    [Header("Work To Do")]
    [SerializeField] WorkType workType;
    Text _text;
    protected override void Awake()
    {
        base.Awake();
        _text = transform.GetChild(0).GetComponentInChildren<Text>();
        entity = GetComponent<UIC_Entity>();

    }

    private void Update()
    {
        _text.text = Text;
      

    }
    public override void Solve()
    {

        

        base.Solve();
        if(inputs.Count > 0)
        {
            isDone = inputIsDone[0];
            isPlay = inputIsPlay[0];
            if (isPlay && isPlayed == false)
            {
                

                outValue = inputs[0];
                variableA = inputsVariableA[0];
                variableB = inputsVariableB[0];
                variableC = inputsVariableC[0];
                variableD = inputsVariableD[0];
                if (workType.ToString() == "AgreaterThanB")
                {
                    

                    if (variableA > variableB && entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out).Count > 0)
                        {
                        //entity.nodeList[2].GetComponent<UIC_Node>().connectionsList[0].node1.polarityType = UIC_Node.PolarityTypeEnum._all;
                        entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].GetComponent<FlowChart>().isPlayed = false;
                        //Debug.Log( entity.name+"" +entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].GetComponent<FlowChart>().name);
                        isPlayed = true;
                        Debug.Log("TRUE");
                        }
                        else if(variableA <= variableB && entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out).Count > 0)
                        {
                            Debug.Log("FALSE");
                         //entity.nodeList[1].GetComponent<UIC_Node>().connectionsList[0].node1.polarityType = UIC_Node.PolarityTypeEnum._all;
                            entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[1].GetComponent<FlowChart>().isPlayed = false;
                        isPlayed = true;
                        }   

                   

                }
            }

           
        }
        else
        {
            outValue = -9999.99f;
            variableA = -9999;
            variableB = -9999;
            variableC = -9999;
            variableD = -9999;
            return;
        }
    }
}
