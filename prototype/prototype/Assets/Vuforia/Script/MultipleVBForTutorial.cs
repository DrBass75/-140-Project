using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultipleVBForTutorial : MonoBehaviour

{
    public GameObject TutorialText1,TutorialText2, TutorialText3, TutorialText4, InstructionForTutorial;
    VirtualButtonBehaviour[] vbs;

    void Start()

    {
        vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; i++)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }

        TutorialText1.SetActive(false);
        TutorialText2.SetActive(false);
        TutorialText3.SetActive(false);
        TutorialText4.SetActive(false);
        InstructionForTutorial.SetActive(true);
    }

    void Update()
    {


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        /*if(vbs[0].VirtualButtonName== "VirtualButton1")
        {
            TutorialText1.SetActive(true);
            TutorialText2.SetActive(false);
            TutorialText3.SetActive(false);
            TutorialText4.SetActive(false);
            InstructionForTutorial.SetActive(false);
        }
        else if(vbs[1].VirtualButtonName == "VirtualButton2")
        {
            TutorialText1.SetActive(false);
            TutorialText2.SetActive(true);
            TutorialText3.SetActive(false);
            TutorialText4.SetActive(false);
            InstructionForTutorial.SetActive(false);
        }
        else if(vbs[2].VirtualButtonName == "VirtualButton3")
        {
            TutorialText1.SetActive(false);
            TutorialText2.SetActive(false);
            TutorialText3.SetActive(true);
            TutorialText4.SetActive(false);
            InstructionForTutorial.SetActive(false);
        }
        else if(vbs[4].VirtualButtonName == "VirtualButton3")
        {
            TutorialText1.SetActive(false);
            TutorialText2.SetActive(false);
            TutorialText3.SetActive(false);
            TutorialText4.SetActive(true);
            InstructionForTutorial.SetActive(false);
        }
        */switch (vb.VirtualButtonName)
        {
            case "VirtualButton1":
              TutorialText1.SetActive(true);
              TutorialText2.SetActive(false);
              TutorialText3.SetActive(false);
              TutorialText4.SetActive(false);
              InstructionForTutorial.SetActive(false);
              break;

            case "VirtualButton2":
              TutorialText1.SetActive(false);
              TutorialText2.SetActive(true);
              TutorialText3.SetActive(false);
              TutorialText4.SetActive(false);
              InstructionForTutorial.SetActive(false);
              break;

            case "VirtualButton3":
              TutorialText1.SetActive(false);
              TutorialText2.SetActive(false);
              TutorialText3.SetActive(true);
              TutorialText4.SetActive(false);
              InstructionForTutorial.SetActive(false);
              break;

            case "VirtualButton4":
              TutorialText1.SetActive(false);
              TutorialText2.SetActive(false);
              TutorialText3.SetActive(false);
              TutorialText4.SetActive(true);
              InstructionForTutorial.SetActive(false);
              break;

            default:
              TutorialText1.SetActive(false);
              TutorialText2.SetActive(false);
              TutorialText3.SetActive(false);
              TutorialText4.SetActive(false);
              InstructionForTutorial.SetActive(true);
              break;
        }
        
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

}
