using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowDetaill : MonoBehaviour
{
    public GameObject DetaillUI;
    public static ShowDetaill instance;
    public Text name;
    public Text detail;
    public Image icon;
    public  TextMeshProUGUI work;

    private void Start()
    {
        instance = this;
    }
    public void showDetail()
    {
        DetaillUI.SetActive(true);
       
    }
    public void CloseDetail()
    {
        DetaillUI.SetActive(false);

    }
}
