using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : FlowChart
{

    public bool Play;
    protected override void Awake()
    {
        base.Awake();
        isPlayed = false;
        entity = GetComponent<UIC_Entity>();
    }

 

    public override void Solve()
    {


        isDone = true;
        if (isPlayed == false && Play)
        {
            int x = -9999;
            base.Solve();
            outValue = -9999.99f;
            isPlay = Play;

            
            variableA = x;
            variableB = x;
            variableC = x;
            variableD = x;

            if (entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out).Count > 0)
            {
                entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].GetComponent<FlowChart>().isPlayed = false;
                isPlayed = true;
            }
        }


        
       


    }
}
