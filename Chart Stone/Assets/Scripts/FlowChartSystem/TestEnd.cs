using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestEnd : MonoBehaviour
{
    public static TestEnd instance;
    public Text text;
    public Text[] titleTest;
    public int[] ans;
    public int randomNumber;
    void Start()
    {
        randomNumber = Random.Range(0, titleTest.Length);
        Debug.Log(randomNumber);
        instance = this;
    }

  
}
