using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UniOSC;

public class PointerPruebaKey : MonoBehaviour
{

    public RectTransform panel;
    public int NumberOfKey;
    private int resultado;
    public int _KeyNumber;

    private bool IsOnKey;
    private bool TeclaAdyacente;
    private volatile bool _IsOnPanel;
    private volatile bool _IsOnKey;
    private bool aux_osc = false;
    public PointerPruebaPanel ScriptPanel;
    public PointerPruebaKeyBlack ScriptKey;

    public Button boton;
    public Color coloroscuro;
    public Color colorclaro;

    // Use this for initialization
    void Start()
    {
        panel = GetComponent<RectTransform>();
        boton = GetComponent<Button>();

        ScriptPanel.ObtenerValor();
        ScriptKey.IsOnKeyPanel();
    }

    // Update is called once per frame
    void Key()
    {
        Camera UICam = null;
        _IsOnKey = RectTransformUtility.RectangleContainsScreenPoint(panel, new Vector2(Input.mousePosition.x, Input.mousePosition.y), UICam);

        _KeyNumber = ScriptPanel.ObtenerKeyNumber();
        _IsOnPanel = ScriptPanel.ObtenerValor();
        TeclaAdyacente = ScriptKey.IsOnKeyPanel();

        if (Input.touchCount <= 1)
        {
            IsOnTheKey(_IsOnPanel, _IsOnKey, _KeyNumber, NumberOfKey, TeclaAdyacente);

            ScriptPanel.KeyNumber = resultado;
        }
        else if (Input.touchCount == 0)
        {

        }
        /*else
        {
            ScriptPanel.KeyNumber = resultado;
        }*/

    }

    private int IsOnTheKey(bool IsOnPanel, bool IsOnKey, int integer1, int integer2, bool TeclaAdyacenteActiva)
    {

        if (IsOnPanel == true)
        {
            if (IsOnKey == true)
            {
                if (TeclaAdyacenteActiva == true)
                {
                    PintarColor(boton, colorclaro);
                    resultado = integer1;
                }
                else //if (TeclaAdyacenteActiva == false)
                {
                    PintarColor(boton, coloroscuro);
                    resultado = integer2;
                }
            }
            else //if (IsOnKey == false)
            {
                PintarColor(boton, colorclaro);
                resultado = integer1;
            }
        }
        else //if (IsOnPanel == false)
        {
            if (integer2 == integer1)
            {
                PintarColor(boton, coloroscuro);
                resultado = integer1;
            }
            else //if (integer2 != integer1)
            {
                PintarColor(boton, colorclaro);
                resultado = integer1;
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
