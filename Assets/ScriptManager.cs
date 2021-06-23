using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptManager : MonoBehaviour
{
    [SerializeField] Text lati;
    public Text lon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lati.text = GPSLocation.Latitude.ToString();
        lon.text = GPSLocation.Longitude.ToString();
    }
}
