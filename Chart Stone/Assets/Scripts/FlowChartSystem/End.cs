using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class End : FlowChart
{

    private Color colorTextButtonPlay;
    public enum Map { map0 ,map1 ,map2,map3,map4}
    public Map map;
    public int dice;
    public Text title;
    protected override void Awake()
    {
        base.Awake();
        //_image = GetComponent<Image>();
        // _text = transform.GetChild(0).GetComponentInChildren<Text>();
        entity = GetComponent<UIC_Entity>();
       

    }

    private void Start()
    {
        colorTextButtonPlay = Controller.instane.play.GetComponentInChildren<Text>().color; 

        if(map.ToString() == "map1")
        {
           dice = Random.Range(1,3);
            if(dice == 1)
            {
                title.text = "จงสร้างอัลกอริทึมหาค่าเฉลี่ยของตัวเลข 3 ตัว";
            }
            else
            {
                title.text = "จงสร้างอัลกอริทึมหาผลรวมของตัวเลข 3 ตัว";
            }
        }
    }
    void Update()
    {
        /*if(entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._in).Count > 0)
        {
            Debug.Log(entity.GetEntitiesConnectedToPolarity(UIC_Node.PolarityTypeEnum._in)[0].name);

        }

        if(outValue == 11)
        {
            Controller.instane.outValue = 1;
        }
        else if(outValue == -9999.99f)
        {
            Controller.instane.outValue = 2;
        }*/

        if (isDone)
        {

            Controller.instane.play.enabled = true;
            Controller.instane.play.image.color = Color.white;
            Controller.instane.play.GetComponentInChildren<Text>().color = colorTextButtonPlay;
            if (isPlay)
            {
                if (map.ToString() == "map0")
                {
                    if (outValue == 11)
                    {
                        Controller.instane.ScorllGUI(100);
                        
                    }
                }
                else if (map.ToString() == "map1")
                {
                    if(dice == 1)
                    {
                        if(Average == (variableA + variableB + variableC) / 3)
                        {
                            Debug.Log("ans:" + Average);
                        }
                        else
                        {
                            Debug.Log("wrong:" + (variableA + variableB + variableC) / 3);

                        }
                    }
                    else
                    {
                        if (Sum == (variableA + variableB + variableC))
                        {
                            Debug.Log("ans:" + Sum);
                        }
                        else
                        {
                            Debug.Log("wrong:" + (variableA + variableB + variableC));
                        }
                    }
                    Debug.Log("map1");
                }
                else if (map.ToString() == "map2")
                {
                    Debug.Log("map2");
                }
                else if (map.ToString() == "map3")
                {
                    Debug.Log("map3");
                }
                else if (map.ToString() == "map4")
                {
                    Debug.Log("map4");
                }

            }
        }
        else
        {
            Controller.instane.play.enabled = false;
            Controller.instane.play.image.color = Color.black;
            Controller.instane.play.GetComponentInChildren<Text>().color = Color.white;
        }

       







        //Debug.Log(isPlay);
        /*Debug.Log("Result" + outValue);
        Debug.Log("Variabel A" + variableA);
        Debug.Log("Variabel B" + variableB);
        Debug.Log("Variabel C" + variableC);
        Debug.Log("Variabel D" + variableD);*/




        /* if (outValue == 1)
         {
             Color outColor = Color.green;
             ColorUtility.TryParseHtmlString("#6AFF6A", out outColor);
             _image.color = outColor;
             _text.text = "on";
         }
         else if (outValue == 0)
         {
             Color outColor = Color.green;
             ColorUtility.TryParseHtmlString("#636363", out outColor);
             _image.color = outColor;
             _text.text = "off";
         }
         else
         {
             _image.color = new Color(1, 1, 1);
             _text.text = "--";
         }*/
    }

    Image _image;
    Text _text;

    public override void Solve()
    {
        GetInput();
       
        if (inputs.Count > 0)
        {
            isPlay = inputIsPlay[0];
            isDone = inputIsDone[0];
           
            if (isPlay)
            {
                if(isPlayed == false)
                {
                    outValue = inputs[0];
                    variableA = inputsVariableA[0];
                    variableB = inputsVariableB[0];
                    variableC = inputsVariableC[0];
                    variableD = inputsVariableD[0];
                    Average = inputsAverage[0];
                    Sum = inputsSum[0];
                    Debug.Log("A B C" + variableA + ":" + variableB + ":" + variableC);

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
