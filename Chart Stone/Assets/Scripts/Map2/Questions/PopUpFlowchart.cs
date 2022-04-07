using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpFlowchart : MonoBehaviour
{
    public GameObject popUpbox;
    public GameObject[] item;
    public bool PlayerInRange;
    [SerializeField] public Sprite[] diceImages;
    public static PopUpFlowchart instance;
    public int randomNumber;


    public string[] AnsA;
    public string[] AnsB;
    public string[] Ans;
    int randomNumberItems;

    void Start()
    {
        randomNumber = Random.Range(0, diceImages.Length);
        Debug.Log(randomNumber);
        Debug.Log("d"+ diceImages.Length);



    }

   


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            instance = this;

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
   

   public void Destroy()
    {
        Destroy(GetComponent<BoxCollider2D>());
        Destroy(GetComponent<PopUpFlowchart>());
        Destroy(transform.Find("Sprite").GetComponent<SpriteRenderer>());
    }


    public void RandomItem()
    {
        Destroy();
        randomNumberItems = Random.Range(0, item.Length);
        item[randomNumberItems].SetActive(true);


    }


      

}
