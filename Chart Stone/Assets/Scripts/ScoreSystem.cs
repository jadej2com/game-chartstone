using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    public GameObject UiScore;
    public GameObject otherUi1;
    public GameObject otherUi2;

    public void openScore()
    {
        UiScore.SetActive(true);
        otherUi1.SetActive(false);
        otherUi2.SetActive(false);

    
    }
    public void ReGame()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }


    public void nextScene()
    {
        SceneManager.LoadScene("Map1");
    }


    
}
