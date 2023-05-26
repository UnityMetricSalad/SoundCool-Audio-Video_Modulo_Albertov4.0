using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset_MAVR : MonoBehaviour {

    public Slider Slider1;
    public Slider Slider2;
    public Slider Slider3;

    public void ResetValues()
    {
        Slider1.value = 0.1f;
        Slider2.value = 0.5f;
        Slider3.value = 0.2f;
    }
}
