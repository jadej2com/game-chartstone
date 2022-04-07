using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIScroll : MonoBehaviour
{

    [SerializeField] Image Image;
    [SerializeField] Text textA;
    [SerializeField] Text title;
    [SerializeField] Text textB;
    [SerializeField] GameObject GUI;


    //public static MarkFlowchart instance;
    private void Update()
    {
        RamdomQuestions();
    }

    public void RamdomQuestions()
    {
        Image.sprite = PopUpController.instance.diceImages[PopUpController.instance.randomNumber];
        title.text = PopUpController.instance.title[PopUpController.instance.randomNumber];
        textA.text = PopUpController.instance.AnsA[PopUpController.instance.randomNumber];
        textB.text = PopUpController.instance.AnsB[PopUpController.instance.randomNumber];
       
    }

    public void CloseGUI()
    {
        GUI.SetActive(false);
    }








}
