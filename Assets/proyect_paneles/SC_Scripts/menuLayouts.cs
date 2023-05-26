using UnityEngine;
using System.Collections;

public class menuLayouts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//1 creamos las variables publicas que va a tener nuestro menu

	//2 con "menus" controlaremos los paneles para cada opcion seleccionada
    //public GameObject[] menus= new GameObject[5];
	public GameObject[] menus= new GameObject[7];
	//2 FIN con "menus" controlaremos los paneles para cada opcion seleccionada

	//3 seleccionamos el grupo de toggles que controlara el menu
	public GameObject[] groupsButtonsMenu= new GameObject[2];
	//3 FIN seleccionamos el grupo de toggles que controlara el menu

	//4 se adjuntan las animaciones que presentara el menu
	public GameObject[] spritesAnimations= new GameObject[1];
	//public GameObject[] spritesAnimations= new GameObject[7];
	//4 FIN se adjuntan las animaciones que presentara el menu

	//1 FIN creamos las variables publicas que va a tener nuestro menu

	public void setExperimentalMenu(bool b){

		if(b){
			groupsButtonsMenu[0].SetActive(false);groupsButtonsMenu[1].SetActive(true);
		}else{
			groupsButtonsMenu[0].SetActive(true);groupsButtonsMenu[1].SetActive(false);
		}
	}

	//Con esta función se desactivan todos los paneles del menu
    private void disableAll()
    {
       foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }
		foreach (GameObject spriteanim in spritesAnimations)
		{
			spriteanim.SetActive(false);
		}

    }

    public void SetLayout(int layout)
    {
        // antes de seleccionar un menu no aseguramos de que no hay ninguno activado
		// recordemos que por defecto activamos el menu conexión, que es lo primero que hay que configurar
		disableAll();
        switch (layout)
        {
            case 0:
                menus[0].SetActive(true);
                break;

            case 1:
                menus[1].SetActive(true);
                break;

            case 2:
                menus[2].SetActive(true);
                break;

            case 3:
                menus[3].SetActive(true);
                break;

            case 4:
                menus[4].SetActive(true);
                break;
			case 5:
				menus[5].SetActive(true);
				spritesAnimations [0].SetActive (true);
				break;
			case 6:   // EL PANEL DE SETTINGS QUEDA VISIBLE 
				menus[6].SetActive(true);
				break;
		case 7: 
			menus [7].SetActive (true);
			spritesAnimations [1].SetActive (true);
			break;
                

		// con estos case seleccionaremos el panel que se quiere activar y su animacion
//		            case 0:
//		                menus[0].SetActive(true);
//		                break;
//		
//		            case 1:
//		                menus[1].SetActive(true);
//		                break;
//		
//		            case 2:
//		                menus[2].SetActive(true);
//		                break;
//
//					case 3:
//						menus[3].SetActive(true);
//						break;
//
//					case 4: 
//						menus [4].SetActive (true);
//						spritesAnimations [0].SetActive (true);
//						break;

        }

    }
}
