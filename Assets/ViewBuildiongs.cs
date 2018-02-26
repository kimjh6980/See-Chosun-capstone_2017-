using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System;

public class ViewBuildiongs : MonoBehaviour {
    public GameObject name;
    private string buildingname;
    public GameObject building;
    public GameObject pos;


    public void namefield()
    {
        if (buildingname == "It융합대학")
        {
            building.active = true;
            pos.active = true;
        }
    }
    void Start()
    {

    }
    void Update()
    {
        buildingname = name.GetComponent<InputField>().text;
    }
}
