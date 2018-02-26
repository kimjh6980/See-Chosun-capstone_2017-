using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Vuforia;
public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButtonObject;
    // Use this for initialization
    void Start()
    {
        vbButtonObject = GameObject.Find("actionButton");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
    }
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        SceneManager.LoadScene("Scene3.1");
    }
}
