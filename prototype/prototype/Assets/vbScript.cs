using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour

{
    public GameObject AscendingRoof;
    VirtualButtonBehaviour[] vbs;

    void Start()

    {
        vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }

        AscendingRoof.SetActive(false);
    }

    void Update()
    {


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        AscendingRoof.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        AscendingRoof.SetActive(false);
    }
}
