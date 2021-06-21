using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PractiseForStoreData : MonoBehaviour
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
            setData();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            getData();
        }
    }
    void setData()
    {
        string filepath = Application.persistentDataPath + "/practise.file";
        FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write("Gopal");
        bw.Write(10);
        bw.Close();
        fs.Close();
    }
    void getData()
    {
        string filepath = Application.persistentDataPath + "/practise.file";
        FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
        BinaryReader br = new BinaryReader(fs);
        string data=br.ReadString();
        int num = br.ReadInt32();
        print(data);
        //print(num);
        br.Close();
        fs.Close();
    }
}
