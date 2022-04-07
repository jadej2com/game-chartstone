using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PredefinedProcess : FlowChart
{
    [Header("Text Header")]
    public string Text;
    public int variabelDiv;
    enum WorkType { SumAB, average }
    [Header("Work To Do")]
    [SerializeField] WorkType workType;
    [HideInInspector] public float result;
    Text _text;
    private bool test = false;
    protected override void Awake()
    {
        base.Awake();
        _text = transform.GetChild(0).GetComponentInChildren<Text>();
        entity = GetComponent<UIC_Entity>();
        isPlayed = true;
    }

    private void Update()
    {
        _text.text = Text;


    }


    public override void Solve()
    {
        GetInput();


        if (inputs.Count > 0)
        {
            isDone = inputIsDone[0];
            if (isPlayed == false)
            {


                isPlay = inputIsPlay[0];
                if (isPlay)
                {
                    variableA = inputsVariableA[0];
                    variableB = inputsVariableB[0];
                    variableC = inputsVariableC[0];
                    variableD = inputsVariableD[0];
                    if (inputsVariableA[0] == -9999)
                    {
                        variableA = 0;
                    }
                    else if (inputsVariableB[0] == -9999)
                    {
                        variableB = 0;
                    }
                    else if (inputsVariableC[0] == -9999)
                    {
                        variableC = 0;
                    }
                    else if (inputsVariableD[0] == -9999)
                    {
                        variableD = 0;
                    }

                    if (workType.ToString() == "average")
                    {
                        outValue = (variableA + variableB + variableC + variableD) / variabelDiv;

                    }
                    else if (workType.ToString() == "SumAB")
                    {
                        outValue = variableA + variableB;

                        
                    }
           

                    if (entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out).Count > 0)
                    {
                        entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].GetComponent<FlowChart>().isPlayed = false;
                        Debug.Log(entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].name);
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
