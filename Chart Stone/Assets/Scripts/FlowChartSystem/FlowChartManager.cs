using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowChartManager : MonoBehaviour
{
    public UIC_Manager uicManager;

    void Update()
    {
        foreach (UIC_Entity entity in uicManager.EntityList)
        {
            FlowChart flow = entity.GetComponent<FlowChart>();
            flow.Solve();
            //flow.UpdateConnections();
        }
    }

   
}
