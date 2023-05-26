using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOpciones : MonoBehaviour
{

    //1********************* botones menu **********************************

    //este codigo abre el menu de AUDIO
    public void ButtonAudio()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    //este codigo abre el menu de VIDEO
    public void ButtonVideo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void ButtonReturn()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    //1********************* fin botones menu ******************************

    //2********************* boton salir ***********************************

    //este codigo cierra la aplicacion
    //	public void ButtonExit () {
    //		UnityEngine.Application.Quit ();
    //	}

    //2********************* fin boton salir *******************************

    //3********************** boton URL ************************************

    /*public void ButtonUrl(string abrirUrl)
    {
        UnityEngine.Application.OpenURL(abrirUrl);
    }*/

    //3********************* fin boton URL *********************************

    //4******** boton Volver a menu principal desde menu conexion **********

    //	public void ButtonVolver () {
    //		UnityEngine.SceneManagement.SceneManager.LoadScene (0);
    //	}

    //4***** FIN boton Volver a menu principal desde menu conexion *********

}
