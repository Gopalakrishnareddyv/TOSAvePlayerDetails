using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SerializeField]
public class SceneController : MonoBehaviour
{
    public static string keyword;
    
    public void Start()
    {
        //Debug.Log(keyword);
        // A correct website page.
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
    public void AskGoogle(string keywordName)
    {
        keyword = keywordName;
        //Debug.Log(keyword);
    }


    
    }
