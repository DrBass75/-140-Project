using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public float scalingspeed = 0.01f;
    bool ScaleUp = false;
    bool ScaleDown = false;

    // Update is called once per frame
    void Update()
    {
        if (ScaleUp == true)
            ScaleUpButton();
        if (ScaleDown == true)
            ScaleDownButton();
    }

    public void ScaleUpButton()
    {
        GameObject.FindWithTag("TrialHouse").transform.localScale += new Vector3(scalingspeed, scalingspeed, scalingspeed);
    }
    public void ScaleDownButton()
    {
        GameObject.FindWithTag("TrialHouse").transform.localScale += new Vector3(-scalingspeed, -scalingspeed, -scalingspeed);
    }

    public void Up()
    {
        ScaleUp = true;
        ScaleDown = false;
    }
    public void Down()
    {
        ScaleUp = false;
        ScaleDown = true;
    }
    public void Stop()
    {
        ScaleUp = false;
        ScaleDown = false;
    }
}
