using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPSText : MonoBehaviour {

    public Text coordinates;
    
    void Start()
    {

    }
    private void Update()
    {
        coordinates.text = "위도:" + GPS.Instance.latitude.ToString() + "   경도:" + GPS.Instance.longitude.ToString();
    }
}