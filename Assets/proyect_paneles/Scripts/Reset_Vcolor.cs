using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset_Vcolor : MonoBehaviour {

    public Slider Slider1;
    public Slider Slider2;
    public Slider Slider3;
    public Slider Slider4;

    // Use this for initialization
    public void ResetearValores () {

            Slider1.value = 1f;
            Slider2.value = 1f;
            Slider3.value = 1f;
            Slider4.value = 0f;

	}

}
