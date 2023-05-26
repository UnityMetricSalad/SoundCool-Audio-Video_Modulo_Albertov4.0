using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UniOSC;

public class PointerPruebaKeyBlack : MonoBehaviour
{

    public RectTransform panel;
    public int NumberOfKey;
    private int resultado;
    public int _KeyNumber;

    private bool IsOnKey;

    private volatile bool _IsOnPanel;
    private volatile bool _IsOnKey;
    private bool aux_osc = false;
    public bool DesactivarTeclaAdyacente = false;
    public PointerPruebaPanel ScriptPanel;

    public Button boton;
    public Button boton_derecha;
    public Button boton_izquierda;
    public Color coloroscuro;
    public Color colorclaro;
    public Color colorclaro2;

    // Use this for initialization
    void Start()
    {

        panel = GetComponent<RectTransform>();
        boton = GetComponent<Button>();

        ScriptPanel.ObtenerValor();
    }

    // Update is called once per frame
    void Update()
    {
        Camera UICam = null;
        _IsOnKey = RectTransformUtility.RectangleContainsScreenPoint(panel, new Vector2(Input.mousePosition.x, Input.mousePosition.y), UICam);

        _KeyNumber = ScriptPanel.ObtenerKeyNumber();
        _IsOnPanel = ScriptPanel.ObtenerValor();
        IsOnKeyPanel();

        if (Input.touchCount <= 1)
        {
            IsOnTheKey(_IsOnPanel, _IsOnKey, _KeyNumber, NumberOfKey);
            

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

    public bool IsOnKeyPanel()
    {
        if (_IsOnKey == true)
        {
            DesactivarTeclaAdyacente = true;
        }
        else //if (_IsOnKey == true)
        {
            DesactivarTeclaAdyacente = false;
        }

        return DesactivarTeclaAdyacente;
    }

    int IsOnTheKey(bool IsOnPanel, bool IsOnkey, int integer1, int integer2)
    {
        if (IsOnPanel == true)
        {
            if (IsOnkey == true)
            {
                PintarColor(boton, coloroscuro);
                PintarColor(boton_derecha, colorclaro2);
                PintarColor(boton_izquierda, colorclaro2);
                resultado = integer2;
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
                PintarColor(boton_derecha, colorclaro2);
                PintarColor(boton_izquierda, colorclaro2);
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
