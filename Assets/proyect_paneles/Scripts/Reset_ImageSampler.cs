using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset_ImageSampler : MonoBehaviour {

    public Button ImageSamplerKey1;
    public Button ImageSamplerKey2;
    public Button ImageSamplerKey3;
    public Button ImageSamplerKey4;
    public Button ImageSamplerKey5;
    public Button ImageSamplerKey6;
    public Button ImageSamplerKey7;
    public Button ImageSamplerKey8;
    public Button ImageSamplerKey9;
    public Button ImageSamplerKey10;
    public Button ImageSamplerKey11;
    public Button ImageSamplerKey12;
    public Button ImageSamplerKey13;

    public Color ColorClaro1;
    public Color ColorClaro2;

    void Start()
    {

        GetComponent<Animator>();
        ImageSamplerKey1 = GetComponent<Button>();

    }

    public void ResetearEstado () {

        ImageSamplerKey1.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey2.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey3.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey4.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey5.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey6.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey7.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey8.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey9.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey10.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey11.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey12.GetComponent<Animator>().SetTrigger("Normal");
        ImageSamplerKey13.GetComponent<Animator>().SetTrigger("Normal");

        //PintarColor(ImageSamplerKey1 , ColorClaro1);

    }

    private void PintarColor(Button boton, Color color)
    {
        ColorBlock cb = boton.colors;
        cb.normalColor = color;
        cb.disabledColor = color;
        cb.highlightedColor = color;
        cb.pressedColor = color;
        boton.colors = cb;
    }

}
