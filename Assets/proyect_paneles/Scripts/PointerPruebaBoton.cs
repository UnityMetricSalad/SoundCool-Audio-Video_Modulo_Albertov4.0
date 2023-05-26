using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UniOSC;

public class PointerPruebaBoton : MonoBehaviour
{

    public RectTransform panel;
    public int NumberOfKey;
    private int resultado;
    public int _KeyNumber;

    private bool IsOnKey;
    private bool _IsOnPanel;
    private bool aux_osc = false;
    public PointerPruebaPanel ScriptPanel;

    public Button boton;
    public Color coloroscuro;
    public Color colorclaro;

    // Use this for initialization
    void Start()
    {
        panel = GetComponent<RectTransform>();
        boton = GetComponent<Button>();

        ScriptPanel.ObtenerValor();

        resultado = 20;
        _KeyNumber = 20;
    }

    // Update is called once per frame
    void Update()
    {
        Camera UICam = null;
        IsOnKey = RectTransformUtility.RectangleContainsScreenPoint(panel, new Vector2(Input.mousePosition.x, Input.mousePosition.y), UICam);

        _KeyNumber = ScriptPanel.ObtenerKeyNumber(); //int
        _IsOnPanel = ScriptPanel.ObtenerValor(); //bool

        if (Input.touchCount <= 1)
        {
            IsOnTheKey(_IsOnPanel, IsOnKey, _KeyNumber, NumberOfKey);

            ScriptPanel.KeyNumber = resultado;
        }
        /*else
        {
            ScriptPanel.KeyNumber = resultado;
        }*/
    }

    int IsOnTheKey(bool IsOnPanel, bool IsOnButton, int integer1, int integer2)
    {
        if (IsOnPanel == true)
        {
            if (IsOnButton == true)
            {
                PintarColor(boton, coloroscuro);
                resultado = integer2;
                //this.GetComponent<UniOSCEventDispatcherButton>().SendOSCMessageDown();
                //aux_osc = true;
                if (aux_osc == false)
                {
                    this.GetComponent<UniOSCEventDispatcherButton>().SendOSCMessageDown();
                    aux_osc = true;
                }
            }
            else //if (IsOnButton == false)
            {
                PintarColor(boton, colorclaro);
                resultado = integer1;
                /*if (aux_osc == true)
                {
                    this.GetComponent<UniOSCEventDispatcherButton>().SendOSCMessageUp();
                    aux_osc = false;
                }*/
            }
        }
        else if (IsOnPanel == false)
        {
            if (IsOnButton == true)
            {
                PintarColor(boton, colorclaro);
                resultado = integer1;
                /*if (aux_osc == true)
                {
                    //this.GetComponent<UniOSCEventDispatcherButton>().SendOSCMessageUp();
                    aux_osc = false;
                }*/
            }
            else //if (IsOnButton == false)
            {
                if (integer1 == integer2)
                {
                    PintarColor(boton, coloroscuro);
                    resultado = integer1;
                    if (aux_osc == true)
                    {
                        this.GetComponent<UniOSCEventDispatcherButton>().SendOSCMessageUp();
                        aux_osc = false;
                    }
                }
                else
                {
                    PintarColor(boton, colorclaro);
                    resultado = integer1;
                    if (aux_osc == true)
                    {
                        this.GetComponent<UniOSCEventDispatcherButton>().SendOSCMessageUp();
                        aux_osc = false;
                    }
                }
            }
        }

        return resultado;
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
