using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Connector : FlowChart
{
    [Header("Text Header")]
    public string Text;

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
        if (inputs.Count > 1)
        {
            if (inputs.Count == 2)
            {
                isDone = inputIsDone[0];
            }

            for (int i = 0; i < inputs.Count; i++)
            {
               
                // Debug.Log(i);
                if (inputIsPlay[i] && isPlayed == false)
                    {
                    Debug.Log("Connecter i : "+i);
                        isPlay = inputIsPlay[i];
                        outValue = inputs[i];
                        variableA = inputsVariableA[i];
                        variableB = inputsVariableB[i];
                        variableC = inputsVariableC[i];
                        variableD = inputsVariableD[i];
                        Debug.Log("Variable A B C  D : " + inputsVariableA[1] + ":" + variableB + ":" + variableC + ":"+variableD);
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
