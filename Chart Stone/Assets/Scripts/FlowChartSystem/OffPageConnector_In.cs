using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffPageConnector_In : FlowChart
{
    public string Text;
    public OffPageConnector_Out _Out;
    Text _text;
    protected override void Awake()
    {
        base.Awake();
        _text = transform.GetChild(0).GetComponentInChildren<Text>();
    }

    private void Update()
    {
        _text.text = Text;
        _Out.Text = Text;
    }
    public override void Solve()
    {
        base.Solve();

       

        if (inputs.Count > 0)
        {
            if(inputIsPlay[0] && isPlayed == false)
            {
                _Out.isPlay = inputIsPlay[0];
                _Out.outValue = inputs[0];
                _Out.variableA = inputsVariableA[0];
                _Out.variableB = inputsVariableB[0];
                _Out.variableC = inputsVariableC[0];
                _Out.variableD = inputsVariableD[0];
                _Out.isPlayed = false;
                isPlayed = true;
            }
           
        }
    }

    
}
