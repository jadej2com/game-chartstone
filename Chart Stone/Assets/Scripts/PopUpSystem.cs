using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpbox;
    public GameObject BtnAttack;
    public GameObject Questions;
   
    // public Text dialogText;
    // public Text aBtnText;
    // public Text bBtnText;
    // public string dialog;
    public bool PlayerInRange;
    // public Animator animator;
    // public TMP_Text popUpText;

    // public void Popup(string text)
    // {
    //     // popUpBox.SetActive(true);
    //     // popUpText.text = text;
    //     animator.SetTrigger("pop");
    // }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popUpbox.SetActive(true);
            Debug.Log("Player in range");
            PlayerInRange = true;
        }
    }
    

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popUpbox.SetActive(false);
            Debug.Log("Player left range");
            PlayerInRange = false;
        }
    }


    //test
    public void OnButtonA()
    {

        popUpbox.SetActive(false);
        BtnAttack.SetActive(true);
        Questions.SetActive(false);
    }

    //     public void OnButtonB()
    //     {
    //         Debug.Log("ตอบผิด");
    //         dialogBox.SetActive(false);
    //     }


    //test
    public void PopUp()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (popUpbox.activeInHierarchy)
            {
                popUpbox.SetActive(false);
            }
            else
            {
                popUpbox.SetActive(true);
            }
        }
    }

    public void Update()
    {

    }


}