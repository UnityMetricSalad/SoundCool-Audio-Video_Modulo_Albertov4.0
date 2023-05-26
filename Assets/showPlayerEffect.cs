using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class showPlayerEffect : MonoBehaviour {


	static int modeView;

	public Color[] colores;
	public GameObject esfera;
	private Renderer mat;
	//public  Image fondo;
	private Color backgroundColor;
	public Image imagen;
	private Animator AnimatorLuna;
	// Use this for initialization
	void Start () {
		
		modeView=1;
		backgroundColor=imagen.color;
		mat= esfera.GetComponent<Renderer>();
		AnimatorLuna=CirculoLuna.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	static Color32 colorSelectedInterior, colorSelectedExterior;
	public SpriteRenderer CirculoInt, CirculoExt, CirculoBlanco;
	public GameObject spriteAnimaciones;
	public void changeColorInterior(float i){
		
		int j= Mathf.RoundToInt(i*10f);
		selectedColor=j;
		//Debug.Log(j + "");
		colorSelectedInterior=colores[j];
		if (modeView==0)imagen.color= colorSelectedInterior;
		if (modeView==1){
			imagen.color= new Color(colorSelectedInterior.r,colorSelectedInterior.g,colorSelectedInterior.b,0f);
			//mat.material.color=colorSelectedInterior;
			//CirculoInt.color= colorSelectedInterior;
			float floatcolor=10f*((i+0.05f)-(j/10f));
				Debug.Log(" "+floatcolor);
			CirculoInt.color= Color.Lerp(colores[j],colores[j+1],floatcolor);
			currentSpeedLuna=(i*acc);
			setAnimSpeed();//animacion de orbita lunar
		}
	}
	public void changeColorExterior(float i){

		int j= Mathf.RoundToInt(i*10f);
		selectedColor=j;
		//Debug.Log(j + "");
		colorSelectedExterior=colores[j];
		//if (modeView==0)imagen.color= colorSelectedExterior;
		if (modeView==1){
			//imagen.color= new Color(colorSelectedExterior.r,colorSelectedExterior.g,colorSelectedExterior.b,0f);
			//mat.material.color=colorSelectedExterior;
			//CirculoExt.color= colorSelectedExterior;
			float floatcolor=10f*((i+0.05f)-(j/10f));
			Color col=Color.Lerp(colores[j],colores[j+1],floatcolor);
			CirculoExt.color= col;

			Debug.Log(col);
			setAnimProgressLuna(i);
		}
	}
	private static Color transparente= new Color(1f,1f,1f,0f);

	public void ShowCirculoBlanco(bool t){
		if (t){
		CirculoBlanco.color=Color.white;}else{
			CirculoBlanco.color=transparente;
		}
	}

	public GameObject CirculoLuna;
	private static float acc= 0.15f;

	private static float currentSpeedLuna=0.5f * acc;
	private static bool ISREVERSED=false;
	public void setVolumeZoomCamera(float i){
		Camera.main.GetComponent<Animator>().SetFloat("zoom", i);

	}
	public Slider sliderScratch;

	public void setAnimStopLuna(){
		sliderScratch.value=0f;
		AnimatorLuna.SetTrigger("orbitar");
		AnimatorLuna.SetFloat ("mySpeed",0f);
		spriteAnimaciones.transform.eulerAngles=new Vector3(0f,0f,0f);
		ISPAUSED=true;

	}
	public void setAnimReverseLuna(bool t){
		if(t){
		ISREVERSED= true;
			if(!ISPAUSED)AnimatorLuna.SetFloat ("mySpeed",-currentSpeedLuna );		 
		}else{
			ISREVERSED= false;
			if(!ISPAUSED)AnimatorLuna.SetFloat ("mySpeed",currentSpeedLuna );	
		}

	}
	private static bool ISPAUSED=true;
	public void setAnimPlayPauseLuna(bool p){
		if(p){
			ISPAUSED=false;
			//AnimatorLuna.SetTrigger("orbitar");
			if (ISREVERSED){AnimatorLuna.SetFloat ("mySpeed",-currentSpeedLuna);}else{AnimatorLuna.SetFloat ("mySpeed",currentSpeedLuna);}
		}else{
			ISPAUSED=true;
			AnimatorLuna.SetFloat ("mySpeed",0f);
		}

	}
	public void setAnimSpeed(){
		
		if (ISREVERSED){
			if(!ISPAUSED)AnimatorLuna.SetFloat ("mySpeed",-currentSpeedLuna);
		}
		else {
			if(!ISPAUSED)AnimatorLuna.SetFloat ("mySpeed",currentSpeedLuna);
		}
	}
	public void setAnimProgressLuna(float p){
		//spriteAnimaciones.transform.Rotate(new Vector3(0f,0f,p*36f));
		spriteAnimaciones.transform.eulerAngles=new Vector3(0f,0f,p*-360f);
		//spriteAnimaciones.transform.Rotation=  Quaternion.AngleAxis(p, Vector3.forward);
		//spriteAnimaciones.transform.Rotation= new (new Vector3(0f,0f,p*360f));
	}



	public void changeColorInverse(bool on){
		if (on){
			Color inverse= new Color(255-colorSelectedInterior.r,255-colorSelectedInterior.g,255-colorSelectedInterior.b,1f);
		if (modeView==0)imagen.color= inverse;
		if (modeView==1){
				imagen.color= new Color(colorSelectedInterior.r,colorSelectedInterior.g,colorSelectedInterior.b,0f);
			mat.material.color=inverse;}
		}else{
			if (modeView==0)imagen.color= colorSelectedInterior;
			if (modeView==1){
				imagen.color= new Color(colorSelectedInterior.r,colorSelectedInterior.g,colorSelectedInterior.b,0f);
				mat.material.color=colorSelectedInterior;}
		}
	}




	static int selectedColor;

	public void transitColor(float t){
		//int j= Mathf.RoundToInt(i*10);

//		imagen.color= CirculoExt;

	}


}
