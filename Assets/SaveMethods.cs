using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMethods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetPlayerData();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetPlayerData();
        }
    }
    void SetPlayerData()
    {
        PlayerPrefs.SetInt("Score", 10);
        PlayerPrefs.SetString("Name", "XYZ");
        PlayerPrefs.SetFloat("Time", 14.58f);
        Debug.Log("Saved the player details");
    }
    void GetPlayerData()
    {
        
        string name=PlayerPrefs.GetString("Name");
        int score=PlayerPrefs.GetInt("Score");
        float time = PlayerPrefs.GetFloat("Time");
        Debug.Log("name is "+name);
        Debug.Log("SCore is " + score);
        Debug.Log("time is " + time);
    }
}
