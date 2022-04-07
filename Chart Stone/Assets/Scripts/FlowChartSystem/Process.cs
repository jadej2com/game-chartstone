using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class Process : FlowChart
{
    [Header("Text Header")]
    public string Text;
    public int variabelDiv;
    enum WorkType { Sum , divide  , average , BsubtractA, AaddB ,AB , variabelA, variabelB, variabelC}
    [Header("Work To Do")]
    [SerializeField] WorkType workType;
    [SerializeField] private int A;
    [SerializeField] private int B;
    [SerializeField] private int C;
    [HideInInspector]public float result;
    Text _text;
   // private bool test = false;
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
                        Average = inputsAverage[0];
                        Sum = inputsSum[0];
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
                            
                            Average = Sum/ variabelDiv;

                        }
                        else if (workType.ToString() == "Sum")
                        {
                            Sum = variableA + variableB + variableC + variableD;
                        Debug.Log(Sum);
                            
                        }
                        else if (workType.ToString() == "divide")
                        {
                            outValue = inputs[0] / variabelDiv;
                            Debug.Log(" Ans: " + outValue);
                    }
                        else if (workType.ToString() == "BsubtractA")
                        {
                            variableC = variableB - variableA;
                            Debug.Log("test first" + variableC);
                               
                        }
                        else if (workType.ToString() == "AaddB")
                        {
                            variableC = variableA + variableB;
                       
                        }
                        else if (workType.ToString() == "AB")
                        {
                            variableA = A;                
                            variableB = B;

                        }
                        else if (workType.ToString() == "variabelA")
                        {
                            variableA = A;

                        }
                        else if (workType.ToString() == "variabelB")
                        {
                            variableB = B;

                        }
                        else if (workType.ToString() == "variabelC")
                        {
                            variableC = C;

                        }

                    if (entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out).Count > 0)
                       {
                           entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].GetComponent<FlowChart>().isPlayed = false;
                           //Debug.Log(entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].name);
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
