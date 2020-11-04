using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour

{
    public GameObject TutorialText, InstructionForTutorial;
    VirtualButtonBehaviour[] vbs;

    void Start()

    {
        vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }

        TutorialText.SetActive(false);
        InstructionForTutorial.SetActive(true);
    }

    void Update()
    {


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        TutorialText.SetActive(true);
        InstructionForTutorial.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        TutorialText.SetActive(false);
        InstructionForTutorial.SetActive(true);
    }
}