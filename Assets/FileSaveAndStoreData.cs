using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Windows;

public class FileSaveAndStoreData : MonoBehaviour
{
    string pcname;
    string pcmodel;
    string resolution;
    //string resolutonwidth;
    int ram;
    //string hobbies = "playing cricket";
    //string time = System.DateTime.Now.ToString();
    // Start is called before the first frame update
    void Awake()
    {
        pcname = SystemInfo.deviceName;
        pcmodel = SystemInfo.deviceModel;
        ram = SystemInfo.systemMemorySize;
        resolution = Screen.currentResolution.ToString();
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
        string filePath = Application.persistentDataPath + "/pcdata.file";
        //StreamWriter sw = new StreamWriter(filePath);
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
        BinaryWriter sw = new BinaryWriter(fs);
        sw.Write(pcname);
        sw.Write(pcmodel);
        sw.Write(ram);
        sw.Write(resolution);
        sw.Close();
        fs.Close();
    }
    void GetPlayerData()
    {
        string filePath = Application.persistentDataPath + "/pcdata.file";
        //StreamReader sd = new StreamReader(filePath);
        //string message= sd.ReadToEnd();
        //Debug.Log(message);
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
        BinaryReader sd = new BinaryReader(fs);
        pcname=sd.ReadString();
        pcmodel = sd.ReadString();
        ram = sd.ReadInt32();
        resolution = sd.ReadString();
        print("pcname"+pcname+"pcmodel"+pcmodel+"ram"+ram+"resolution"+resolution);
        sd.Close();
        fs.Close();
    }
}
