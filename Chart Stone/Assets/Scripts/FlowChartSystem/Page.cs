using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Page : MonoBehaviour
{
    public GameObject tap1;
    public GameObject tap2;
    public float posX1, posX2, posY1, posY2;
    public GameObject b1;
    public GameObject b2;
    private void Start()
    {
        Page1();
    }
    public void Page1()
    {

        b2.GetComponent<Image>().color = Color.gray;
        b1.GetComponent<Image>().color = Color.white;
        tap2.transform.localPosition = new Vector3(posX2, posY2, 0);
        tap1.transform.localPosition = new Vector3(posX1, posY1, 0);
    }
    public void Page2()
    {
        b1.GetComponent<Image>().color = Color.gray;
        b2.GetComponent<Image>().color = Color.white;
        tap2.transform.localPosition = new Vector3(posX1, posY1, 0);
        tap1.transform.localPosition = new Vector3(posX2, posY2, 0);

    }

   
}
