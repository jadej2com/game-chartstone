using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI TimeGUI;
    [SerializeField] public GameObject Parent;
    [HideInInspector] public float time1;
    [HideInInspector] public float time2;
    [HideInInspector] public int outValue;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public Text score;
    public static Controller instane;
    public Button replay;
    public Button home;
    public Button next;
    public Button play;
    public Button reset;
    public GameObject ScoreGUI;
    public GameObject FlowChartCraftingSystem;
    public int ScoreInMap;

    public Start start;
    public enum Map {map0, map1 }
    public Map map;
    private int scoreMap0;
    private int scoreMap1;
    private int scoreMap2;
    private int scoreMap3;
    private int scoreMap4;
    private void Awake()
    {
        instane = this;
      
    }
    public void isPlay()
    {
        start.Play = true;
    }


    public void isReset()
    {
        start.Play = false;


    }



    private void Update()
    {
       

        if (Parent.activeSelf)
        {
            time2 = Time.time - time1;
            TimeGUI.text = "Time: " + time2.ToString();

        }


    }

    public void NextScene()
    {
        if (map.ToString() == "map0")
        {
            PlayerPrefs.SetInt("map", 1);
            PlayerPrefs.SetInt("Score0",scoreMap0 );
            SceneManager.LoadScene("Map1");
        }
    }

    public void ReGame()
    {
         Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    void OnEnable()
    {
        next.onClick.AddListener(NextScene);
        replay.onClick.AddListener(ReGame);
    }

    void OnDisable()
    {
        next.onClick.RemoveAllListeners();
        replay.onClick.RemoveAllListeners();
    }

    


    public void ScorllGUI(int score1)
    {
        ScoreInMap += score1;
        ScoreGUI.SetActive(true);
        FlowChartCraftingSystem.SetActive(false);
        score.text = "Score : "  + ScoreInMap.ToString();
        if(map.ToString() == "map0")
        {
            if (time2 >= 90)
            {
                ScoreInMap -= 30;
            }
            if(ScoreInMap > 80)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);
                scoreMap0 = 3;
            }else if (ScoreInMap < 80 && ScoreInMap > 50)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(false);
                scoreMap0 = 2;

            }
            else if (ScoreInMap < 50 && ScoreInMap > 10)
            {
                Star1.SetActive(true);
                Star2.SetActive(false);
                Star3.SetActive(false);
                scoreMap0 = 1;

            }
            else if (ScoreInMap < 10)
            {
                Star1.SetActive(false);
                Star2.SetActive(false);
                Star3.SetActive(false);
                next.gameObject.SetActive(false);
            }
        }

          
        
    }
   
}
