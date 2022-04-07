using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    [SerializeField] Button btn_loadGame; 
    void Start()
    {
         Screen.orientation = ScreenOrientation.LandscapeLeft;

        if (!PlayerPrefs.HasKey("map"))
        {
            btn_loadGame.enabled = false;
            Debug.Log("No");
        }
        
    }
    public void NewGameButton()
    {
        SceneManager.LoadScene("TutorialMap");
    }
    public void QuitButton()
    {
        Application.Quit();
    }


    public void LoadSave()
    {
        if (PlayerPrefs.GetInt("map") == 1){
            SceneManager.LoadScene("map1");
        }
    }

    public void Test()
    {
        SceneManager.LoadScene("Menu");
    }
}
