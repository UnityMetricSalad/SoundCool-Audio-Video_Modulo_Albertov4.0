using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class PointerPruebaPanel : MonoBehaviour
{

    public RectTransform panel;

    private bool IsOnPanel;
    private bool IsOnPanelKeys;
    public bool Res = true;
    //public int TeclaActiva = 0;
    public int KeyNumber;
    private bool aux2 = true;
    private int aux;

    // Use this for initialization
    void Start()
    {

        panel = GetComponent<RectTransform>();
        //KeyNumber;

    }

    // Update is called once per frame
    void Update()
    {

        Camera UICam = null;
        IsOnPanelKeys = RectTransformUtility.RectangleContainsScreenPoint(panel, new Vector2(Input.mousePosition.x, Input.mousePosition.y), UICam);
        //ObtenerValor();
        //ObtenerTeclaActiva();
        //ObtenerKeyNumber();
        if (Input.touchCount <= 1)
        {
            ObtenerValor();
        }
        else
        {
            //Res = true;
        }

    }

    public bool ObtenerValor()
    {
        if (IsOnPanelKeys == true)
        {
            Res = true;
            ObtenerKeyNumber();
        }
        else
        {
            if (aux2 == true)
            {
                Res = true;
                aux2 = false;
            }
            Res = false;
        }

        //Debug.Log("El estado de la variable es: " + Res);
        return Res;
    }

    /*public int ObtenerTeclaActiva()
    {
        aux = TeclaActiva;
        TeclaActiva = aux;
        return TeclaActiva;
    }*/

    public int ObtenerKeyNumber()
    {
        //KeyNumber = KeyNumber;
        aux = KeyNumber;
        KeyNumber = aux;
        return KeyNumber;
    }

    /*public bool IsOnThePanel()
    {

        if (IsOnPanelKeys == true)
        {

            IsOnPanel = true;
            //Debug.Log("OnPointerExit: On panel");
            //Debug.Log(IsOnPanel);

        }
        else if (IsOnPanelKeys == false)
        {

            IsOnPanel = false;
            //Debug.Log("OnPointerExit: Out panel");
            //Debug.Log(IsOnPanel);

        }

        return IsOnPanel;

    }*/
}
