using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json.Linq;

public class JsonDemo : MonoBehaviour
{
    public string pname;
    public int age;
    public string country;
    public string[] friends;
    public string[] hobbies;
    //public string[] friend;
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
        string filepath = Application.persistentDataPath + "/MyData.file";
        //Adding one pair 
        JObject jobj = new JObject();
        jobj.Add("componentName", this.pname);
        jobj.Add("Country", "India");
        //adding pair within that different pairs
        JObject jdataDemo = new JObject();
        jobj.Add("data", jdataDemo);
        jdataDemo.Add("_name", "hds");
        jdataDemo.Add("_curHp", this.age);
        //adding array to one key
        JArray jarraydata = JArray.FromObject(friends);
        jdataDemo.Add("_friends", jarraydata);

        JArray jdataDemoPractise =JArray.FromObject(hobbies);
        jobj.Add("hobbies",jdataDemoPractise);

        StreamWriter sw = new StreamWriter(filepath);
        sw.WriteLine(jobj.ToString());

        sw.Close();
    }
    void getData()
    {
        string filepath = Application.persistentDataPath + "/MyData.file";
        StreamReader sr = new StreamReader(filepath);
        string data =sr.ReadToEnd();
        //print(data);
        sr.Close();

        JObject jsonObj = JObject.Parse(data);
        pname = jsonObj["componentName"].Value<string>();
        age = jsonObj["data"]["_curHp"].Value<int>();
        friends = jsonObj["data"]["_friends"].ToObject<string[]>();
   }
}
