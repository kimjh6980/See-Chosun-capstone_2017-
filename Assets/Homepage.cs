using UnityEngine;
using System.Collections;
public class Homepage : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
    }

    public void gohomepage()
    {
        Application.OpenURL("http://m.chosun.ac.kr");
    }
}