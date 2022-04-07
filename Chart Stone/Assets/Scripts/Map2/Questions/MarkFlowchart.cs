using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkFlowchart : MonoBehaviour
{
    
    [SerializeField] Image Image;
    [SerializeField] Text textA;
    [SerializeField] Text textB;


    //public static MarkFlowchart instance;
    private void Update()
    {
        RamdomQuestions();
    }

    public void RamdomQuestions()
    {
        Image.sprite = PopUpFlowchart.instance.diceImages[PopUpFlowchart.instance.randomNumber];
        textA.text = PopUpFlowchart.instance.AnsA[PopUpFlowchart.instance.randomNumber];
        textB.text = PopUpFlowchart.instance.AnsB[PopUpFlowchart.instance.randomNumber];
        print(PopUpFlowchart.instance.randomNumber);
    }
   
   

    




}
