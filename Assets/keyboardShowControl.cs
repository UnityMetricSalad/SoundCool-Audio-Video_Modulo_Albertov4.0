using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyboardShowControl : MonoBehaviour {



		static int modeView;

		public Color[] colores;
		//public GameObject esfera;
		private Renderer mat;
		//public  Image fondo;
		private Color backgroundColor;
		public Image imagen;
	//	private Animator AnimatorLuna;
		// Use this for initialization
		void Start () {

			modeView=1;
			backgroundColor=imagen.color;
//			mat= esfera.GetComponent<Renderer>();
		//	AnimatorLuna=CirculoLuna.GetComponent<Animator>();
		}

		// Update is called once per frame
		void Update () {

		}
		static Color32 colorSelectedInterior, colorSelectedExterior;
		public SpriteRenderer CirculoInt, CirculoExt, CirculoBlanco;
		public GameObject spriteAnimaciones;

	public void changeColorInteriorbyIndex(int i){
		CirculoInt.color = colores [i];
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

		
		private static bool ISPAUSED=true;
		

		static int selectedColor;

		public void transitColor(float t){
			//int j= Mathf.RoundToInt(i*10);

			//		imagen.color= CirculoExt;

		}


	}
