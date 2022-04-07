using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadStartScense : MonoBehaviour
{
   
    void OnEnable()
    {
        SceneManager.LoadScene("FirstMap",LoadSceneMode.Single);
        
    }
}
