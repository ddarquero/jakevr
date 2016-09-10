﻿using UnityEngine;
using VRTK;

public class ControlReactor_Code : MonoBehaviour
{
    public TextMesh go;
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;

    private void Start()
    {
        slider1 = GameObject.Find("Slider1");
        slider2 = GameObject.Find("Slider2");
        slider3 = GameObject.Find("Slider3");
    }

    private void Update()
    {
        SliderChange(slider1.GetComponent<VRTK_Control>().GetValue(), slider2.GetComponent<VRTK_Control>().GetValue(), slider3.GetComponent<VRTK_Control>().GetValue());
    }

    private void SliderChange(float value1, float value2, float value3)
    {

        if (value1 == 9 && value2 == 3 && value3 == 5)
        {
            go.text = "4852";
            
        }else
        {
            go.text = "";
        }
    }

}