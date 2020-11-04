using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBHouse : MonoBehaviour
{
    public GameObject TrialHouseFull, TrialHouseFirstFloor, TrialHouseSecondFloor, Kitchen, TrialRoom;
    VirtualButtonBehaviour[] vbs;
    // Start is called before the first frame update
    void Start()
    {
        vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }

        TrialHouseFull.SetActive(true);
        TrialHouseFirstFloor.SetActive(false);
        TrialHouseSecondFloor.SetActive(false);
        Kitchen.SetActive(false);
        TrialRoom.SetActive(false);

    }

    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "VirtualButtonFull":
                TrialHouseFull.SetActive(true);
                TrialHouseFirstFloor.SetActive(false);
                TrialHouseSecondFloor.SetActive(false);
                Kitchen.SetActive(false);
                TrialRoom.SetActive(false);
                break;

            case "VirtualButtonFirst":
                TrialHouseFull.SetActive(false);
                TrialHouseFirstFloor.SetActive(true);
                TrialHouseSecondFloor.SetActive(false);
                Kitchen.SetActive(false);
                TrialRoom.SetActive(false);
                break;

            case "VirtualButtonSecond":
                TrialHouseFull.SetActive(false);
                TrialHouseFirstFloor.SetActive(false);
                TrialHouseSecondFloor.SetActive(true);
                Kitchen.SetActive(false);
                TrialRoom.SetActive(false);
                break;

            case "VirtualButtonKitchen":
                TrialHouseFull.SetActive(false);
                TrialHouseFirstFloor.SetActive(false);
                TrialHouseSecondFloor.SetActive(false);
                Kitchen.SetActive(true);
                TrialRoom.SetActive(false);
                break;

            case "VirtualButtonTrialRoom":
                TrialHouseFull.SetActive(false);
                TrialHouseFirstFloor.SetActive(false);
                TrialHouseSecondFloor.SetActive(false);
                Kitchen.SetActive(false);
                TrialRoom.SetActive(true);
                break;

            default:
                TrialHouseFull.SetActive(true);
                TrialHouseFirstFloor.SetActive(false);
                TrialHouseSecondFloor.SetActive(false);
                Kitchen.SetActive(false);
                TrialRoom.SetActive(false);
                break;
        }

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
            
    }

}
