using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestEnergy : MonoBehaviour
{


    // Start is called before the first frame update
    public GameObject chest;
    public GameObject btnON;
   

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            Destroy(chest);
            btnON.SetActive(true);
            BarPanel.instance.RecoverEnergy();
        }
        

    }


}
