using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputOutput : FlowChart
{

    public bool _useVariableA;
    public bool _useVariableB;
    public bool _useVariableC;
    public bool _useVariableD;
   // public bool test;
    public string Text;
    public GameObject inputGUI;
    public GameObject outputGUI;
    [HideInInspector]public bool isGetActive;
    Text _text;
    [HideInInspector]public int  _value = -9999;
    [HideInInspector]public int[]  _value_;
    [HideInInspector]public bool isVariableAactive;
    [HideInInspector]public bool isVariableBactive;
    [HideInInspector]public bool isVariableCactive;
    [HideInInspector]public bool isVariableDactive;
    protected override void Awake()
    {
        base.Awake();
        entity = GetComponent<UIC_Entity>();
        _text = transform.GetChild(0).GetComponentInChildren<Text>();
   
        isVariableAactive = _useVariableA;
        isVariableBactive = _useVariableB;
        isVariableCactive = _useVariableC;
        isVariableDactive = _useVariableD;

    }
    
    
    public override void Solve()
    {
       
        base.Solve();

        //��Ǩ�ͺ�����������
        if (inputs.Count > 0 )
        {
            isDone = inputIsDone[0];
            isPlay = inputIsPlay[0];
            //��Ǩ�ͺ�����Ẻ input ���� output ��е�Ǩ�ͺ��á����
            if (isPlay)
            {
                
                if (isPlayed == false)
                {
                    Average = inputsAverage[0];
                    Sum = inputsSum[0];

                    //��Ǩ�ͺ��ҵ�����˹�١���ҧ
                    if (isVariableAactive && inputGUI.activeSelf != true && outputGUI.activeSelf == false )
                    {
                        inputGUI.GetComponentInChildren<OnScreenKeyboad>().DeleteText();
                        inputGUI.SetActive(true);
                        inputGUI.transform.GetChild(0).GetComponentInChildren<Text>().text = "�Ѻ��� A";
                        //isVariableAactive = true;
                        inputGUI.GetComponent<OnScreenKeyboadGetValue>().isVariableAactive = true;
                        isVariableAactive = false;
                    }
                    else if (isVariableBactive && inputGUI.activeSelf != true && outputGUI.activeSelf == false) 
                    {
                        inputGUI.GetComponentInChildren<OnScreenKeyboad>().DeleteText();
                        inputGUI.SetActive(true);
                        inputGUI.transform.GetChild(0).GetComponentInChildren<Text>().text = "�Ѻ��� B";
                        //isVariableBactive = true;
                        inputGUI.GetComponent<OnScreenKeyboadGetValue>().isVariableBactive = true;
                        isVariableBactive = false;
                    }
                    else if (isVariableCactive && inputGUI.activeSelf != true && outputGUI.activeSelf == false)
                    {

                        inputGUI.GetComponentInChildren<OnScreenKeyboad>().DeleteText();
                        inputGUI.SetActive(true);
                        inputGUI.transform.GetChild(0).GetComponentInChildren<Text>().text = "�Ѻ��� C";
                        //isVariableCactive = true;
                        inputGUI.GetComponent<OnScreenKeyboadGetValue>().isVariableCactive = true;
                        isVariableCactive = false;
                    }
                    else if (isVariableDactive && inputGUI.activeSelf != true && outputGUI.activeSelf == false)
                    {

                        inputGUI.GetComponentInChildren<OnScreenKeyboad>().DeleteText();
                        inputGUI.SetActive(true);
                        inputGUI.transform.GetChild(0).GetComponentInChildren<Text>().text = "�Ѻ��� D";
                        //isVariableDactive = true;
                        inputGUI.GetComponent<OnScreenKeyboadGetValue>().isVariableDactive = true;
                        isVariableDactive = false;
                    }

                    else if (inputGUI.activeSelf == false && outputGUI.activeSelf == false)
                    {
                       
                        outValue = inputs[0];
                        variableA = inputGUI.GetComponent<OnScreenKeyboadGetValue>()._value_[0];
                        variableB = inputGUI.GetComponent<OnScreenKeyboadGetValue>()._value_[1];
                        variableC = inputGUI.GetComponent<OnScreenKeyboadGetValue>()._value_[2];
                        variableD = inputGUI.GetComponent<OnScreenKeyboadGetValue>()._value_[3];
                        
                        if (inputGUI.GetComponent<OnScreenKeyboadGetValue>()._value_[0] == -9999)
                        {
                            variableA = inputsVariableA[0];
                        }
                        if (inputGUI.GetComponent<OnScreenKeyboadGetValue>()._value_[1] == -9999)
                        {
                            variableB = inputsVariableB[0];
                        }
                        if (inputGUI.GetComponent<OnScreenKeyboadGetValue>()._value_[2] == -9999)
                        {
                            variableC = inputsVariableC[0];
                        }
                        if (inputGUI.GetComponent<OnScreenKeyboadGetValue>()._value_[3] == -9999)
                        {
                            variableD = inputsVariableD[0];
                        }
                        isPlay = true;
                        isPlayed = true;
                        Awake();
                        if (entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out).Count > 0)
                        {
                            entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].GetComponent<FlowChart>().isPlayed = false;
                            Debug.Log(entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._out)[0].name);

                        }




                    }
                }
        
           



            } 
     
            else
            {
                //�ѹ�˹���
                inputGUI.SetActive(false);
            }
            
            
            
        }
        else 
        {  
            outValue = -9999.99f; //�ó��ѧ��衴 play ����ѧ�����ա���觤���� �Ҩҡ start
        }
      
        

    }

    // Update text
    void Update()
    {
        _text.text = Text;
        

    }

   
    

  
   
}
