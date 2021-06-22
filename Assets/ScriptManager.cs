using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptManager : MonoBehaviour
{
    [SerializeField] Text lat;
    public Text lon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lat.text = GPSLocation.Latitude.ToString();
        lon.text = GPSLocation.Longitude.ToString();
    }
}
