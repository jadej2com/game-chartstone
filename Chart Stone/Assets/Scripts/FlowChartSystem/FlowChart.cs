using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowChart : MonoBehaviour
{
    [HideInInspector] public UIC_Entity entity;
    [HideInInspector]
    public float outValue;
    [HideInInspector]
    public int variableA;
    [HideInInspector]
    public int Sum;
    [HideInInspector]
    public int Average;
    [HideInInspector]
    public int variableB;
    [HideInInspector]
    public int variableC;
    [HideInInspector]
    public int variableD;
    [HideInInspector]
    public bool isPlay;
    [HideInInspector]
    public bool isPlayed;
    [HideInInspector]
    public bool isDone;
    protected virtual void Awake()
    {
       
        entity = GetComponent<UIC_Entity>();
      
       
    }

   

    public virtual void UpdateConnections()
    {
       
    }

    [Header("Input Form Line Connection")]
    public List<float> inputs;
    public List<int> inputsVariableA;
    public List<int> inputsVariableB;
    public List<int> inputsVariableC;
    public List<int> inputsVariableD;
    public List<int> inputsSum;
    public List<int> inputsAverage;
    public List<bool> inputIsPlay;
    public List<bool> inputIsDone;

    public virtual void GetInput()
    {
        inputs = new List<float>();
        inputsVariableA = new List<int>();
        inputsVariableB = new List<int>();
        inputsVariableC = new List<int>();
        inputsVariableD = new List<int>();
        inputsAverage = new List<int>();
        inputsSum = new List<int>();
        inputIsPlay = new List<bool>();
        inputIsDone = new List<bool>();

        foreach (UIC_Entity inEntity in entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._in))
        {

            FlowChart inFlow = inEntity.GetComponent < FlowChart>();
           
                inputs.Add(inFlow.outValue);
                inputsVariableA.Add(inFlow.variableA);
                inputsVariableB.Add(inFlow.variableB);
                inputsVariableC.Add(inFlow.variableC);
                inputsVariableD.Add(inFlow.variableD);
                inputsAverage.Add(inFlow.Average);
                inputsSum.Add(inFlow.Sum);
                inputIsPlay.Add(inFlow.isPlay);
                inputIsDone.Add(inFlow.isDone);



        }

      



    }

    public virtual void Solve()
    {
        GetInput();

    }
}
