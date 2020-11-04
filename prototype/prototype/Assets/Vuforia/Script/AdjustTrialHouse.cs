﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustTrialHouse : MonoBehaviour
{
    public float rotationMin = 0.0f;
    public float rotationMax = 45.0f;
    public Slider RotateSlider;
    public Slider ScaleSlider;

    [SerializeField] float currentRotation = 0f;
    [SerializeField] float currentScale = 0.1f;

    void Start()
    {
        RotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0.0f, RotateSlider.value, 0.0f);
        transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value);
    }

    public void OnGUI()
    {
        currentRotation = GUI.HorizontalSlider(new Rect(-280f, 165.0f, 228.0f, 57.0f), currentRotation, 0.0f, 45.0f);
        transform.localEulerAngles = new Vector3(0.0f, currentRotation, 0.0f);
        currentRotation = GUI.HorizontalSlider(new Rect(-280f, 165.0f, 228.0f, 57.0f), currentScale, 0.0f, 2f);
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }

    public void AdjustAngle(float newAngle)
    {

    }
    public void AdjustScale(float newScale)
    {

    }
}
