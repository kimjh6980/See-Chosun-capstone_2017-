using UnityEngine;
using System.Collections;
public class WebView : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
    }

    public void buttontouch()
    {
        Application.OpenURL("http://m.chosun.ac.kr/mbs/mobile2/subview.jsp?id=mobile2_080000000000");
    }
}