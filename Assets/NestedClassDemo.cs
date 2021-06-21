using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class NestedClassDemo : MonoBehaviour
{
    [SerializeField] string playername = "XYZ";
    int score = 50;
    string playercountry = "India";
    //int age = 23;
    [System.Serializable]
    private class DataDemo
    {
        public string playername;
        int score;
        string playercountry;
        public DataDemo(string playername, int score, string playercountry)
        {
            this.playername = playername;
            this.score = score;
            this.playercountry = playercountry;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            setData();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            getData();
        }
    }
    void setData()
    {
        string filepath = Application.persistentDataPath + "/NestedDemo.file";
        FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
        BinaryFormatter bw = new BinaryFormatter();
        DataDemo newdatademo = new DataDemo(playername,score,playercountry);
        bw.Serialize(fs, newdatademo);
        print("saved");
        fs.Close();
    }
    void getData()
    {
        string filepath = Application.persistentDataPath + "/NestedDemo.file";
        FileStream fs = new FileStream(filepath, FileMode.Open);
        BinaryFormatter br = new BinaryFormatter();
        //BinaryReader br = new BinaryReader(fs);
        //DataDemo datademo = new DataDemo(playername, score, playercountry);
        DataDemo data = (DataDemo)br.Deserialize(fs);
        string name = data.playername;
        Debug.Log(name);
        fs.Close();
        //Debug.Log("Get");

    }
}
