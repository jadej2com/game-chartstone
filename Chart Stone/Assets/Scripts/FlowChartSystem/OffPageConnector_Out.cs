using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OffPageConnector_Out : FlowChart
{
    [HideInInspector] public string Text;
    Text _text;
    protected override void Awake()
    {
        base.Awake();
        _text = transform.GetChild(0).GetComponentInChildren<Text>();

    }
    private void Update()
    {
        _text.text = Text;
    }
    public override void Solve()
    {
        base.Solve();
        if(isPlayed == false && isPlay)
        {
            if (entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out).Count > 0)
            {
                entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].GetComponent<FlowChart>().isPlayed = false;
                isPlayed = true;
            }
        }
    }
}
