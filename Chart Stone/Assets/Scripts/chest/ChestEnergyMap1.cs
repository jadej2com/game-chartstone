using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestEnergyMap1 : MonoBehaviour
{
 


    // Start is called before the first frame update
    public GameObject chest;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Destroy(chest);
            BarPanel.instance.RecoverEnergy();
        }


    }




}
